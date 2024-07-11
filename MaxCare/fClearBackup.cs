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

public class fClearBackup : Form
{
	[CompilerGenerated]
	private sealed class AB1201A8
	{
		public int D0B6D607;

		public int int_0;

		public string string_0;

		public fClearBackup BB07782B;

		public int int_1;

		public Action CE0E1E85;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < BB07782B.F09BE40A.Count)
				{
					if (D0B6D607 < int_0)
					{
						Class76 CS_0024_003C_003E8__locals0 = new Class76
						{
							ab1201A8_0 = this
						};
						Interlocked.Increment(ref D0B6D607);
						CS_0024_003C_003E8__locals0.E5B8B2BA = num++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								string path = CS_0024_003C_003E8__locals0.ab1201A8_0.string_0 + "\\" + CS_0024_003C_003E8__locals0.ab1201A8_0.BB07782B.F09BE40A[CS_0024_003C_003E8__locals0.E5B8B2BA];
								Directory.Delete(path, recursive: true);
								Interlocked.Increment(ref CS_0024_003C_003E8__locals0.ab1201A8_0.int_1);
								CS_0024_003C_003E8__locals0.ab1201A8_0.BB07782B.FD008385(string.Format(Language.GetValue("Đang dọn dẹp backup {0}/{1}..."), CS_0024_003C_003E8__locals0.ab1201A8_0.int_1, CS_0024_003C_003E8__locals0.ab1201A8_0.BB07782B.F09BE40A.Count));
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.ab1201A8_0.D0B6D607);
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
				while (D0B6D607 > 0)
				{
					Common.Sleep(1.0);
				}
				BB07782B.Invoke((Action)delegate
				{
					BB07782B.Close();
					MessageBoxHelper.Show("Đã dọn dẹp file backup xong!");
				});
			}
			catch
			{
			}
		}

		internal void method_1()
		{
			BB07782B.Close();
			MessageBoxHelper.Show("Đã dọn dẹp file backup xong!");
		}
	}

	[CompilerGenerated]
	private sealed class Class76
	{
		public int E5B8B2BA;

		public AB1201A8 ab1201A8_0;

		internal void method_0()
		{
			try
			{
				string path = ab1201A8_0.string_0 + "\\" + ab1201A8_0.BB07782B.F09BE40A[E5B8B2BA];
				Directory.Delete(path, recursive: true);
				Interlocked.Increment(ref ab1201A8_0.int_1);
				ab1201A8_0.BB07782B.FD008385(string.Format(Language.GetValue("Đang dọn dẹp backup {0}/{1}..."), ab1201A8_0.int_1, ab1201A8_0.BB07782B.F09BE40A.Count));
				Interlocked.Decrement(ref ab1201A8_0.D0B6D607);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class77
	{
		public fClearBackup fClearBackup_0;

		public string string_0;

		internal void method_0()
		{
			fClearBackup_0.D7A12C86.Text = string_0;
		}
	}

	private List<string> F09BE40A = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button E1189786;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCustomLabel D7A12C86;

	private PictureBox pictureBox1;

	public fClearBackup()
	{
		F81B5204();
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(D7A12C86);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void E1189786_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DB370806(object sender, EventArgs e)
	{
		btnAdd.Enabled = false;
		btnCancel.Enabled = false;
		FD008385(string.Format(Language.GetValue("Đang dọn dẹp backup {0}/{1}..."), 0, F09BE40A.Count));
		int D0B6D607 = 0;
		int int_0 = 20;
		int int_1 = 0;
		string string_0 = FileHelper.GetPathToCurrentFolder() + "\\backup";
		new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < F09BE40A.Count)
				{
					if (D0B6D607 < int_0)
					{
						Interlocked.Increment(ref D0B6D607);
						int E5B8B2BA = num++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								string path = string_0 + "\\" + F09BE40A[E5B8B2BA];
								Directory.Delete(path, recursive: true);
								Interlocked.Increment(ref int_1);
								FD008385(string.Format(Language.GetValue("Đang dọn dẹp backup {0}/{1}..."), int_1, F09BE40A.Count));
								Interlocked.Decrement(ref D0B6D607);
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
				while (D0B6D607 > 0)
				{
					Common.Sleep(1.0);
				}
				Invoke((Action)delegate
				{
					Close();
					MessageBoxHelper.Show("Đã dọn dẹp file backup xong!");
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

	private void D7A12C86_Click(object sender, EventArgs e)
	{
	}

	private List<string> method_1()
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

	private void FD008385(string D31BD895)
	{
		Invoke((Action)delegate
		{
			D7A12C86.Text = D31BD895;
		});
	}

	private void fClearBackup_Load(object sender, EventArgs e)
	{
		new Thread((ThreadStart)delegate
		{
			try
			{
				List<string> list = Directory.GetDirectories(FileHelper.GetPathToCurrentFolder() + "\\backup").ToList();
				List<string> list2 = method_1();
				string text = "";
				for (int i = 0; i < list.Count; i++)
				{
					text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
					if (!list2.Contains(text))
					{
						F09BE40A.Add(text);
					}
				}
				if (F09BE40A.Count > 0)
				{
					Invoke((Action)delegate
					{
						D7A12C86.Text = string.Format(Language.GetValue("Tìm thấy {0} file backup rác!"), F09BE40A.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
						btnAdd.Visible = true;
						btnCancel.Visible = true;
					});
				}
				else
				{
					Invoke((Action)delegate
					{
						Close();
						MessageBoxHelper.Show("Không có file backup rác!");
					});
				}
			}
			catch
			{
			}
		}).Start();
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void F81B5204()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fClearBackup));
		bunifuCards1 = new BunifuCards();
		pnlHeader = new Panel();
		pictureBox1 = new PictureBox();
		E1189786 = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		D7A12C86 = new BunifuCustomLabel();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(396, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(E1189786);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(396, 32);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		E1189786.Cursor = Cursors.Hand;
		E1189786.Dock = DockStyle.Right;
		E1189786.FlatAppearance.BorderSize = 0;
		E1189786.FlatStyle = FlatStyle.Flat;
		E1189786.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		E1189786.ForeColor = Color.White;
		E1189786.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		E1189786.Location = new Point(364, 0);
		E1189786.Name = "btnMinimize";
		E1189786.Size = new Size(32, 32);
		E1189786.TabIndex = 9;
		E1189786.TextImageRelation = TextImageRelation.ImageBeforeText;
		E1189786.UseVisualStyleBackColor = true;
		E1189786.Click += E1189786_Click;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(396, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Dọn dẹp backup";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(204, 105);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Hủy";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Visible = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(100, 105);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Đồng ý";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Visible = false;
		btnAdd.Click += DB370806;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		D7A12C86.BackColor = Color.Transparent;
		D7A12C86.Cursor = Cursors.SizeAll;
		D7A12C86.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D7A12C86.ForeColor = Color.Black;
		D7A12C86.Location = new Point(-1, 57);
		D7A12C86.Name = "lblStatus";
		D7A12C86.Size = new Size(396, 32);
		D7A12C86.TabIndex = 21;
		D7A12C86.Text = "Đang quét file backup...";
		D7A12C86.TextAlign = ContentAlignment.MiddleCenter;
		D7A12C86.Click += D7A12C86_Click;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(396, 145);
		base.Controls.Add(D7A12C86);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fClearBackup";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += fClearBackup_Load;
		bunifuCards1.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void E0919D0C()
	{
		try
		{
			List<string> list = Directory.GetDirectories(FileHelper.GetPathToCurrentFolder() + "\\backup").ToList();
			List<string> list2 = method_1();
			string text = "";
			for (int i = 0; i < list.Count; i++)
			{
				text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
				if (!list2.Contains(text))
				{
					F09BE40A.Add(text);
				}
			}
			if (F09BE40A.Count > 0)
			{
				Invoke((Action)delegate
				{
					D7A12C86.Text = string.Format(Language.GetValue("Tìm thấy {0} file backup rác!"), F09BE40A.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
					btnAdd.Visible = true;
					btnCancel.Visible = true;
				});
			}
			else
			{
				Invoke((Action)delegate
				{
					Close();
					MessageBoxHelper.Show("Không có file backup rác!");
				});
			}
		}
		catch
		{
		}
	}

	[CompilerGenerated]
	private void AF9D9511()
	{
		D7A12C86.Text = string.Format(Language.GetValue("Tìm thấy {0} file backup rác!"), F09BE40A.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
		btnAdd.Visible = true;
		btnCancel.Visible = true;
	}

	[CompilerGenerated]
	private void D19991B0()
	{
		Close();
		MessageBoxHelper.Show("Không có file backup rác!");
	}
}
