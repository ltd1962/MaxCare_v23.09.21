using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckTinsoft : Form
{
	[CompilerGenerated]
	private sealed class D29894BC
	{
		public fTienIchCheckTinsoft DFAFD3A1;

		public int B19F9E18;

		internal void method_0()
		{
			try
			{
				for (int i = 0; i < DFAFD3A1.B839F197.RowCount; i++)
				{
					Thread thread = new Thread(new Class99
					{
						d29894BC_0 = this,
						FFACA410 = i
					}.method_0);
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
	private sealed class Class99
	{
		public int FFACA410;

		public D29894BC d29894BC_0;

		internal void method_0()
		{
			try
			{
				string text = d29894BC_0.DFAFD3A1.B839F197.Rows[FFACA410].Cells["cProxy"].Value.ToString();
				string object_ = "";
				switch (d29894BC_0.B19F9E18)
				{
				case 0:
					object_ = Common.RequestGet("http://proxy.tinsoftsv.com/api/getKeyInfo.php?key=" + text);
					break;
				case 1:
					object_ = Common.RequestGet("http://proxy.tinsoftsv.com/api/getProxy.php?key=" + text);
					break;
				case 2:
					object_ = Common.RequestGet("http://proxy.tinsoftsv.com/api/changeProxy.php?key=" + text + "&location=0");
					break;
				}
				DatagridviewHelper.SetStatusDataGridView(d29894BC_0.DFAFD3A1.B839F197, FFACA410, "cStatus", object_);
			}
			catch
			{
			}
		}
	}

	private bool bool_0 = false;

	public static List<string> list_0;

	public static List<string> C5B24C9C;

	public static bool bool_1;

	private IContainer D58CE787 = null;

	private BunifuCards ED19963C;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button B71F83AA;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	public DataGridView B839F197;

	private RichTextBox txtListProxy;

	private Label label17;

	private Label BBB3C3A0;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cProxy;

	private DataGridViewTextBoxColumn F907B939;

	private Button btnCheck;

	private Button button1;

	private Button button2;

	public fTienIchCheckTinsoft(bool bool_2 = false)
	{
		EBB1D53E();
		bool_1 = false;
		bool_0 = bool_2;
		Language.SetLanguage(this);
	}

	private void EA0DA4BA(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0(object sender, EventArgs e)
	{
		bool_1 = true;
		if (bool_0)
		{
			C5B24C9C = new List<string>();
			for (int i = 0; i < B839F197.Rows.Count; i++)
			{
				if (Convert.ToBoolean(B839F197.Rows[i].Cells["cChose"].Value))
				{
					C5B24C9C.Add(DatagridviewHelper.GetStatusDataGridView(B839F197, i, "cId"));
				}
			}
			if (C5B24C9C.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn ít nhất 1 thư mục!"), 2);
				return;
			}
		}
		else
		{
			list_0 = new List<string>();
			for (int j = 0; j < B839F197.Rows.Count; j++)
			{
				if (Convert.ToBoolean(B839F197.Rows[j].Cells["cChose"].Value))
				{
					list_0.Add(DatagridviewHelper.GetStatusDataGridView(B839F197, j, "cId"));
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

	private void AE085984(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (Convert.ToBoolean(B839F197.CurrentRow.Cells["cChose"].Value))
			{
				B839F197.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				B839F197.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private int method_1()
	{
		int num = 0;
		for (int i = 0; i < B839F197.Rows.Count; i++)
		{
			if (Convert.ToBoolean(B839F197.Rows[i].Cells["cChose"].Value))
			{
				num++;
			}
		}
		return num;
	}

	private void B839F197_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 0)
		{
			return;
		}
		try
		{
			if (Convert.ToBoolean(B839F197.CurrentRow.Cells["cChose"].Value))
			{
				B839F197.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				B839F197.CurrentRow.Cells["cChose"].Value = true;
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

	private void CD3F8691(int int_0)
	{
		if (txtListProxy.Text.Trim() == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập proxy trước!", 3);
			txtListProxy.Focus();
			return;
		}
		List<string> a2AB53A = txtListProxy.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		B839F197.Rows.Clear();
		for (int i = 0; i < a2AB53A.Count; i++)
		{
			B839F197.Rows.Add(i + 1, a2AB53A[i], "Đang check...");
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				for (int j = 0; j < B839F197.RowCount; j++)
				{
					int FFACA410 = j;
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						try
						{
							string text = B839F197.Rows[FFACA410].Cells["cProxy"].Value.ToString();
							string object_ = "";
							switch (int_0)
							{
							case 0:
								object_ = Common.RequestGet("http://proxy.tinsoftsv.com/api/getKeyInfo.php?key=" + text);
								break;
							case 1:
								object_ = Common.RequestGet("http://proxy.tinsoftsv.com/api/getProxy.php?key=" + text);
								break;
							case 2:
								object_ = Common.RequestGet("http://proxy.tinsoftsv.com/api/changeProxy.php?key=" + text + "&location=0");
								break;
							}
							DatagridviewHelper.SetStatusDataGridView(B839F197, FFACA410, "cStatus", object_);
						}
						catch
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

	private void btnCheck_Click(object sender, EventArgs e)
	{
		CD3F8691(0);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		CD3F8691(1);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		CD3F8691(2);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && D58CE787 != null)
		{
			D58CE787.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void EBB1D53E()
	{
		D58CE787 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		ED19963C = new BunifuCards();
		pnlHeader = new Panel();
		pictureBox1 = new PictureBox();
		B71F83AA = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(D58CE787);
		B839F197 = new DataGridView();
		cStt = new DataGridViewTextBoxColumn();
		cProxy = new DataGridViewTextBoxColumn();
		F907B939 = new DataGridViewTextBoxColumn();
		txtListProxy = new RichTextBox();
		label17 = new Label();
		BBB3C3A0 = new Label();
		btnCheck = new Button();
		button1 = new Button();
		button2 = new Button();
		ED19963C.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)B839F197).BeginInit();
		SuspendLayout();
		ED19963C.BackColor = Color.White;
		ED19963C.BorderRadius = 0;
		ED19963C.BottomSahddow = true;
		ED19963C.color = Color.SaddleBrown;
		ED19963C.Controls.Add(pnlHeader);
		ED19963C.Dock = DockStyle.Top;
		ED19963C.LeftSahddow = false;
		ED19963C.Location = new Point(0, 0);
		ED19963C.Name = "bunifuCards1";
		ED19963C.RightSahddow = true;
		ED19963C.ShadowDepth = 20;
		ED19963C.Size = new Size(675, 34);
		ED19963C.TabIndex = 0;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(B71F83AA);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(675, 28);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		B71F83AA.Cursor = Cursors.Hand;
		B71F83AA.Dock = DockStyle.Right;
		B71F83AA.FlatAppearance.BorderSize = 0;
		B71F83AA.FlatStyle = FlatStyle.Flat;
		B71F83AA.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B71F83AA.ForeColor = Color.White;
		B71F83AA.Image = Resources.C400940B;
		B71F83AA.Location = new Point(643, 0);
		B71F83AA.Name = "btnMinimize";
		B71F83AA.Size = new Size(32, 28);
		B71F83AA.TabIndex = 9;
		B71F83AA.TextImageRelation = TextImageRelation.ImageBeforeText;
		B71F83AA.UseVisualStyleBackColor = true;
		B71F83AA.Click += EA0DA4BA;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(675, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Check status Tinsoft";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		B839F197.AllowUserToAddRows = false;
		B839F197.AllowUserToDeleteRows = false;
		B839F197.AllowUserToResizeRows = false;
		B839F197.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B839F197.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		B839F197.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		B839F197.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		B839F197.Columns.AddRange(cStt, cProxy, F907B939);
		B839F197.Location = new Point(15, 318);
		B839F197.Name = "dtgv";
		B839F197.ReadOnly = true;
		B839F197.RowHeadersVisible = false;
		B839F197.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		B839F197.Size = new Size(644, 211);
		B839F197.TabIndex = 7;
		B839F197.CellClick += B839F197_CellClick;
		B839F197.CellDoubleClick += AE085984;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		cStt.DefaultCellStyle = dataGridViewCellStyle2;
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.ReadOnly = true;
		cStt.Resizable = DataGridViewTriState.False;
		cStt.Width = 35;
		cProxy.HeaderText = "Proxy";
		cProxy.Name = "cProxy";
		cProxy.ReadOnly = true;
		cProxy.Width = 90;
		F907B939.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		F907B939.HeaderText = "Status";
		F907B939.Name = "cStatus";
		F907B939.ReadOnly = true;
		txtListProxy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtListProxy.BorderStyle = BorderStyle.FixedSingle;
		txtListProxy.Font = new Font("Tahoma", 9.75f);
		txtListProxy.Location = new Point(15, 68);
		txtListProxy.Name = "txtListProxy";
		txtListProxy.Size = new Size(644, 182);
		txtListProxy.TabIndex = 146;
		txtListProxy.Text = "";
		txtListProxy.WordWrap = false;
		txtListProxy.TextChanged += txtListProxy_TextChanged;
		label17.AutoSize = true;
		label17.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label17.Location = new Point(12, 49);
		label17.Name = "label17";
		label17.Size = new Size(103, 16);
		label17.TabIndex = 145;
		label17.Text = "Nhập Apikey (0):";
		BBB3C3A0.AutoSize = true;
		BBB3C3A0.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		BBB3C3A0.Location = new Point(12, 299);
		BBB3C3A0.Name = "label1";
		BBB3C3A0.Size = new Size(55, 16);
		BBB3C3A0.TabIndex = 145;
		BBB3C3A0.Text = "Kết quả:";
		btnCheck.BackColor = Color.Green;
		btnCheck.Cursor = Cursors.Hand;
		btnCheck.FlatAppearance.BorderSize = 0;
		btnCheck.FlatStyle = FlatStyle.Flat;
		btnCheck.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCheck.ForeColor = Color.White;
		btnCheck.Location = new Point(147, 256);
		btnCheck.Name = "btnCheck";
		btnCheck.Size = new Size(114, 33);
		btnCheck.TabIndex = 147;
		btnCheck.Text = "Get key info";
		btnCheck.UseVisualStyleBackColor = false;
		btnCheck.Click += btnCheck_Click;
		button1.BackColor = Color.Green;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Location = new Point(283, 256);
		button1.Name = "button1";
		button1.Size = new Size(104, 33);
		button1.TabIndex = 147;
		button1.Text = "Get proxy";
		button1.UseVisualStyleBackColor = false;
		button1.Click += button1_Click;
		button2.BackColor = Color.Green;
		button2.Cursor = Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = FlatStyle.Flat;
		button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button2.ForeColor = Color.White;
		button2.Location = new Point(407, 256);
		button2.Name = "button2";
		button2.Size = new Size(108, 33);
		button2.TabIndex = 147;
		button2.Text = "Change proxy";
		button2.UseVisualStyleBackColor = false;
		button2.Click += button2_Click;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(675, 547);
		base.Controls.Add(button2);
		base.Controls.Add(button1);
		base.Controls.Add(btnCheck);
		base.Controls.Add(txtListProxy);
		base.Controls.Add(BBB3C3A0);
		base.Controls.Add(label17);
		base.Controls.Add(B839F197);
		base.Controls.Add(ED19963C);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fTienIchCheckTinsoft";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		ED19963C.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)B839F197).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
