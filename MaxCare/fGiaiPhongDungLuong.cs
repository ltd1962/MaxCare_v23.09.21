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

public class fGiaiPhongDungLuong : Form
{
	[CompilerGenerated]
	private sealed class Class78
	{
		public Label E73B7128;

		public string string_0;

		internal void method_0()
		{
			E73B7128.Text = string_0;
		}
	}

	[CompilerGenerated]
	private sealed class E1A5C804
	{
		public Label label_0;

		internal void method_0()
		{
			label_0.Visible = true;
		}
	}

	[CompilerGenerated]
	private sealed class B0AFBB25
	{
		public bool bool_0;

		public Label label_0;

		internal void CD0463AB()
		{
			if (bool_0)
			{
				label_0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			}
			else
			{
				label_0.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class79
	{
		public List<string> E03F62BB;

		public fGiaiPhongDungLuong BB1D440B;
	}

	[CompilerGenerated]
	private sealed class Class80
	{
		public int int_0;

		public int int_1;

		public Class79 B2851C3D;
	}

	[CompilerGenerated]
	private sealed class Class81
	{
		public int D5A00EA6;

		public Class80 class80_0;

		internal void method_0()
		{
			try
			{
				string string_ = SettingsTool.GetPathProfile() + "\\" + class80_0.B2851C3D.E03F62BB[D5A00EA6];
				Common.DeleteFile(string_);
				Interlocked.Increment(ref class80_0.int_0);
				class80_0.B2851C3D.BB1D440B.BC36568F(class80_0.B2851C3D.BB1D440B.lblStatusDonDepProfileRac, Language.GetValue("Đang chạy") + $" {class80_0.int_0}/{class80_0.B2851C3D.E03F62BB.Count}...");
				Interlocked.Decrement(ref class80_0.int_1);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class82
	{
		public int A01401A6;

		public List<string> list_0;

		public int int_0;

		public fGiaiPhongDungLuong fGiaiPhongDungLuong_0;
	}

	[CompilerGenerated]
	private sealed class E10AF102
	{
		public string AC208722;

		public Class82 BF0EE436;

		internal void method_0()
		{
			try
			{
				string text = SettingsTool.GetPathProfile() + "\\" + AC208722;
				if (Directory.Exists(text))
				{
					Common.DeleteFile(text + "\\Default\\Cache");
					Common.DeleteFile(text + "\\Default\\Code Cache");
					Common.DeleteFile(text + "\\OptimizationGuidePredictionModels");
					Common.DeleteFile(text + "\\Default\\optimization_guide_prediction_model_downloads");
					Common.DeleteFile(text + "\\SwReporter");
					Common.DeleteFile(text + "\\pnacl");
				}
				Interlocked.Increment(ref BF0EE436.A01401A6);
				BF0EE436.fGiaiPhongDungLuong_0.BC36568F(BF0EE436.fGiaiPhongDungLuong_0.lblStatusXoaCacheProfile, Language.GetValue("Đang chạy") + $" {BF0EE436.A01401A6}/{BF0EE436.list_0.Count}...");
				Interlocked.Decrement(ref BF0EE436.int_0);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class83
	{
		public List<string> D88C3B8C;

		public int D52F2305;

		public int CB2B21B8;

		public fGiaiPhongDungLuong fGiaiPhongDungLuong_0;
	}

	[CompilerGenerated]
	private sealed class Class84
	{
		public int int_0;

		public Class83 class83_0;

		internal void method_0()
		{
			try
			{
				Common.DeleteFile(class83_0.D88C3B8C[int_0]);
				Interlocked.Increment(ref class83_0.D52F2305);
				class83_0.fGiaiPhongDungLuong_0.BC36568F(class83_0.fGiaiPhongDungLuong_0.DA385A90, Language.GetValue("Đang chạy") + $" {class83_0.D52F2305}/{class83_0.D88C3B8C.Count}...");
				Interlocked.Decrement(ref class83_0.CB2B21B8);
			}
			catch
			{
			}
		}
	}

	private bool D4326619 = false;

	private bool bool_0 = false;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel F7A45F34;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Label lblXoaFileRac;

	private Label lblDonDepProfileRac;

	private Label BDAE82BD;

	private Label lblStatusXoaFileRac;

	private Label lblStatusDonDepProfileRac;

	private Label lblStatusXoaCacheProfile;

	private Label DA385A90;

	private Label CF11C23A;

	public fGiaiPhongDungLuong(bool bool_1 = false)
	{
		InitializeComponent();
		D4326619 = bool_1;
		Language.SetLanguage(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void CDA5F98D(object sender, EventArgs e)
	{
		btnCancel.Invoke((Action)delegate
		{
			btnCancel.Enabled = false;
		});
		bool_0 = true;
	}

	private List<string> CA884292()
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

	private void BC36568F(Label C8A87C2B, string string_0)
	{
		try
		{
			Invoke((Action)delegate
			{
				C8A87C2B.Text = string_0;
			});
		}
		catch
		{
		}
	}

	private void E22F0907(Label label_0)
	{
		try
		{
			Invoke((Action)delegate
			{
				label_0.Visible = true;
			});
		}
		catch
		{
		}
	}

	private void method_0(Label label_0, bool bool_1 = true)
	{
		try
		{
			Invoke((Action)delegate
			{
				if (bool_1)
				{
					label_0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
				}
				else
				{
					label_0.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
				}
			});
		}
		catch
		{
		}
	}

	private void fGiaiPhongDungLuong_Load(object sender, EventArgs e)
	{
		Common.KillProcess("chromedriver");
		new Thread((ThreadStart)delegate
		{
			try
			{
				method_0(lblXoaFileRac);
				BC36568F(lblStatusXoaFileRac, Language.GetValue("Đang chạy") + "...");
				E22F0907(lblStatusXoaFileRac);
				Common.DeleteFile("log");
				Common.DeleteFile("log_capture");
				Common.DeleteFile("Plugins");
				Common.DeleteFile("golike");
				Common.DeleteFilex("logJob.txt");
				if (!bool_0)
				{
					BC36568F(lblStatusXoaFileRac, Language.GetValue("Hoàn thành!"));
					method_0(lblXoaFileRac, bool_1: false);
					method_0(lblDonDepProfileRac);
					BC36568F(lblStatusDonDepProfileRac, "");
					E22F0907(lblStatusDonDepProfileRac);
					int num = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
					List<string> list = Directory.GetDirectories(SettingsTool.GetPathProfile()).ToList();
					List<string> list2 = CA884292();
					List<string> E03F62BB = new List<string>();
					string text = "";
					for (int i = 0; i < list.Count; i++)
					{
						text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
						if (!list2.Contains(text))
						{
							E03F62BB.Add(text);
						}
					}
					try
					{
						int int_3 = 0;
						int int_2 = 0;
						int num2 = 0;
						while (num2 < E03F62BB.Count && !bool_0)
						{
							if (int_3 < num)
							{
								Interlocked.Increment(ref int_3);
								int D5A00EA6 = num2++;
								new Thread((ThreadStart)delegate
								{
									try
									{
										string string_ = SettingsTool.GetPathProfile() + "\\" + E03F62BB[D5A00EA6];
										Common.DeleteFile(string_);
										Interlocked.Increment(ref int_2);
										BC36568F(lblStatusDonDepProfileRac, Language.GetValue("Đang chạy") + $" {int_2}/{E03F62BB.Count}...");
										Interlocked.Decrement(ref int_3);
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
						while (int_3 > 0)
						{
							Common.Sleep(1.0);
						}
					}
					catch
					{
					}
					if (!bool_0)
					{
						BC36568F(lblStatusDonDepProfileRac, Language.GetValue("Hoàn thành!"));
						method_0(lblDonDepProfileRac, bool_1: false);
						method_0(BDAE82BD);
						BC36568F(lblStatusXoaCacheProfile, "");
						E22F0907(lblStatusXoaCacheProfile);
						int int_ = 0;
						int A01401A6 = 0;
						List<string> list_0 = CA884292();
						int num3 = 0;
						while (num3 < list_0.Count && !bool_0)
						{
							if (int_ < num)
							{
								Interlocked.Increment(ref int_);
								string AC208722 = list_0[num3++];
								new Thread((ThreadStart)delegate
								{
									try
									{
										string text2 = SettingsTool.GetPathProfile() + "\\" + AC208722;
										if (Directory.Exists(text2))
										{
											Common.DeleteFile(text2 + "\\Default\\Cache");
											Common.DeleteFile(text2 + "\\Default\\Code Cache");
											Common.DeleteFile(text2 + "\\OptimizationGuidePredictionModels");
											Common.DeleteFile(text2 + "\\Default\\optimization_guide_prediction_model_downloads");
											Common.DeleteFile(text2 + "\\SwReporter");
											Common.DeleteFile(text2 + "\\pnacl");
										}
										Interlocked.Increment(ref A01401A6);
										BC36568F(lblStatusXoaCacheProfile, Language.GetValue("Đang chạy") + $" {A01401A6}/{list_0.Count}...");
										Interlocked.Decrement(ref int_);
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
						while (int_ > 0)
						{
							Common.Sleep(1.0);
						}
						if (!bool_0)
						{
							BC36568F(lblStatusXoaCacheProfile, Language.GetValue("Hoàn thành!"));
							method_0(BDAE82BD, bool_1: false);
							method_0(CF11C23A);
							BC36568F(DA385A90, "");
							E22F0907(DA385A90);
							try
							{
								int CB2B21B8 = 0;
								int D52F2305 = 0;
								List<string> D88C3B8C = Directory.GetDirectories(Path.GetTempPath()).ToList();
								int num4 = 0;
								while (num4 < D88C3B8C.Count && !bool_0)
								{
									if (CB2B21B8 < num)
									{
										Interlocked.Increment(ref CB2B21B8);
										int int_0 = num4++;
										new Thread((ThreadStart)delegate
										{
											try
											{
												Common.DeleteFile(D88C3B8C[int_0]);
												Interlocked.Increment(ref D52F2305);
												BC36568F(DA385A90, Language.GetValue("Đang chạy") + $" {D52F2305}/{D88C3B8C.Count}...");
												Interlocked.Decrement(ref CB2B21B8);
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
								while (CB2B21B8 > 0)
								{
									Common.Sleep(1.0);
								}
							}
							catch
							{
							}
							Common.DeleteTempFile();
						}
					}
				}
				if (D4326619 && !bool_0)
				{
					Common.smethod_16();
				}
				Invoke((Action)delegate
				{
					Close();
				});
			}
			catch (Exception ex)
			{
				MessageBoxHelper.Show("Error:\n" + ex.ToString());
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

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.F7A45F34 = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.lblXoaFileRac = new System.Windows.Forms.Label();
		this.lblDonDepProfileRac = new System.Windows.Forms.Label();
		this.BDAE82BD = new System.Windows.Forms.Label();
		this.lblStatusXoaFileRac = new System.Windows.Forms.Label();
		this.lblStatusDonDepProfileRac = new System.Windows.Forms.Label();
		this.lblStatusXoaCacheProfile = new System.Windows.Forms.Label();
		this.DA385A90 = new System.Windows.Forms.Label();
		this.CF11C23A = new System.Windows.Forms.Label();
		this.bunifuCards1.SuspendLayout();
		this.F7A45F34.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.F7A45F34);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(373, 38);
		this.bunifuCards1.TabIndex = 0;
		this.F7A45F34.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.F7A45F34.BackColor = System.Drawing.Color.White;
		this.F7A45F34.Controls.Add(this.pictureBox1);
		this.F7A45F34.Controls.Add(this.btnMinimize);
		this.F7A45F34.Controls.Add(this.bunifuCustomLabel1);
		this.F7A45F34.Location = new System.Drawing.Point(0, 5);
		this.F7A45F34.Name = "pnlHeader";
		this.F7A45F34.Size = new System.Drawing.Size(373, 32);
		this.F7A45F34.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.Enabled = false;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = Resources.C400940B;
		this.btnMinimize.Location = new System.Drawing.Point(341, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(373, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Giải phóng dung lượng";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(142, 191);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Dừng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(CDA5F98D);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.lblXoaFileRac.AutoSize = true;
		this.lblXoaFileRac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblXoaFileRac.Location = new System.Drawing.Point(35, 71);
		this.lblXoaFileRac.Name = "lblXoaFileRac";
		this.lblXoaFileRac.Size = new System.Drawing.Size(90, 16);
		this.lblXoaFileRac.TabIndex = 5;
		this.lblXoaFileRac.Text = "1. Xóa File rác";
		this.lblDonDepProfileRac.AutoSize = true;
		this.lblDonDepProfileRac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblDonDepProfileRac.Location = new System.Drawing.Point(35, 95);
		this.lblDonDepProfileRac.Name = "lblDonDepProfileRac";
		this.lblDonDepProfileRac.Size = new System.Drawing.Size(131, 16);
		this.lblDonDepProfileRac.TabIndex = 5;
		this.lblDonDepProfileRac.Text = "2. Dọn dẹp profile rác";
		this.BDAE82BD.AutoSize = true;
		this.BDAE82BD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BDAE82BD.Location = new System.Drawing.Point(35, 119);
		this.BDAE82BD.Name = "lblXoaCacheProfile";
		this.BDAE82BD.Size = new System.Drawing.Size(123, 16);
		this.BDAE82BD.TabIndex = 5;
		this.BDAE82BD.Text = "3. Xóa Cache profile";
		this.lblStatusXoaFileRac.AutoSize = true;
		this.lblStatusXoaFileRac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatusXoaFileRac.ForeColor = System.Drawing.Color.DarkGreen;
		this.lblStatusXoaFileRac.Location = new System.Drawing.Point(200, 71);
		this.lblStatusXoaFileRac.Name = "lblStatusXoaFileRac";
		this.lblStatusXoaFileRac.Size = new System.Drawing.Size(79, 16);
		this.lblStatusXoaFileRac.TabIndex = 5;
		this.lblStatusXoaFileRac.Text = "Đang chạy...";
		this.lblStatusXoaFileRac.Visible = false;
		this.lblStatusDonDepProfileRac.AutoSize = true;
		this.lblStatusDonDepProfileRac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatusDonDepProfileRac.ForeColor = System.Drawing.Color.DarkGreen;
		this.lblStatusDonDepProfileRac.Location = new System.Drawing.Point(200, 95);
		this.lblStatusDonDepProfileRac.Name = "lblStatusDonDepProfileRac";
		this.lblStatusDonDepProfileRac.Size = new System.Drawing.Size(102, 16);
		this.lblStatusDonDepProfileRac.TabIndex = 5;
		this.lblStatusDonDepProfileRac.Text = "Đang chạy 0/0...";
		this.lblStatusDonDepProfileRac.Visible = false;
		this.lblStatusXoaCacheProfile.AutoSize = true;
		this.lblStatusXoaCacheProfile.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatusXoaCacheProfile.ForeColor = System.Drawing.Color.DarkGreen;
		this.lblStatusXoaCacheProfile.Location = new System.Drawing.Point(200, 119);
		this.lblStatusXoaCacheProfile.Name = "lblStatusXoaCacheProfile";
		this.lblStatusXoaCacheProfile.Size = new System.Drawing.Size(102, 16);
		this.lblStatusXoaCacheProfile.TabIndex = 5;
		this.lblStatusXoaCacheProfile.Text = "Đang chạy 0/0...";
		this.lblStatusXoaCacheProfile.Visible = false;
		this.DA385A90.AutoSize = true;
		this.DA385A90.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DA385A90.ForeColor = System.Drawing.Color.DarkGreen;
		this.DA385A90.Location = new System.Drawing.Point(200, 144);
		this.DA385A90.Name = "lblStatusXoaTemp";
		this.DA385A90.Size = new System.Drawing.Size(102, 16);
		this.DA385A90.TabIndex = 5;
		this.DA385A90.Text = "Đang chạy 0/0...";
		this.DA385A90.Visible = false;
		this.CF11C23A.AutoSize = true;
		this.CF11C23A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CF11C23A.Location = new System.Drawing.Point(35, 144);
		this.CF11C23A.Name = "lblXoaTemp";
		this.CF11C23A.Size = new System.Drawing.Size(81, 16);
		this.CF11C23A.TabIndex = 5;
		this.CF11C23A.Text = "4. Xóa Temp";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(373, 232);
		base.Controls.Add(this.CF11C23A);
		base.Controls.Add(this.BDAE82BD);
		base.Controls.Add(this.DA385A90);
		base.Controls.Add(this.lblDonDepProfileRac);
		base.Controls.Add(this.lblStatusXoaCacheProfile);
		base.Controls.Add(this.lblStatusDonDepProfileRac);
		base.Controls.Add(this.lblStatusXoaFileRac);
		base.Controls.Add(this.lblXoaFileRac);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fGiaiPhongDungLuong";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fGiaiPhongDungLuong_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.F7A45F34.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private void method_1()
	{
		btnCancel.Enabled = false;
	}

	[CompilerGenerated]
	private void method_2()
	{
		try
		{
			method_0(lblXoaFileRac);
			BC36568F(lblStatusXoaFileRac, Language.GetValue("Đang chạy") + "...");
			E22F0907(lblStatusXoaFileRac);
			Common.DeleteFile("log");
			Common.DeleteFile("log_capture");
			Common.DeleteFile("Plugins");
			Common.DeleteFile("golike");
			Common.DeleteFilex("logJob.txt");
			if (!bool_0)
			{
				BC36568F(lblStatusXoaFileRac, Language.GetValue("Hoàn thành!"));
				method_0(lblXoaFileRac, bool_1: false);
				method_0(lblDonDepProfileRac);
				BC36568F(lblStatusDonDepProfileRac, "");
				E22F0907(lblStatusDonDepProfileRac);
				int num = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
				List<string> list = Directory.GetDirectories(SettingsTool.GetPathProfile()).ToList();
				List<string> list2 = CA884292();
				List<string> E03F62BB = new List<string>();
				string text = "";
				for (int i = 0; i < list.Count; i++)
				{
					text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
					if (!list2.Contains(text))
					{
						E03F62BB.Add(text);
					}
				}
				try
				{
					int int_3 = 0;
					int int_2 = 0;
					int num2 = 0;
					while (num2 < E03F62BB.Count && !bool_0)
					{
						if (int_3 < num)
						{
							Interlocked.Increment(ref int_3);
							int D5A00EA6 = num2++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									string string_ = SettingsTool.GetPathProfile() + "\\" + E03F62BB[D5A00EA6];
									Common.DeleteFile(string_);
									Interlocked.Increment(ref int_2);
									BC36568F(lblStatusDonDepProfileRac, Language.GetValue("Đang chạy") + $" {int_2}/{E03F62BB.Count}...");
									Interlocked.Decrement(ref int_3);
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
					while (int_3 > 0)
					{
						Common.Sleep(1.0);
					}
				}
				catch
				{
				}
				if (!bool_0)
				{
					BC36568F(lblStatusDonDepProfileRac, Language.GetValue("Hoàn thành!"));
					method_0(lblDonDepProfileRac, bool_1: false);
					method_0(BDAE82BD);
					BC36568F(lblStatusXoaCacheProfile, "");
					E22F0907(lblStatusXoaCacheProfile);
					int int_ = 0;
					int A01401A6 = 0;
					List<string> list_0 = CA884292();
					int num3 = 0;
					while (num3 < list_0.Count && !bool_0)
					{
						if (int_ < num)
						{
							Interlocked.Increment(ref int_);
							string AC208722 = list_0[num3++];
							new Thread((ThreadStart)delegate
							{
								try
								{
									string text2 = SettingsTool.GetPathProfile() + "\\" + AC208722;
									if (Directory.Exists(text2))
									{
										Common.DeleteFile(text2 + "\\Default\\Cache");
										Common.DeleteFile(text2 + "\\Default\\Code Cache");
										Common.DeleteFile(text2 + "\\OptimizationGuidePredictionModels");
										Common.DeleteFile(text2 + "\\Default\\optimization_guide_prediction_model_downloads");
										Common.DeleteFile(text2 + "\\SwReporter");
										Common.DeleteFile(text2 + "\\pnacl");
									}
									Interlocked.Increment(ref A01401A6);
									BC36568F(lblStatusXoaCacheProfile, Language.GetValue("Đang chạy") + $" {A01401A6}/{list_0.Count}...");
									Interlocked.Decrement(ref int_);
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
					while (int_ > 0)
					{
						Common.Sleep(1.0);
					}
					if (!bool_0)
					{
						BC36568F(lblStatusXoaCacheProfile, Language.GetValue("Hoàn thành!"));
						method_0(BDAE82BD, bool_1: false);
						method_0(CF11C23A);
						BC36568F(DA385A90, "");
						E22F0907(DA385A90);
						try
						{
							int CB2B21B8 = 0;
							int D52F2305 = 0;
							List<string> D88C3B8C = Directory.GetDirectories(Path.GetTempPath()).ToList();
							int num4 = 0;
							while (num4 < D88C3B8C.Count && !bool_0)
							{
								if (CB2B21B8 < num)
								{
									Interlocked.Increment(ref CB2B21B8);
									int int_0 = num4++;
									new Thread((ThreadStart)delegate
									{
										try
										{
											Common.DeleteFile(D88C3B8C[int_0]);
											Interlocked.Increment(ref D52F2305);
											BC36568F(DA385A90, Language.GetValue("Đang chạy") + $" {D52F2305}/{D88C3B8C.Count}...");
											Interlocked.Decrement(ref CB2B21B8);
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
							while (CB2B21B8 > 0)
							{
								Common.Sleep(1.0);
							}
						}
						catch
						{
						}
						Common.DeleteTempFile();
					}
				}
			}
			if (D4326619 && !bool_0)
			{
				Common.smethod_16();
			}
			Invoke((Action)delegate
			{
				Close();
			});
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show("Error:\n" + ex.ToString());
		}
	}

	[CompilerGenerated]
	private void method_3()
	{
		Close();
	}
}
