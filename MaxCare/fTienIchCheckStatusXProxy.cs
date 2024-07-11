using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckStatusXProxy : Form
{
	[CompilerGenerated]
	private sealed class Class100
	{
		public string B9233284;

		public fTienIchCheckStatusXProxy fTienIchCheckStatusXProxy_0;

		internal void method_0()
		{
			try
			{
				if (B9233284 == "")
				{
					for (int i = 0; i < fTienIchCheckStatusXProxy_0.dtgv.RowCount; i++)
					{
						Thread thread = new Thread(new Class101
						{
							class100_0 = this,
							B3A6658C = i
						}.method_0);
						thread.IsBackground = true;
						thread.Start();
					}
				}
				else if (B9233284.StartsWith("http"))
				{
					for (int j = 0; j < fTienIchCheckStatusXProxy_0.dtgv.RowCount; j++)
					{
						Thread thread2 = new Thread(new EF3FDC2C
						{
							B3122024 = this,
							D1AE9024 = j
						}.method_0);
						thread2.IsBackground = true;
						thread2.Start();
					}
				}
				else
				{
					for (int k = 0; k < fTienIchCheckStatusXProxy_0.dtgv.RowCount; k++)
					{
						Thread thread3 = new Thread(new Class102
						{
							class100_0 = this,
							C71D5882 = k
						}.BBA63024);
						thread3.IsBackground = true;
						thread3.Start();
					}
				}
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class101
	{
		public int B3A6658C;

		public Class100 class100_0;

		internal void method_0()
		{
			try
			{
				string c = class100_0.fTienIchCheckStatusXProxy_0.dtgv.Rows[B3A6658C].Cells["cProxy"].Value.ToString();
				string object_ = Common.CheckIP(c);
				DatagridviewHelper.SetStatusDataGridView(class100_0.fTienIchCheckStatusXProxy_0.dtgv, B3A6658C, "cStatus", object_);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class EF3FDC2C
	{
		public int D1AE9024;

		public Class100 B3122024;

		internal void method_0()
		{
			try
			{
				string text = B3122024.fTienIchCheckStatusXProxy_0.dtgv.Rows[D1AE9024].Cells["cProxy"].Value.ToString();
				string aDBFD1B = B3122024.B9233284 + "/status?proxy=" + text;
				string object_ = new RequestXNet("", "", "", 0).RequestGet(aDBFD1B);
				DatagridviewHelper.SetStatusDataGridView(B3122024.fTienIchCheckStatusXProxy_0.dtgv, D1AE9024, "cStatus", object_);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class102
	{
		public int C71D5882;

		public Class100 class100_0;

		internal void BBA63024()
		{
			try
			{
				string text = class100_0.fTienIchCheckStatusXProxy_0.dtgv.Rows[C71D5882].Cells["cProxy"].Value.ToString();
				string string_ = "https://api.proxyv6.net/api/check-list-proxy?api_key=" + class100_0.B9233284;
				string text2 = text.Split(':')[2] + ":" + text.Split(':')[3] + "@" + text.Split(':')[0] + ":" + text.Split(':')[1];
				string e5B = "{\"proxies\": [\"" + text2 + "\"]}";
				RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
				string object_ = fB87CFA.RequestPost(string_, e5B, "application/json");
				DatagridviewHelper.SetStatusDataGridView(class100_0.fTienIchCheckStatusXProxy_0.dtgv, C71D5882, "cStatus", object_);
			}
			catch
			{
			}
		}
	}

	private bool bool_0 = false;

	public static List<string> F2902A81;

	public static List<string> list_0;

	public static bool bool_1;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel E915AD28;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	public DataGridView dtgv;

	private RichTextBox txtListProxy;

	private Label label17;

	private Label label1;

	private DataGridViewTextBoxColumn FF8AE733;

	private DataGridViewTextBoxColumn F325E09B;

	private DataGridViewTextBoxColumn cStatus;

	private Button btnCheck;

	private Label label2;

	private TextBox FC35BEA4;

	public fTienIchCheckStatusXProxy(bool DB814A16 = false)
	{
		E38DFA99();
		bool_1 = false;
		bool_0 = DB814A16;
		Language.SetLanguage(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0(object sender, EventArgs e)
	{
		bool_1 = true;
		if (bool_0)
		{
			list_0 = new List<string>();
			for (int i = 0; i < dtgv.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgv.Rows[i].Cells["cChose"].Value))
				{
					list_0.Add(DatagridviewHelper.GetStatusDataGridView(dtgv, i, "cId"));
				}
			}
			if (list_0.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn ít nhất 1 thư mục!"), 2);
				return;
			}
		}
		else
		{
			F2902A81 = new List<string>();
			for (int j = 0; j < dtgv.Rows.Count; j++)
			{
				if (Convert.ToBoolean(dtgv.Rows[j].Cells["cChose"].Value))
				{
					F2902A81.Add(DatagridviewHelper.GetStatusDataGridView(dtgv, j, "cId"));
				}
			}
			if (F2902A81.Count == 0)
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

	private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
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

	private void txtListProxy_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtListProxy, label17);
	}

	private void btnCheck_Click(object sender, EventArgs e)
	{
		if (txtListProxy.Text.Trim() == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập proxy trước!", 3);
			txtListProxy.Focus();
			return;
		}
		string B9233284 = FC35BEA4.Text.Trim().TrimEnd('/');
		List<string> a2AB53A = txtListProxy.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		dtgv.Rows.Clear();
		for (int i = 0; i < a2AB53A.Count; i++)
		{
			dtgv.Rows.Add(i + 1, a2AB53A[i], "Đang check...");
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				if (B9233284 == "")
				{
					for (int j = 0; j < dtgv.RowCount; j++)
					{
						int B3A6658C = j;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							try
							{
								string c = dtgv.Rows[B3A6658C].Cells["cProxy"].Value.ToString();
								string object_3 = Common.CheckIP(c);
								DatagridviewHelper.SetStatusDataGridView(dtgv, B3A6658C, "cStatus", object_3);
							}
							catch
							{
							}
						});
						thread2.IsBackground = true;
						thread2.Start();
					}
				}
				else if (B9233284.StartsWith("http"))
				{
					for (int k = 0; k < dtgv.RowCount; k++)
					{
						int D1AE9024 = k;
						Thread thread3 = new Thread((ThreadStart)delegate
						{
							try
							{
								string text3 = dtgv.Rows[D1AE9024].Cells["cProxy"].Value.ToString();
								string aDBFD1B = B9233284 + "/status?proxy=" + text3;
								string object_2 = new RequestXNet("", "", "", 0).RequestGet(aDBFD1B);
								DatagridviewHelper.SetStatusDataGridView(dtgv, D1AE9024, "cStatus", object_2);
							}
							catch
							{
							}
						});
						thread3.IsBackground = true;
						thread3.Start();
					}
				}
				else
				{
					for (int l = 0; l < dtgv.RowCount; l++)
					{
						int C71D5882 = l;
						Thread thread4 = new Thread((ThreadStart)delegate
						{
							try
							{
								string text = dtgv.Rows[C71D5882].Cells["cProxy"].Value.ToString();
								string string_ = "https://api.proxyv6.net/api/check-list-proxy?api_key=" + B9233284;
								string text2 = text.Split(':')[2] + ":" + text.Split(':')[3] + "@" + text.Split(':')[0] + ":" + text.Split(':')[1];
								string e5B = "{\"proxies\": [\"" + text2 + "\"]}";
								RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
								string object_ = fB87CFA.RequestPost(string_, e5B, "application/json");
								DatagridviewHelper.SetStatusDataGridView(dtgv, C71D5882, "cStatus", object_);
							}
							catch
							{
							}
						});
						thread4.IsBackground = true;
						thread4.Start();
					}
				}
			}
			catch
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void E38DFA99()
	{
		icontainer_0 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		bunifuCards1 = new BunifuCards();
		E915AD28 = new Panel();
		pictureBox1 = new PictureBox();
		btnMinimize = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		dtgv = new DataGridView();
		FF8AE733 = new DataGridViewTextBoxColumn();
		F325E09B = new DataGridViewTextBoxColumn();
		cStatus = new DataGridViewTextBoxColumn();
		txtListProxy = new RichTextBox();
		label17 = new Label();
		label1 = new Label();
		btnCheck = new Button();
		label2 = new Label();
		FC35BEA4 = new TextBox();
		bunifuCards1.SuspendLayout();
		E915AD28.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)dtgv).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.Controls.Add(E915AD28);
		bunifuCards1.Dock = DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(530, 34);
		bunifuCards1.TabIndex = 0;
		E915AD28.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		E915AD28.BackColor = Color.White;
		E915AD28.Controls.Add(pictureBox1);
		E915AD28.Controls.Add(btnMinimize);
		E915AD28.Controls.Add(bunifuCustomLabel1);
		E915AD28.Location = new Point(0, 3);
		E915AD28.Name = "pnlHeader";
		E915AD28.Size = new Size(530, 28);
		E915AD28.TabIndex = 9;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.Dock = DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Image = Resources.C400940B;
		btnMinimize.Location = new Point(498, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(32, 28);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += btnMinimize_Click;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(530, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Check status XProxy";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		dtgv.AllowUserToAddRows = false;
		dtgv.AllowUserToDeleteRows = false;
		dtgv.AllowUserToResizeRows = false;
		dtgv.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgv.Columns.AddRange(FF8AE733, F325E09B, cStatus);
		dtgv.Location = new Point(15, 318);
		dtgv.Name = "dtgv";
		dtgv.ReadOnly = true;
		dtgv.RowHeadersVisible = false;
		dtgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dtgv.Size = new Size(499, 211);
		dtgv.TabIndex = 7;
		dtgv.CellClick += dtgv_CellClick;
		dtgv.CellDoubleClick += dtgv_CellDoubleClick;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		FF8AE733.DefaultCellStyle = dataGridViewCellStyle2;
		FF8AE733.HeaderText = "STT";
		FF8AE733.Name = "cStt";
		FF8AE733.ReadOnly = true;
		FF8AE733.Resizable = DataGridViewTriState.False;
		FF8AE733.Width = 35;
		F325E09B.HeaderText = "Proxy";
		F325E09B.Name = "cProxy";
		F325E09B.ReadOnly = true;
		F325E09B.Width = 90;
		cStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		cStatus.HeaderText = "Status";
		cStatus.Name = "cStatus";
		cStatus.ReadOnly = true;
		txtListProxy.BorderStyle = BorderStyle.FixedSingle;
		txtListProxy.Font = new Font("Tahoma", 9.75f);
		txtListProxy.Location = new Point(15, 92);
		txtListProxy.Name = "txtListProxy";
		txtListProxy.Size = new Size(499, 158);
		txtListProxy.TabIndex = 146;
		txtListProxy.Text = "";
		txtListProxy.WordWrap = false;
		txtListProxy.TextChanged += txtListProxy_TextChanged;
		label17.AutoSize = true;
		label17.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label17.Location = new Point(12, 73);
		label17.Name = "label17";
		label17.Size = new Size(97, 16);
		label17.TabIndex = 145;
		label17.Text = "Nhập Proxy (0):";
		label1.AutoSize = true;
		label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label1.Location = new Point(12, 299);
		label1.Name = "label1";
		label1.Size = new Size(55, 16);
		label1.TabIndex = 145;
		label1.Text = "Kết quả:";
		btnCheck.BackColor = Color.Green;
		btnCheck.Cursor = Cursors.Hand;
		btnCheck.FlatAppearance.BorderSize = 0;
		btnCheck.FlatStyle = FlatStyle.Flat;
		btnCheck.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCheck.ForeColor = Color.White;
		btnCheck.Location = new Point(223, 261);
		btnCheck.Name = "btnCheck";
		btnCheck.Size = new Size(82, 33);
		btnCheck.TabIndex = 147;
		btnCheck.Text = "Check";
		btnCheck.UseVisualStyleBackColor = false;
		btnCheck.Click += btnCheck_Click;
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label2.Location = new Point(12, 48);
		label2.Name = "label2";
		label2.Size = new Size(34, 16);
		label2.TabIndex = 145;
		label2.Text = "URL:";
		FC35BEA4.Font = new Font("Tahoma", 9.75f);
		FC35BEA4.Location = new Point(53, 47);
		FC35BEA4.Name = "txtUrl";
		FC35BEA4.Size = new Size(461, 23);
		FC35BEA4.TabIndex = 148;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(530, 547);
		base.Controls.Add(FC35BEA4);
		base.Controls.Add(btnCheck);
		base.Controls.Add(txtListProxy);
		base.Controls.Add(label2);
		base.Controls.Add(label1);
		base.Controls.Add(label17);
		base.Controls.Add(dtgv);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fTienIchCheckStatusXProxy";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		bunifuCards1.ResumeLayout(performLayout: false);
		E915AD28.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)dtgv).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
