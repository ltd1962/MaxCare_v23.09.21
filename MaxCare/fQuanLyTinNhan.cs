using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fQuanLyTinNhan : Form
{
	[CompilerGenerated]
	private sealed class D49A032D
	{
		public Chrome f336F52E_0;

		public Control FC91E835;

		internal void method_0()
		{
			SetParent(f336F52E_0.Process_0.MainWindowHandle, FC91E835.Handle);
			MoveWindow(f336F52E_0.Process_0.MainWindowHandle, -10, 0, FC91E835.Size.Width + 20, FC91E835.Size.Height + 20, bool_0: false);
		}
	}

	[CompilerGenerated]
	private sealed class Class85
	{
		public string string_0;

		public fQuanLyTinNhan D43DEC05;

		internal void A814F120()
		{
			D43DEC05.tabMain.TabPages.Remove(D43DEC05.tabMain.TabPages[string_0]);
		}
	}

	[CompilerGenerated]
	private sealed class D390AA03
	{
		public int int_0;

		public List<int> list_0;

		public fQuanLyTinNhan a8A63D33_0;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < list_0.Count && a8A63D33_0.list_1.Count < int_0)
				{
					B30C5B3A CS_0024_003C_003E8__locals0 = new B30C5B3A
					{
						d390AA03_0 = this,
						int_0 = list_0[num++]
					};
					if (CS_0024_003C_003E8__locals0.int_0 != 0)
					{
						Thread.Sleep(Base.rd.Next(SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayOpenChromeFrom"), SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayOpenChromeTo") + 1) * 1000);
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							CS_0024_003C_003E8__locals0.d390AA03_0.a8A63D33_0.method_6(CS_0024_003C_003E8__locals0.int_0);
						}
						catch (Exception exception_2)
						{
							Common.ExportError(null, exception_2);
						}
					})
					{
						Name = CS_0024_003C_003E8__locals0.int_0.ToString()
					};
					a8A63D33_0.list_1.Add(thread);
					Common.Sleep(1.0);
					thread.Start();
				}
				for (int i = 0; i < a8A63D33_0.list_1.Count; i++)
				{
					a8A63D33_0.list_1[i].Join();
				}
			}
			catch (Exception exception_)
			{
				Common.ExportError(null, exception_);
			}
		}
	}

	[CompilerGenerated]
	private sealed class B30C5B3A
	{
		public int int_0;

		public D390AA03 d390AA03_0;

		internal void method_0()
		{
			try
			{
				d390AA03_0.a8A63D33_0.method_6(int_0);
			}
			catch (Exception exception_)
			{
				Common.ExportError(null, exception_);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class86
	{
		public fQuanLyTinNhan a8A63D33_0;

		public TabPage tabPage_0;

		internal void F8ACB6AE()
		{
			a8A63D33_0.tabMain.ItemSize = new Size(0, 1);
			a8A63D33_0.tabMain.TabPages.Add(tabPage_0);
		}
	}

	[CompilerGenerated]
	private sealed class EB3A3D20
	{
		public string string_0;

		public fQuanLyTinNhan A5036A98;

		public MethodInvoker methodInvoker_0;

		internal void method_0()
		{
			A5036A98.tabMain.TabPages.Remove(A5036A98.tabMain.TabPages[string_0]);
		}
	}

	private List<string> list_0 = new List<string>();

	private List<Thread> list_1 = null;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl B0912E02;

	private ToolTip toolTip_0;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private Button button2;

	private Button button1;

	private Button btnMinimize;

	private BunifuCustomLabel D23AE039;

	private BunifuCards BE2D2E2D;

	private Panel F43A7BAD;

	private TabControl tabMain;

	public DataGridView dgvTaiKhoan;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem BA1B7983;

	private ToolStripMenuItem AB313A0D;

	private Panel A422603B;

	private ToolStripMenuItem toolStripMenuItem_0;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewImageColumn ED2C408D;

	private DataGridViewTextBoxColumn AF04DA84;

	private DataGridViewTextBoxColumn cUid;

	private DataGridViewTextBoxColumn cPassword;

	private DataGridViewTextBoxColumn cFa2;

	private DataGridViewTextBoxColumn cCookies;

	private DataGridViewTextBoxColumn cProxy;

	private DataGridViewTextBoxColumn cGhiChu;

	private DataGridViewTextBoxColumn cId;

	[DllImport("user32.dll", SetLastError = true)]
	public static extern long SetParent(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr F2879535, int int_0, int int_1, int A70C67A5, int int_2, bool bool_0);

	public fQuanLyTinNhan(List<string> AF990EB5)
	{
		InitializeComponent();
		Common.CreateFolder("avatar");
		list_0 = AF990EB5;
		base.Width = Screen.PrimaryScreen.WorkingArea.Width;
		base.Height = Screen.PrimaryScreen.WorkingArea.Height;
		Language.SetLanguage(this);
	}

	public int F1B81226()
	{
		int result = 0;
		try
		{
			result = dgvTaiKhoan.SelectedRows.Count;
		}
		catch
		{
		}
		return result;
	}

	public void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (base.WindowState == FormWindowState.Maximized)
		{
			base.WindowState = FormWindowState.Normal;
			return;
		}
		Rectangle workingArea = Screen.FromHandle(base.Handle).WorkingArea;
		workingArea.Location = new Point(0, 0);
		base.MaximizedBounds = workingArea;
		base.WindowState = FormWindowState.Maximized;
	}

	public void method_0(int D0359D22, string string_0, object object_0, bool bool_0 = true)
	{
		if (bool_0 || !(object_0.ToString().Trim() == ""))
		{
			DatagridviewHelper.SetStatusDataGridView(dgvTaiKhoan, D0359D22, string_0, object_0);
		}
	}

	public string B92D3D0E(int EEACE50B, string string_0)
	{
		return DatagridviewHelper.GetStatusDataGridView(dgvTaiKhoan, EEACE50B, string_0);
	}

	private void FF27B11A(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void method_1()
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			string[] array = list_0[i].Split('|');
			dgvTaiKhoan.Rows.Add(dgvTaiKhoan.RowCount + 1, Image.FromFile("images\\no_avatar.png"), array[0] + "\r\n" + array[5], array[0], array[1], array[2], array[3], array[4], array[6], array[7]);
		}
	}

	private void F59EEC2E(object sender, EventArgs e)
	{
		method_1();
	}

	private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void method_2(Chrome f336F52E_0, Control control_0)
	{
		Invoke((MethodInvoker)delegate
		{
			SetParent(f336F52E_0.Process_0.MainWindowHandle, control_0.Handle);
			MoveWindow(f336F52E_0.Process_0.MainWindowHandle, -10, 0, control_0.Size.Width + 20, control_0.Size.Height + 20, bool_0: false);
		});
	}

	public int method_3(int int_0, string string_0, string string_1, string C629ED9A, TabPage tabPage_0, string string_2 = "", string FFAC9A8A = "")
	{
		int result = 0;
		int num = 0;
		try
		{
			string text = string_0;
			if (string_0 == "")
			{
				string_0 = Regex.Match(string_2, "c_user=(\\d+)").Groups[1].Value;
			}
			Chrome f336F52E = null;
			bool flag = false;
			string text2 = "";
			if (string_0 != "")
			{
				text2 = SettingsTool.GetPathProfile() + "\\" + string_0;
				if (!Directory.Exists(text2))
				{
					text2 = "";
				}
			}
			f336F52E = new Chrome
			{
				DisableImage = false,
				Size = new Point(300, 500),
				Position = new Point(0, -1000),
				ProfilePath = text2
			};
			if (FFAC9A8A != "")
			{
				int int32_ = 0;
				if (FFAC9A8A.EndsWith("*1"))
				{
					int32_ = 1;
				}
				if (FFAC9A8A.EndsWith("*0") || FFAC9A8A.EndsWith("*1"))
				{
					FFAC9A8A = FFAC9A8A.Substring(0, FFAC9A8A.Length - 2);
				}
				f336F52E.Proxy = FFAC9A8A;
				f336F52E.TypeProxy = int32_;
			}
			while (true)
			{
				(bool success, string error) tuple = f336F52E.Open();
				var (flag2, _) = tuple;
				_ = tuple.error;
				if (!flag2)
				{
					break;
				}
				if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKhongCheckIP") && FFAC9A8A.Split(':').Length > 1)
				{
					f336F52E.GotoURL("https://api.myip.com/");
					f336F52E.DelayTime(1.0);
					string text3 = f336F52E.GetPageSource();
					if (!text3.Contains("ip"))
					{
						f336F52E.CloseChrome();
						num++;
						if (num >= 3)
						{
							break;
						}
						continue;
					}
				}
				method_2(f336F52E, tabPage_0);
				if (!(flag = CommonChrome.CheckLiveCookie(f336F52E, "https://m.facebook.com/") == 1))
				{
					if (text != "" && string_1 != "")
					{
						flag = CommonChrome.LoginFacebookUsingUidPassNew(f336F52E, text, string_1, C629ED9A, "https://m.facebook.com/") == "1";
					}
					else if (string_2 != "")
					{
						flag = CommonChrome.smethod_12(f336F52E, string_2, "https://m.facebook.com/") == "1";
					}
				}
				if (!flag)
				{
					method_4(int_0, 1);
					string string_3 = dgvTaiKhoan.Rows[int_0].Cells[3].Value.ToString();
					tabMain.Invoke((MethodInvoker)delegate
					{
						tabMain.TabPages.Remove(tabMain.TabPages[string_3]);
					});
					break;
				}
				method_4(int_0, 2);
				f336F52E.GotoURL("https://www.facebook.com/messages/t");
				string text4 = CheckInfoAccountv2.DownLoadImageByUid(string_0, "avatar");
				if (File.Exists(text4))
				{
					dgvTaiKhoan.Rows[int_0].Cells[1].Value = Image.FromFile(text4);
				}
				break;
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	private void method_4(int int_0, int int_1)
	{
		switch (int_1)
		{
		case 1:
			dgvTaiKhoan.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
			break;
		case 2:
			dgvTaiKhoan.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
			break;
		case 3:
			dgvTaiKhoan.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
			break;
		}
	}

	private void method_5(string string_0, string string_1)
	{
		try
		{
			using WebClient webClient = new WebClient();
			byte[] buffer = webClient.DownloadData(string_0);
			using MemoryStream stream = new MemoryStream(buffer);
			using Image image = Image.FromStream(stream);
			try
			{
				image.Save(string_1 + ".png", ImageFormat.Png);
			}
			catch
			{
				image.Save(string_1 + ".jpg", ImageFormat.Jpeg);
			}
		}
		catch
		{
		}
	}

	private void EF883783(object sender, EventArgs e)
	{
		try
		{
			list_1 = new List<Thread>();
			List<int> list_0 = new List<int>();
			foreach (DataGridViewRow selectedRow in dgvTaiKhoan.SelectedRows)
			{
				list_0.Add(selectedRow.Index);
			}
			int int_0 = list_0.Count;
			new Thread((ThreadStart)delegate
			{
				try
				{
					int num = 0;
					while (num < list_0.Count && list_1.Count < int_0)
					{
						int int_ = list_0[num++];
						if (int_ != 0)
						{
							Thread.Sleep(Base.rd.Next(SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayOpenChromeFrom"), SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayOpenChromeTo") + 1) * 1000);
						}
						Thread thread = new Thread((ThreadStart)delegate
						{
							try
							{
								method_6(int_);
							}
							catch (Exception exception_3)
							{
								Common.ExportError(null, exception_3);
							}
						})
						{
							Name = int_.ToString()
						};
						list_1.Add(thread);
						Common.Sleep(1.0);
						thread.Start();
					}
					for (int i = 0; i < list_1.Count; i++)
					{
						list_1[i].Join();
					}
				}
				catch (Exception exception_2)
				{
					Common.ExportError(null, exception_2);
				}
			}).Start();
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
		}
	}

	private void method_6(int int_0)
	{
		int num = 0;
		string string_ = dgvTaiKhoan.Rows[int_0].Cells[6].Value.ToString();
		string text = dgvTaiKhoan.Rows[int_0].Cells[3].Value.ToString();
		string string_2 = dgvTaiKhoan.Rows[int_0].Cells[4].Value.ToString();
		string c629ED9A = dgvTaiKhoan.Rows[int_0].Cells[5].Value.ToString();
		string fFAC9A8A = dgvTaiKhoan.Rows[int_0].Cells[7].Value.ToString();
		TabPage tabPage_0 = new TabPage();
		tabPage_0.Name = text;
		tabPage_0.Text = text;
		tabPage_0.BackColor = Color.White;
		tabPage_0.ForeColor = Color.White;
		for (int i = 0; i < tabMain.TabPages.Count; i++)
		{
			if (tabMain.TabPages[i].Name.ToString() == tabPage_0.Name)
			{
				num++;
				break;
			}
		}
		if (num == 0)
		{
			tabMain.Invoke((MethodInvoker)delegate
			{
				tabMain.ItemSize = new Size(0, 1);
				tabMain.TabPages.Add(tabPage_0);
			});
			method_3(int_0, text, string_2, c629ED9A, tabPage_0, string_, fFAC9A8A);
		}
	}

	private void AB313A0D_Click(object sender, EventArgs e)
	{
		try
		{
			string string_0 = "";
			for (int i = 0; i < dgvTaiKhoan.SelectedRows.Count; i++)
			{
				string_0 = dgvTaiKhoan.SelectedRows[i].Cells[3].Value.ToString();
				if (tabMain.TabPages.Contains(tabMain.TabPages[string_0]))
				{
					tabMain.Invoke((MethodInvoker)delegate
					{
						tabMain.TabPages.Remove(tabMain.TabPages[string_0]);
					});
					method_4(dgvTaiKhoan.SelectedRows[i].Index, 3);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		string text = dgvTaiKhoan.SelectedRows[0].Cells[3].Value.ToString();
		int num = 0;
		while (true)
		{
			if (num < tabMain.TabPages.Count)
			{
				if (tabMain.TabPages[num].Name.ToString() == text)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		tabMain.SelectedTab = tabMain.TabPages[text];
	}

	private void F43A7BAD_Paint(object sender, PaintEventArgs e)
	{
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		method_7("Notes");
	}

	private void method_7(string D79DC31B)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dgvTaiKhoan.SelectedRows.Count; i++)
			{
				list.Add(B92D3D0E(dgvTaiKhoan.SelectedRows[i].Index, "cId"));
			}
			if (list.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng cho\u0323n ta\u0300i khoa\u0309n câ\u0300n câ\u0323p nhâ\u0323t!", 3);
			}
			else
			{
				Common.ShowForm(new fUpdateData2(this, D79DC31B));
			}
		}
		catch
		{
		}
	}

	protected override void Dispose(bool EA0253AA)
	{
		if (EA0253AA && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(EA0253AA);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.D23AE039 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.B0912E02 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.BE2D2E2D = new Bunifu.Framework.UI.BunifuCards();
		this.F43A7BAD = new System.Windows.Forms.Panel();
		this.A422603B = new System.Windows.Forms.Panel();
		this.tabMain = new System.Windows.Forms.TabControl();
		this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
		this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ED2C408D = new System.Windows.Forms.DataGridViewImageColumn();
		this.AF04DA84 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cFa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cCookies = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.BA1B7983 = new System.Windows.Forms.ToolStripMenuItem();
		this.AB313A0D = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.BE2D2E2D.SuspendLayout();
		this.F43A7BAD.SuspendLayout();
		this.A422603B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvTaiKhoan).BeginInit();
		this.contextMenuStrip1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.button2);
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.D23AE039);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1080, 29);
		this.pnlHeader.TabIndex = 0;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(6, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 12;
		this.pictureBox1.TabStop = false;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.Dock = System.Windows.Forms.DockStyle.Right;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Resources.Bitmap_12;
		this.button2.Location = new System.Drawing.Point(984, 0);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(32, 29);
		this.button2.TabIndex = 0;
		this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(FF27B11A);
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Dock = System.Windows.Forms.DockStyle.Right;
		this.button1.Enabled = false;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = Resources.Bitmap_11;
		this.button1.Location = new System.Drawing.Point(1016, 0);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(32, 29);
		this.button1.TabIndex = 1;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = Resources.C400940B;
		this.btnMinimize.Location = new System.Drawing.Point(1048, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 29);
		this.btnMinimize.TabIndex = 2;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.D23AE039.AutoSize = true;
		this.D23AE039.BackColor = System.Drawing.Color.Transparent;
		this.D23AE039.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.D23AE039.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D23AE039.ForeColor = System.Drawing.Color.Black;
		this.D23AE039.Location = new System.Drawing.Point(43, 6);
		this.D23AE039.Name = "bunifuCustomLabel1";
		this.D23AE039.Size = new System.Drawing.Size(177, 16);
		this.D23AE039.TabIndex = 3;
		this.D23AE039.Text = "Quản lý tin nhắn hàng loạt";
		this.B0912E02.Fixed = true;
		this.B0912E02.Horizontal = true;
		this.B0912E02.TargetControl = this.D23AE039;
		this.B0912E02.Vertical = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 30000;
		this.toolTip_0.InitialDelay = 0;
		this.toolTip_0.ReshowDelay = 40;
		this.BE2D2E2D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.BE2D2E2D.BackColor = System.Drawing.Color.White;
		this.BE2D2E2D.BorderRadius = 0;
		this.BE2D2E2D.BottomSahddow = true;
		this.BE2D2E2D.color = System.Drawing.Color.RoyalBlue;
		this.BE2D2E2D.Controls.Add(this.pnlHeader);
		this.BE2D2E2D.LeftSahddow = false;
		this.BE2D2E2D.Location = new System.Drawing.Point(0, -1);
		this.BE2D2E2D.Name = "bunifuCards1";
		this.BE2D2E2D.RightSahddow = true;
		this.BE2D2E2D.ShadowDepth = 20;
		this.BE2D2E2D.Size = new System.Drawing.Size(1081, 38);
		this.BE2D2E2D.TabIndex = 0;
		this.F43A7BAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.F43A7BAD.Controls.Add(this.A422603B);
		this.F43A7BAD.Controls.Add(this.dgvTaiKhoan);
		this.F43A7BAD.Controls.Add(this.BE2D2E2D);
		this.F43A7BAD.Dock = System.Windows.Forms.DockStyle.Fill;
		this.F43A7BAD.Location = new System.Drawing.Point(0, 0);
		this.F43A7BAD.Name = "panel1";
		this.F43A7BAD.Size = new System.Drawing.Size(1082, 565);
		this.F43A7BAD.TabIndex = 8;
		this.F43A7BAD.Paint += new System.Windows.Forms.PaintEventHandler(F43A7BAD_Paint);
		this.A422603B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.A422603B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.A422603B.Controls.Add(this.tabMain);
		this.A422603B.Location = new System.Drawing.Point(7, 39);
		this.A422603B.Name = "panel2";
		this.A422603B.Size = new System.Drawing.Size(693, 519);
		this.A422603B.TabIndex = 8;
		this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
		this.tabMain.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.tabMain.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.tabMain.Location = new System.Drawing.Point(0, 0);
		this.tabMain.Multiline = true;
		this.tabMain.Name = "tabMain";
		this.tabMain.SelectedIndex = 0;
		this.tabMain.Size = new System.Drawing.Size(693, 518);
		this.tabMain.TabIndex = 7;
		this.dgvTaiKhoan.AllowUserToAddRows = false;
		this.dgvTaiKhoan.AllowUserToDeleteRows = false;
		this.dgvTaiKhoan.AllowUserToResizeColumns = false;
		this.dgvTaiKhoan.AllowUserToResizeRows = false;
		this.dgvTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvTaiKhoan.Columns.AddRange(this.cStt, this.ED2C408D, this.AF04DA84, this.cUid, this.cPassword, this.cFa2, this.cCookies, this.cProxy, this.cGhiChu, this.cId);
		this.dgvTaiKhoan.ContextMenuStrip = this.contextMenuStrip1;
		this.dgvTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle2;
		this.dgvTaiKhoan.Location = new System.Drawing.Point(706, 39);
		this.dgvTaiKhoan.Name = "dgvTaiKhoan";
		this.dgvTaiKhoan.ReadOnly = true;
		this.dgvTaiKhoan.RowHeadersVisible = false;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.dgvTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle3;
		this.dgvTaiKhoan.RowTemplate.Height = 50;
		this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvTaiKhoan.Size = new System.Drawing.Size(369, 519);
		this.dgvTaiKhoan.TabIndex = 6;
		this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvTaiKhoan_CellClick);
		this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvTaiKhoan_CellContentClick);
		this.cStt.HeaderText = "STT";
		this.cStt.Name = "cStt";
		this.cStt.ReadOnly = true;
		this.cStt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.cStt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cStt.Width = 40;
		this.ED2C408D.FillWeight = 50f;
		this.ED2C408D.HeaderText = "Avatar";
		this.ED2C408D.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
		this.ED2C408D.Name = "cAvatar";
		this.ED2C408D.ReadOnly = true;
		this.ED2C408D.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.ED2C408D.Width = 70;
		this.AF04DA84.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.AF04DA84.DefaultCellStyle = dataGridViewCellStyle4;
		this.AF04DA84.HeaderText = "Tài khoản";
		this.AF04DA84.Name = "cTaiKhoan";
		this.AF04DA84.ReadOnly = true;
		this.AF04DA84.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.AF04DA84.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cUid.HeaderText = "Uid";
		this.cUid.Name = "cUid";
		this.cUid.ReadOnly = true;
		this.cUid.Visible = false;
		this.cPassword.HeaderText = "Password";
		this.cPassword.Name = "cPassword";
		this.cPassword.ReadOnly = true;
		this.cPassword.Visible = false;
		this.cFa2.HeaderText = "2fa";
		this.cFa2.Name = "cFa2";
		this.cFa2.ReadOnly = true;
		this.cFa2.Visible = false;
		this.cCookies.HeaderText = "Cookie";
		this.cCookies.Name = "cCookies";
		this.cCookies.ReadOnly = true;
		this.cCookies.Visible = false;
		this.cProxy.HeaderText = "Proxy";
		this.cProxy.Name = "cProxy";
		this.cProxy.ReadOnly = true;
		this.cProxy.Visible = false;
		this.cGhiChu.HeaderText = "Ghi chú";
		this.cGhiChu.Name = "cGhiChu";
		this.cGhiChu.ReadOnly = true;
		this.cId.HeaderText = "Id";
		this.cId.Name = "cId";
		this.cId.ReadOnly = true;
		this.cId.Visible = false;
		this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.BA1B7983, this.AB313A0D, this.toolStripMenuItem_0 });
		this.contextMenuStrip1.Name = "contextMenuStrip1";
		this.contextMenuStrip1.Size = new System.Drawing.Size(165, 70);
		this.BA1B7983.Image = Resources.AC9006A1;
		this.BA1B7983.Name = "hiểnThịToolStripMenuItem";
		this.BA1B7983.Size = new System.Drawing.Size(164, 22);
		this.BA1B7983.Text = "Mở trình duyệt";
		this.BA1B7983.Click += new System.EventHandler(EF883783);
		this.AB313A0D.Image = Resources.Bitmap_137;
		this.AB313A0D.Name = "đóngToolStripMenuItem";
		this.AB313A0D.Size = new System.Drawing.Size(164, 22);
		this.AB313A0D.Text = "Đóng trình duyệt";
		this.AB313A0D.Click += new System.EventHandler(AB313A0D_Click);
		this.toolStripMenuItem_0.Image = Resources.Bitmap_70;
		this.toolStripMenuItem_0.Name = "sửaGhiChúToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(164, 22);
		this.toolStripMenuItem_0.Text = "Sửa ghi chú";
		this.toolStripMenuItem_0.Click += new System.EventHandler(toolStripMenuItem_0_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1082, 565);
		base.Controls.Add(this.F43A7BAD);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fQuanLyTinNhan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Quản lý tin nhắn";
		base.Load += new System.EventHandler(F59EEC2E);
		this.pnlHeader.ResumeLayout(false);
		this.pnlHeader.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.BE2D2E2D.ResumeLayout(false);
		this.F43A7BAD.ResumeLayout(false);
		this.A422603B.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvTaiKhoan).EndInit();
		this.contextMenuStrip1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
