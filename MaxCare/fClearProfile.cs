using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fClearProfile : Form
{
	[CompilerGenerated]
	private sealed class Class108
	{
		public int int_0;

		public int int_1;

		public fClearProfile fClearProfile_0;

		public int A30FD78A;

		public Action action_0;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < fClearProfile_0.AF0D6036.Count)
				{
					if (int_0 < int_1)
					{
						C5368B96 CS_0024_003C_003E8__locals0 = new C5368B96
						{
							A4951312 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.EFB6513D = num++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								string path = SettingsTool.GetPathProfile() + "\\" + CS_0024_003C_003E8__locals0.A4951312.fClearProfile_0.AF0D6036[CS_0024_003C_003E8__locals0.EFB6513D];
								Directory.Delete(path, recursive: true);
								Interlocked.Increment(ref CS_0024_003C_003E8__locals0.A4951312.A30FD78A);
								CS_0024_003C_003E8__locals0.A4951312.fClearProfile_0.E42197AB(string.Format(Language.GetValue("Đang dọn dẹp profile {0}/{1}..."), CS_0024_003C_003E8__locals0.A4951312.A30FD78A, CS_0024_003C_003E8__locals0.A4951312.fClearProfile_0.AF0D6036.Count));
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.A4951312.int_0);
							}
							catch
							{
							}
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				while (int_0 > 0)
				{
					Common.Sleep(1.0);
				}
				fClearProfile_0.Invoke((Action)delegate
				{
					fClearProfile_0.Close();
					MessageBoxHelper.Show("Đã dọn dẹp profile xong!");
				});
			}
			catch
			{
			}
		}

		internal void BF3BD604()
		{
			fClearProfile_0.Close();
			MessageBoxHelper.Show("Đã dọn dẹp profile xong!");
		}
	}

	[CompilerGenerated]
	private sealed class C5368B96
	{
		public int EFB6513D;

		public Class108 A4951312;

		internal void method_0()
		{
			try
			{
				string path = SettingsTool.GetPathProfile() + "\\" + A4951312.fClearProfile_0.AF0D6036[EFB6513D];
				Directory.Delete(path, recursive: true);
				Interlocked.Increment(ref A4951312.A30FD78A);
				A4951312.fClearProfile_0.E42197AB(string.Format(Language.GetValue("Đang dọn dẹp profile {0}/{1}..."), A4951312.A30FD78A, A4951312.fClearProfile_0.AF0D6036.Count));
				Interlocked.Decrement(ref A4951312.int_0);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class109
	{
		public fClearProfile fClearProfile_0;

		public string string_0;

		internal void B10875BB()
		{
			fClearProfile_0.A82B1EAD.Text = string_0;
		}
	}

	private List<string> AF0D6036 = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button EF3F8E2D;

	private Button btnCancel;

	private Button F59AA6A0;

	private BunifuDragControl D997DEB2;

	private BunifuCustomLabel A82B1EAD;

	private PictureBox pictureBox1;

	public fClearProfile()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void A739A91A()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(A82B1EAD);
		Language.smethod_0(F59AA6A0);
		Language.smethod_0(btnCancel);
	}

	private void C229E3B5(object sender, EventArgs e)
	{
		Close();
	}

	private void E494C281(object sender, EventArgs e)
	{
		F59AA6A0.Enabled = false;
		btnCancel.Enabled = false;
		int A30FD78A = 0;
		E42197AB(string.Format(Language.GetValue("Đang dọn dẹp profile {0}/{1}..."), A30FD78A, AF0D6036.Count));
		int int_0 = 0;
		int int_1 = 20;
		new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < AF0D6036.Count)
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int EFB6513D = num++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								string path = SettingsTool.GetPathProfile() + "\\" + AF0D6036[EFB6513D];
								Directory.Delete(path, recursive: true);
								Interlocked.Increment(ref A30FD78A);
								E42197AB(string.Format(Language.GetValue("Đang dọn dẹp profile {0}/{1}..."), A30FD78A, AF0D6036.Count));
								Interlocked.Decrement(ref int_0);
							}
							catch
							{
							}
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				while (int_0 > 0)
				{
					Common.Sleep(1.0);
				}
				Invoke((Action)delegate
				{
					Close();
					MessageBoxHelper.Show("Đã dọn dẹp profile xong!");
				});
			}
			catch
			{
			}
		}).Start();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D8213518(object sender, EventArgs e)
	{
	}

	private List<string> method_0()
	{
		List<string> list = new List<string>();
		try
		{
			DataTable dataTable = CommonSQL.smethod_12();
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i]["uid"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	private void E42197AB(string string_0)
	{
		Invoke((Action)delegate
		{
			A82B1EAD.Text = string_0;
		});
	}

	private void A693F1B3(object sender, EventArgs e)
	{
		new Thread((ThreadStart)delegate
		{
			try
			{
				List<string> list = Directory.GetDirectories(SettingsTool.GetPathProfile()).ToList();
				List<string> list2 = method_0();
				string text = "";
				for (int i = 0; i < list.Count; i++)
				{
					text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
					if (!list2.Contains(text))
					{
						AF0D6036.Add(text);
					}
				}
				if (AF0D6036.Count > 0)
				{
					Invoke((Action)delegate
					{
						A82B1EAD.Text = string.Format(Language.GetValue("Tìm thấy {0} profile rác!"), AF0D6036.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
						F59AA6A0.Visible = true;
						btnCancel.Visible = true;
					});
				}
				else
				{
					Invoke((Action)delegate
					{
						Close();
						MessageBoxHelper.Show("Không có profile rác!");
					});
				}
			}
			catch (Exception)
			{
			}
		}).Start();
	}

	protected override void Dispose(bool E29F2905)
	{
		if (E29F2905 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(E29F2905);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fClearProfile));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.EF3F8E2D = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.F59AA6A0 = new System.Windows.Forms.Button();
		this.D997DEB2 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.A82B1EAD = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(396, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.EF3F8E2D);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(396, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.EF3F8E2D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EF3F8E2D.Dock = System.Windows.Forms.DockStyle.Right;
		this.EF3F8E2D.FlatAppearance.BorderSize = 0;
		this.EF3F8E2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.EF3F8E2D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EF3F8E2D.ForeColor = System.Drawing.Color.White;
		this.EF3F8E2D.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.EF3F8E2D.Location = new System.Drawing.Point(364, 0);
		this.EF3F8E2D.Name = "btnMinimize";
		this.EF3F8E2D.Size = new System.Drawing.Size(32, 32);
		this.EF3F8E2D.TabIndex = 9;
		this.EF3F8E2D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.EF3F8E2D.UseVisualStyleBackColor = true;
		this.EF3F8E2D.Click += new System.EventHandler(C229E3B5);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(396, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Dọn dẹp profile";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(204, 105);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Hủy";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Visible = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.F59AA6A0.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.F59AA6A0.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F59AA6A0.FlatAppearance.BorderSize = 0;
		this.F59AA6A0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F59AA6A0.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F59AA6A0.ForeColor = System.Drawing.Color.White;
		this.F59AA6A0.Location = new System.Drawing.Point(100, 105);
		this.F59AA6A0.Name = "btnAdd";
		this.F59AA6A0.Size = new System.Drawing.Size(92, 29);
		this.F59AA6A0.TabIndex = 3;
		this.F59AA6A0.Text = "Đồng ý";
		this.F59AA6A0.UseVisualStyleBackColor = false;
		this.F59AA6A0.Visible = false;
		this.F59AA6A0.Click += new System.EventHandler(E494C281);
		this.D997DEB2.Fixed = true;
		this.D997DEB2.Horizontal = true;
		this.D997DEB2.TargetControl = this.bunifuCustomLabel1;
		this.D997DEB2.Vertical = true;
		this.A82B1EAD.BackColor = System.Drawing.Color.Transparent;
		this.A82B1EAD.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.A82B1EAD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A82B1EAD.ForeColor = System.Drawing.Color.Black;
		this.A82B1EAD.Location = new System.Drawing.Point(-1, 57);
		this.A82B1EAD.Name = "lblStatus";
		this.A82B1EAD.Size = new System.Drawing.Size(396, 32);
		this.A82B1EAD.TabIndex = 21;
		this.A82B1EAD.Text = "Đang quét profile...";
		this.A82B1EAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.A82B1EAD.Click += new System.EventHandler(D8213518);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(396, 145);
		base.Controls.Add(this.A82B1EAD);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.F59AA6A0);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fClearProfile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(A693F1B3);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_1()
	{
		try
		{
			List<string> list = Directory.GetDirectories(SettingsTool.GetPathProfile()).ToList();
			List<string> list2 = method_0();
			string text = "";
			for (int i = 0; i < list.Count; i++)
			{
				text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
				if (!list2.Contains(text))
				{
					AF0D6036.Add(text);
				}
			}
			if (AF0D6036.Count > 0)
			{
				Invoke((Action)delegate
				{
					A82B1EAD.Text = string.Format(Language.GetValue("Tìm thấy {0} profile rác!"), AF0D6036.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
					F59AA6A0.Visible = true;
					btnCancel.Visible = true;
				});
			}
			else
			{
				Invoke((Action)delegate
				{
					Close();
					MessageBoxHelper.Show("Không có profile rác!");
				});
			}
		}
		catch (Exception)
		{
		}
	}

	[CompilerGenerated]
	private void method_2()
	{
		A82B1EAD.Text = string.Format(Language.GetValue("Tìm thấy {0} profile rác!"), AF0D6036.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
		F59AA6A0.Visible = true;
		btnCancel.Visible = true;
	}

	[CompilerGenerated]
	private void method_3()
	{
		Close();
		MessageBoxHelper.Show("Không có profile rác!");
	}
}
