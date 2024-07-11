using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchGolike2 : Form
{
	[CompilerGenerated]
	private sealed class Class106
	{
		public fTienIchGolike2 ff27C809_0;

		public string FFA69321;

		internal void method_0()
		{
			try
			{
				for (int i = 0; i < ff27C809_0.dtgv.RowCount; i++)
				{
					Thread thread = new Thread(new Class107
					{
						class106_0 = this,
						C81BC5B1 = i
					}.F53A2136);
					thread.IsBackground = true;
					thread.Start();
				}
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class107
	{
		public int C81BC5B1;

		public Class106 class106_0;

		internal void F53A2136()
		{
			try
			{
				string text = class106_0.ff27C809_0.dtgv.Rows[C81BC5B1].Cells["cUid"].Value.ToString();
				string string_ = CheckInfoAccountv2.GetName(text);
				var (list, text2) = GClass16.smethod_0(class106_0.FFA69321, text, string_, "", "", 1);
				if (text2 != "")
				{
					DatagridviewHelper.SetStatusDataGridView(class106_0.ff27C809_0.dtgv, C81BC5B1, "cStatus", text2);
				}
				else if (list.Count > 0)
				{
					DatagridviewHelper.SetStatusDataGridView(class106_0.ff27C809_0.dtgv, C81BC5B1, "cStatus", "Get job thành công!");
				}
				else
				{
					DatagridviewHelper.SetStatusDataGridView(class106_0.ff27C809_0.dtgv, C81BC5B1, "cStatus", "Không lâ\u0301y đươ\u0323c job!");
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class E5959C8B
	{
		public string string_0;

		internal void EBB9C49D()
		{
			string object_ = GClass17.smethod_0(string_0);
			MessageBoxHelper.Show(object_);
		}
	}

	private bool bool_0 = false;

	public static List<string> list_0;

	public static List<string> C6A28790;

	public static bool AC00B223;

	private IContainer CC9A620F = null;

	private BunifuCards CD197E3A;

	private Panel B2870FAF;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private BunifuDragControl E8B28D0D;

	private PictureBox pictureBox1;

	public DataGridView dtgv;

	private RichTextBox txtListUid;

	private Label label17;

	private Label label1;

	private Button btnCheck;

	private Label label2;

	private TextBox B5046A8C;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cUid;

	private DataGridViewTextBoxColumn cStatus;

	private Button button1;

	public fTienIchGolike2(bool bool_1 = false)
	{
		InitializeComponent();
		AC00B223 = false;
		bool_0 = bool_1;
		Language.SetLanguage(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0(object sender, EventArgs e)
	{
		AC00B223 = true;
		if (bool_0)
		{
			C6A28790 = new List<string>();
			for (int i = 0; i < dtgv.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgv.Rows[i].Cells["cChose"].Value))
				{
					C6A28790.Add(DatagridviewHelper.GetStatusDataGridView(dtgv, i, "cId"));
				}
			}
			if (C6A28790.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn ít nhất 1 thư mục!"), 2);
				return;
			}
		}
		else
		{
			list_0 = new List<string>();
			for (int j = 0; j < dtgv.Rows.Count; j++)
			{
				if (Convert.ToBoolean(dtgv.Rows[j].Cells["cChose"].Value))
				{
					list_0.Add(DatagridviewHelper.GetStatusDataGridView(dtgv, j, "cId"));
				}
			}
			if (list_0.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn ít nhất 1 thư mục!"), 2);
				return;
			}
		}
		Close();
	}

	private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (Convert.ToBoolean(dtgv.CurrentRow.Cells["cChose"].Value))
			{
				dtgv.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				dtgv.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private int method_1()
	{
		int num = 0;
		for (int i = 0; i < dtgv.Rows.Count; i++)
		{
			if (Convert.ToBoolean(dtgv.Rows[i].Cells["cChose"].Value))
			{
				num++;
			}
		}
		return num;
	}

	private void E6281F12(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 0)
		{
			return;
		}
		try
		{
			if (Convert.ToBoolean(dtgv.CurrentRow.Cells["cChose"].Value))
			{
				dtgv.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				dtgv.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private void D39C4F1A(object sender, EventArgs e)
	{
		Common.F9202C12(txtListUid, label17);
	}

	private void btnCheck_Click(object sender, EventArgs e)
	{
		if (B5046A8C.Text.Trim() == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập API Key!", 3);
			B5046A8C.Focus();
			return;
		}
		if (txtListUid.Text.Trim() == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập Uid!", 3);
			txtListUid.Focus();
			return;
		}
		string FFA69321 = B5046A8C.Text.Trim().TrimEnd('/');
		List<string> a2AB53A = txtListUid.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		dtgv.Rows.Clear();
		for (int i = 0; i < a2AB53A.Count; i++)
		{
			dtgv.Rows.Add(i + 1, a2AB53A[i], "Checking...");
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				for (int j = 0; j < dtgv.RowCount; j++)
				{
					int C81BC5B1 = j;
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						try
						{
							string text = dtgv.Rows[C81BC5B1].Cells["cUid"].Value.ToString();
							string string_ = CheckInfoAccountv2.GetName(text);
							var (list, text2) = GClass16.smethod_0(FFA69321, text, string_, "", "", 1);
							if (text2 != "")
							{
								DatagridviewHelper.SetStatusDataGridView(dtgv, C81BC5B1, "cStatus", text2);
							}
							else if (list.Count > 0)
							{
								DatagridviewHelper.SetStatusDataGridView(dtgv, C81BC5B1, "cStatus", "Get job thành công!");
							}
							else
							{
								DatagridviewHelper.SetStatusDataGridView(dtgv, C81BC5B1, "cStatus", "Không lâ\u0301y đươ\u0323c job!");
							}
						}
						catch (Exception)
						{
						}
					});
					thread2.IsBackground = true;
					thread2.Start();
				}
			}
			catch
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		string string_0 = B5046A8C.Text.Trim();
		if (string_0 == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập API Key!", 3);
			B5046A8C.Focus();
			return;
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			string object_ = GClass17.smethod_0(string_0);
			MessageBoxHelper.Show(object_);
		});
		thread.IsBackground = true;
		thread.Start();
	}

	protected override void Dispose(bool C38F2CB9)
	{
		if (C38F2CB9 && CC9A620F != null)
		{
			CC9A620F.Dispose();
		}
		base.Dispose(C38F2CB9);
	}

	private void InitializeComponent()
	{
		this.CC9A620F = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.CD197E3A = new Bunifu.Framework.UI.BunifuCards();
		this.B2870FAF = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.E8B28D0D = new Bunifu.Framework.UI.BunifuDragControl(this.CC9A620F);
		this.dtgv = new System.Windows.Forms.DataGridView();
		this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.txtListUid = new System.Windows.Forms.RichTextBox();
		this.label17 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCheck = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.B5046A8C = new System.Windows.Forms.TextBox();
		this.button1 = new System.Windows.Forms.Button();
		this.CD197E3A.SuspendLayout();
		this.B2870FAF.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dtgv).BeginInit();
		base.SuspendLayout();
		this.CD197E3A.BackColor = System.Drawing.Color.White;
		this.CD197E3A.BorderRadius = 0;
		this.CD197E3A.BottomSahddow = true;
		this.CD197E3A.color = System.Drawing.Color.SaddleBrown;
		this.CD197E3A.Controls.Add(this.B2870FAF);
		this.CD197E3A.Dock = System.Windows.Forms.DockStyle.Top;
		this.CD197E3A.LeftSahddow = false;
		this.CD197E3A.Location = new System.Drawing.Point(0, 0);
		this.CD197E3A.Name = "bunifuCards1";
		this.CD197E3A.RightSahddow = true;
		this.CD197E3A.ShadowDepth = 20;
		this.CD197E3A.Size = new System.Drawing.Size(530, 34);
		this.CD197E3A.TabIndex = 0;
		this.B2870FAF.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.B2870FAF.BackColor = System.Drawing.Color.White;
		this.B2870FAF.Controls.Add(this.pictureBox1);
		this.B2870FAF.Controls.Add(this.btnMinimize);
		this.B2870FAF.Controls.Add(this.bunifuCustomLabel1);
		this.B2870FAF.Location = new System.Drawing.Point(0, 3);
		this.B2870FAF.Name = "pnlHeader";
		this.B2870FAF.Size = new System.Drawing.Size(530, 28);
		this.B2870FAF.TabIndex = 9;
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
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = Resources.C400940B;
		this.btnMinimize.Location = new System.Drawing.Point(498, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 28);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(530, 28);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Check Golike";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E8B28D0D.Fixed = true;
		this.E8B28D0D.Horizontal = true;
		this.E8B28D0D.TargetControl = this.bunifuCustomLabel1;
		this.E8B28D0D.Vertical = true;
		this.dtgv.AllowUserToAddRows = false;
		this.dtgv.AllowUserToDeleteRows = false;
		this.dtgv.AllowUserToResizeRows = false;
		this.dtgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dtgv.Columns.AddRange(this.cStt, this.cUid, this.cStatus);
		this.dtgv.Location = new System.Drawing.Point(15, 318);
		this.dtgv.Name = "dtgv";
		this.dtgv.ReadOnly = true;
		this.dtgv.RowHeadersVisible = false;
		this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgv.Size = new System.Drawing.Size(499, 211);
		this.dtgv.TabIndex = 7;
		this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(E6281F12);
		this.dtgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgv_CellDoubleClick);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.cStt.DefaultCellStyle = dataGridViewCellStyle2;
		this.cStt.HeaderText = "STT";
		this.cStt.Name = "cStt";
		this.cStt.ReadOnly = true;
		this.cStt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.cStt.Width = 35;
		this.cUid.HeaderText = "Uid";
		this.cUid.Name = "cUid";
		this.cUid.ReadOnly = true;
		this.cUid.Width = 90;
		this.cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cStatus.HeaderText = "Status";
		this.cStatus.Name = "cStatus";
		this.cStatus.ReadOnly = true;
		this.txtListUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtListUid.Font = new System.Drawing.Font("Tahoma", 9.75f);
		this.txtListUid.Location = new System.Drawing.Point(15, 92);
		this.txtListUid.Name = "txtListUid";
		this.txtListUid.Size = new System.Drawing.Size(499, 158);
		this.txtListUid.TabIndex = 146;
		this.txtListUid.Text = "";
		this.txtListUid.WordWrap = false;
		this.txtListUid.TextChanged += new System.EventHandler(D39C4F1A);
		this.label17.AutoSize = true;
		this.label17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label17.Location = new System.Drawing.Point(12, 73);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(84, 16);
		this.label17.TabIndex = 145;
		this.label17.Text = "Nhập Uid (0):";
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label1.Location = new System.Drawing.Point(12, 299);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(55, 16);
		this.label1.TabIndex = 145;
		this.label1.Text = "Kết quả:";
		this.btnCheck.BackColor = System.Drawing.Color.Green;
		this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCheck.FlatAppearance.BorderSize = 0;
		this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCheck.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCheck.ForeColor = System.Drawing.Color.White;
		this.btnCheck.Location = new System.Drawing.Point(223, 261);
		this.btnCheck.Name = "btnCheck";
		this.btnCheck.Size = new System.Drawing.Size(82, 33);
		this.btnCheck.TabIndex = 147;
		this.btnCheck.Text = "Get Job";
		this.btnCheck.UseVisualStyleBackColor = false;
		this.btnCheck.Click += new System.EventHandler(btnCheck_Click);
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label2.Location = new System.Drawing.Point(12, 50);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(55, 16);
		this.label2.TabIndex = 145;
		this.label2.Text = "API Key:";
		this.B5046A8C.Font = new System.Drawing.Font("Tahoma", 9.75f);
		this.B5046A8C.Location = new System.Drawing.Point(73, 47);
		this.B5046A8C.Name = "txtApiKey";
		this.B5046A8C.Size = new System.Drawing.Size(377, 23);
		this.B5046A8C.TabIndex = 148;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Location = new System.Drawing.Point(455, 46);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(59, 25);
		this.button1.TabIndex = 150;
		this.button1.Text = "Check";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(530, 547);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.B5046A8C);
		base.Controls.Add(this.btnCheck);
		base.Controls.Add(this.txtListUid);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.label17);
		base.Controls.Add(this.dtgv);
		base.Controls.Add(this.CD197E3A);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fTienIchGolike2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		this.CD197E3A.ResumeLayout(false);
		this.B2870FAF.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dtgv).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
