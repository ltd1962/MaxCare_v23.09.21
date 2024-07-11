using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapDuLieu2 : Form
{
	private string string_0 = "";

	private Random random_0 = new Random();

	private bool bool_0 = false;

	private IContainer F30A9A89 = null;

	private BunifuCards bunifuCards1;

	private Panel D789A332;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private Button E1ABBCB2;

	private BunifuCustomLabel BE13A4A7;

	private Button btnSave;

	private TextBox E1269897;

	private GroupBox F703989B;

	private GroupBox groupBox2;

	public DataGridView AC81DA80;

	private Button A495B28B;

	private DataGridViewTextBoxColumn CE2E5A2D;

	private DataGridViewTextBoxColumn cName;

	private DataGridViewButtonColumn cChiTiet;

	private DataGridViewButtonColumn cSua;

	private DataGridViewButtonColumn A183032C;

	private Button btnHuy;

	public fNhapDuLieu2(string string_1, string string_2)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		string_0 = string_1;
		BE13A4A7.Text = string_2;
	}

	private void method_0()
	{
		Language.smethod_0(BE13A4A7);
		Language.smethod_0(F703989B);
		Language.smethod_0(groupBox2);
		foreach (DataGridViewColumn column in AC81DA80.Columns)
		{
			Language.smethod_1(column);
		}
		Language.smethod_0(A495B28B);
		Language.smethod_0(btnSave);
		Language.smethod_0(btnHuy);
	}

	private void B798A035(object sender, EventArgs e)
	{
		Common.CreateFolder(string_0);
		method_2(string_0);
	}

	private void method_1(int int_0)
	{
		E1269897.Lines = File.ReadAllLines(DatagridviewHelper.GetStatusDataGridView(AC81DA80, int_0, "cName"));
	}

	private void method_2(string BB815F07)
	{
		int num = -1;
		switch (AC81DA80.RowCount)
		{
		default:
			num = AC81DA80.SelectedRows[0].Index;
			break;
		case 1:
			num = 0;
			break;
		case 0:
			break;
		}
		AC81DA80.Rows.Clear();
		List<string> list = Common.GetFiles(BB815F07);
		for (int i = 0; i < list.Count; i++)
		{
			AC81DA80.Rows.Add(i + 1, list[i], Language.GetValue("Chi tiê\u0301t"), Language.GetValue("Sư\u0309a"), Language.GetValue("Xo\u0301a"));
		}
		if (num == -1 && AC81DA80.RowCount > 0)
		{
			num = 0;
		}
		else if (num + 1 > AC81DA80.RowCount)
		{
			num = AC81DA80.RowCount - 1;
		}
		if (num == -1)
		{
			E1269897.Text = "";
			return;
		}
		Common.ClearSelectedOnDatagridview(AC81DA80);
		AC81DA80.Rows[num].Selected = true;
		method_1(num);
	}

	private void D789A332_Paint(object sender, PaintEventArgs e)
	{
	}

	private void C9990714(object sender, EventArgs e)
	{
		Close();
	}

	private void FEB29336(int int_0)
	{
		if (int_0 == 1)
		{
			AC81DA80.Enabled = false;
			A495B28B.Enabled = false;
			btnSave.Enabled = true;
			btnHuy.Enabled = true;
			E1269897.ReadOnly = false;
			E1269897.Focus();
		}
		else
		{
			AC81DA80.Enabled = true;
			A495B28B.Enabled = true;
			btnSave.Enabled = false;
			btnHuy.Enabled = false;
			E1269897.ReadOnly = true;
		}
	}

	private void A495B28B_Click(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			string text2;
			do
			{
				text2 = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_") + Common.CreateRandomString(3) + ".txt";
			}
			while (File.Exists(text2));
			text = string_0 + "\\" + text2;
			Common.CreateFile(text);
			E1269897.Lines = File.ReadAllLines(text);
			AC81DA80.Rows.Add(AC81DA80.RowCount + 1, text, Language.GetValue("Chi tiê\u0301t"), Language.GetValue("Sư\u0309a"), Language.GetValue("Xo\u0301a"));
			Common.ClearSelectedOnDatagridview(AC81DA80);
			AC81DA80.Rows[AC81DA80.RowCount - 1].Selected = true;
			FEB29336(1);
			bool_0 = true;
		}
		catch
		{
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void E1269897_TextChanged(object sender, EventArgs e)
	{
	}

	private void CCA7D99A(object sender, EventArgs e)
	{
	}

	private void AC81DA80_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
	{
		string name = AC81DA80.Columns[e.ColumnIndex].Name;
		if (name != "cChiTiet" && name != "cSua" && name != "cXoa")
		{
			AC81DA80.Cursor = Cursors.Default;
		}
		else if (e.RowIndex < AC81DA80.RowCount)
		{
			AC81DA80.Cursor = Cursors.Hand;
		}
	}

	private void AC81DA80_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (!(dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) || e.RowIndex < 0)
		{
			return;
		}
		switch (dataGridView.Columns[e.ColumnIndex].Name)
		{
		case "cXoa":
			if (MessageBoxHelper.ShowMessages("Bạn có muốn xóa?") == DialogResult.Yes)
			{
				File.Delete(DatagridviewHelper.GetStatusDataGridView(AC81DA80, e.RowIndex, "cName"));
				method_2(string_0);
			}
			break;
		case "cSua":
			E1269897.Lines = File.ReadAllLines(DatagridviewHelper.GetStatusDataGridView(AC81DA80, e.RowIndex, "cName"));
			bool_0 = false;
			FEB29336(1);
			break;
		case "cChiTiet":
			method_1(e.RowIndex);
			break;
		}
	}

	private void D186653A(object sender, EventArgs e)
	{
		try
		{
			string path = AC81DA80.SelectedRows[0].Cells["cName"].Value.ToString();
			Common.CreateFile(path);
			if (E1269897.Text.Trim() == "")
			{
				MessageBoxHelper.Show("Vui lòng nhập nội dung cần lưu!", 3);
			}
			else if (MessageBoxHelper.ShowMessages("Bạn có muốn lưu lại?") == DialogResult.Yes)
			{
				File.WriteAllLines(path, E1269897.Lines);
				MessageBoxHelper.Show("Lưu thành công!");
				FEB29336(2);
			}
		}
		catch
		{
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void btnHuy_Click(object sender, EventArgs e)
	{
		try
		{
			string path = AC81DA80.SelectedRows[0].Cells["cName"].Value.ToString();
			Common.CreateFile(path);
			if (MessageBoxHelper.ShowMessages("Bạn có muốn hủy?") == DialogResult.Yes)
			{
				if (bool_0)
				{
					File.Delete(path);
				}
				FEB29336(2);
				method_2(string_0);
			}
		}
		catch
		{
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && F30A9A89 != null)
		{
			F30A9A89.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.F30A9A89 = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.D789A332 = new System.Windows.Forms.Panel();
		this.F703989B = new System.Windows.Forms.GroupBox();
		this.AC81DA80 = new System.Windows.Forms.DataGridView();
		this.CE2E5A2D = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
		this.cSua = new System.Windows.Forms.DataGridViewButtonColumn();
		this.A183032C = new System.Windows.Forms.DataGridViewButtonColumn();
		this.A495B28B = new System.Windows.Forms.Button();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.E1269897 = new System.Windows.Forms.TextBox();
		this.btnSave = new System.Windows.Forms.Button();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.E1ABBCB2 = new System.Windows.Forms.Button();
		this.BE13A4A7 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.F30A9A89);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.F30A9A89);
		this.btnHuy = new System.Windows.Forms.Button();
		this.D789A332.SuspendLayout();
		this.F703989B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.AC81DA80).BeginInit();
		this.groupBox2.SuspendLayout();
		this.bunifuCards2.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 5;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(425, 47);
		this.bunifuCards1.TabIndex = 12;
		this.D789A332.BackColor = System.Drawing.Color.White;
		this.D789A332.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.D789A332.Controls.Add(this.F703989B);
		this.D789A332.Controls.Add(this.groupBox2);
		this.D789A332.Controls.Add(this.bunifuCards2);
		this.D789A332.Dock = System.Windows.Forms.DockStyle.Fill;
		this.D789A332.Location = new System.Drawing.Point(0, 0);
		this.D789A332.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.D789A332.Name = "panel1";
		this.D789A332.Size = new System.Drawing.Size(754, 388);
		this.D789A332.TabIndex = 37;
		this.D789A332.Paint += new System.Windows.Forms.PaintEventHandler(D789A332_Paint);
		this.F703989B.Controls.Add(this.AC81DA80);
		this.F703989B.Controls.Add(this.A495B28B);
		this.F703989B.Location = new System.Drawing.Point(3, 43);
		this.F703989B.Name = "groupBox1";
		this.F703989B.Size = new System.Drawing.Size(284, 339);
		this.F703989B.TabIndex = 50;
		this.F703989B.TabStop = false;
		this.F703989B.Text = " Danh sa\u0301ch nô\u0323i dung";
		this.AC81DA80.AllowUserToAddRows = false;
		this.AC81DA80.AllowUserToDeleteRows = false;
		this.AC81DA80.AllowUserToResizeRows = false;
		this.AC81DA80.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.AC81DA80.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.AC81DA80.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.AC81DA80.Columns.AddRange(this.CE2E5A2D, this.cName, this.cChiTiet, this.cSua, this.A183032C);
		this.AC81DA80.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.AC81DA80.Location = new System.Drawing.Point(6, 22);
		this.AC81DA80.Name = "dtgvDanhSach";
		this.AC81DA80.RowHeadersVisible = false;
		this.AC81DA80.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.AC81DA80.Size = new System.Drawing.Size(272, 277);
		this.AC81DA80.TabIndex = 76;
		this.AC81DA80.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(AC81DA80_CellContentClick);
		this.AC81DA80.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(AC81DA80_CellMouseEnter);
		this.AC81DA80.MouseHover += new System.EventHandler(CCA7D99A);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.CE2E5A2D.DefaultCellStyle = dataGridViewCellStyle2;
		this.CE2E5A2D.HeaderText = "STT";
		this.CE2E5A2D.Name = "cSTT";
		this.CE2E5A2D.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.CE2E5A2D.Width = 40;
		this.cName.HeaderText = "Tên file";
		this.cName.Name = "cName";
		this.cName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cName.Visible = false;
		this.cChiTiet.HeaderText = "Chi tiê\u0301t";
		this.cChiTiet.Name = "cChiTiet";
		this.cChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.cChiTiet.Width = 80;
		this.cSua.HeaderText = "Sư\u0309a";
		this.cSua.Name = "cSua";
		this.cSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.cSua.Width = 71;
		this.A183032C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.A183032C.HeaderText = "Xo\u0301a";
		this.A183032C.Name = "cXoa";
		this.A183032C.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.A495B28B.BackColor = System.Drawing.Color.Green;
		this.A495B28B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A495B28B.FlatAppearance.BorderSize = 0;
		this.A495B28B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A495B28B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A495B28B.ForeColor = System.Drawing.Color.White;
		this.A495B28B.Location = new System.Drawing.Point(186, 303);
		this.A495B28B.Name = "btnAdd";
		this.A495B28B.Size = new System.Drawing.Size(92, 29);
		this.A495B28B.TabIndex = 45;
		this.A495B28B.Text = "Thêm";
		this.A495B28B.UseVisualStyleBackColor = false;
		this.A495B28B.Click += new System.EventHandler(A495B28B_Click);
		this.groupBox2.Controls.Add(this.E1269897);
		this.groupBox2.Controls.Add(this.btnHuy);
		this.groupBox2.Controls.Add(this.btnSave);
		this.groupBox2.Location = new System.Drawing.Point(293, 43);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(455, 339);
		this.groupBox2.TabIndex = 50;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Chi tiê\u0301t";
		this.E1269897.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.E1269897.Location = new System.Drawing.Point(5, 22);
		this.E1269897.Multiline = true;
		this.E1269897.Name = "txtContent";
		this.E1269897.ReadOnly = true;
		this.E1269897.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.E1269897.Size = new System.Drawing.Size(444, 277);
		this.E1269897.TabIndex = 48;
		this.E1269897.WordWrap = false;
		this.E1269897.TextChanged += new System.EventHandler(E1269897_TextChanged);
		this.btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnSave.Enabled = false;
		this.btnSave.FlatAppearance.BorderSize = 0;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSave.ForeColor = System.Drawing.Color.White;
		this.btnSave.Location = new System.Drawing.Point(256, 304);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(92, 29);
		this.btnSave.TabIndex = 45;
		this.btnSave.Text = "Lưu";
		this.btnSave.UseVisualStyleBackColor = false;
		this.btnSave.Click += new System.EventHandler(D186653A);
		this.bunifuCards2.BackColor = System.Drawing.Color.White;
		this.bunifuCards2.BorderRadius = 0;
		this.bunifuCards2.BottomSahddow = true;
		this.bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards2.Controls.Add(this.pnlHeader);
		this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards2.LeftSahddow = false;
		this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards2.Name = "bunifuCards2";
		this.bunifuCards2.RightSahddow = true;
		this.bunifuCards2.ShadowDepth = 20;
		this.bunifuCards2.Size = new System.Drawing.Size(752, 37);
		this.bunifuCards2.TabIndex = 43;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button2);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.E1ABBCB2);
		this.pnlHeader.Controls.Add(this.BE13A4A7);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(752, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Resources.C400940B;
		this.button2.Location = new System.Drawing.Point(721, 1);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(30, 30);
		this.button2.TabIndex = 77;
		this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(C9990714);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.E1ABBCB2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E1ABBCB2.FlatAppearance.BorderSize = 0;
		this.E1ABBCB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E1ABBCB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.E1ABBCB2.ForeColor = System.Drawing.Color.White;
		this.E1ABBCB2.Location = new System.Drawing.Point(899, 1);
		this.E1ABBCB2.Name = "btnMinimize";
		this.E1ABBCB2.Size = new System.Drawing.Size(30, 30);
		this.E1ABBCB2.TabIndex = 9;
		this.E1ABBCB2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.E1ABBCB2.UseVisualStyleBackColor = true;
		this.BE13A4A7.BackColor = System.Drawing.Color.Transparent;
		this.BE13A4A7.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.BE13A4A7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.BE13A4A7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BE13A4A7.ForeColor = System.Drawing.Color.Black;
		this.BE13A4A7.Location = new System.Drawing.Point(0, 0);
		this.BE13A4A7.Name = "lblTitle";
		this.BE13A4A7.Size = new System.Drawing.Size(752, 31);
		this.BE13A4A7.TabIndex = 12;
		this.BE13A4A7.Text = "Nhập nội dung comment";
		this.BE13A4A7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.BE13A4A7;
		this.bunifuDragControl_0.Vertical = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 200;
		this.toolTip_0.ReshowDelay = 40;
		this.btnHuy.BackColor = System.Drawing.Color.FromArgb(128, 64, 0);
		this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnHuy.Enabled = false;
		this.btnHuy.FlatAppearance.BorderSize = 0;
		this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnHuy.ForeColor = System.Drawing.Color.White;
		this.btnHuy.Location = new System.Drawing.Point(357, 304);
		this.btnHuy.Name = "btnHuy";
		this.btnHuy.Size = new System.Drawing.Size(92, 29);
		this.btnHuy.TabIndex = 45;
		this.btnHuy.Text = "Hủy";
		this.btnHuy.UseVisualStyleBackColor = false;
		this.btnHuy.Click += new System.EventHandler(btnHuy_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(754, 388);
		base.Controls.Add(this.D789A332);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fNhapDuLieu2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(B798A035);
		this.D789A332.ResumeLayout(false);
		this.F703989B.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.AC81DA80).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}
}
