using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHuongDanRandom : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl AA8D3124;

	private ToolTip toolTip_0;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel bunifuCustomLabel1;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem ECB8C295;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private DataGridView F0AC2F9F;

	private DataGridViewTextBoxColumn CC9C1B0E;

	private DataGridViewTextBoxColumn cTuKhoa;

	private DataGridViewImageColumn BBA8F02A;

	public fHuongDanRandom()
	{
		A4A09424();
		Language.SetLanguage(this);
		C39B47A7();
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		foreach (DataGridViewColumn column in F0AC2F9F.Columns)
		{
			Language.smethod_1(column);
		}
	}

	private void C39B47A7()
	{
		new Random();
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[r1]", Resources.Bitmap_39);
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[r2]", Resources.Bitmap_40);
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[r3]", Resources.Bitmap_41);
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[r4]", Resources.Bitmap_42);
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[r5]", Resources.Bitmap_43);
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[r6]", Resources.Bitmap_44);
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[r7]", Resources.Bitmap_45);
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[r8]", Resources.C6AEBBA6);
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[d]", Resources.Bitmap_46);
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[t]", Resources.A1361515);
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[n*]", Resources.Bitmap_47);
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[s*]", Resources.Bitmap_48);
		F0AC2F9F.Rows.Add(F0AC2F9F.RowCount + 1, "[q***]", Resources.Bitmap_49);
	}

	private void fHuongDanRandom_Load(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void C298F4A9(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool D434E63C)
	{
		if (D434E63C && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D434E63C);
	}

	private void A4A09424()
	{
		icontainer_0 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		bunifuCards1 = new BunifuCards();
		panel1 = new Panel();
		F0AC2F9F = new DataGridView();
		CC9C1B0E = new DataGridViewTextBoxColumn();
		cTuKhoa = new DataGridViewTextBoxColumn();
		BBA8F02A = new DataGridViewImageColumn();
		bunifuCards2 = new BunifuCards();
		pnlHeader = new Panel();
		button2 = new Button();
		pictureBox1 = new PictureBox();
		btnMinimize = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		contextMenuStrip1 = new ContextMenuStrip(icontainer_0);
		ECB8C295 = new ToolStripMenuItem();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		AA8D3124 = new BunifuDragControl(icontainer_0);
		toolTip_0 = new ToolTip(icontainer_0);
		panel1.SuspendLayout();
		((ISupportInitialize)F0AC2F9F).BeginInit();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		contextMenuStrip1.SuspendLayout();
		SuspendLayout();
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Margin = new Padding(3, 4, 3, 4);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(243, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(F0AC2F9F);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Margin = new Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new Size(572, 503);
		panel1.TabIndex = 37;
		panel1.Paint += panel1_Paint;
		F0AC2F9F.AllowUserToAddRows = false;
		F0AC2F9F.AllowUserToDeleteRows = false;
		F0AC2F9F.AllowUserToResizeRows = false;
		F0AC2F9F.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
		F0AC2F9F.BackgroundColor = Color.White;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		F0AC2F9F.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		F0AC2F9F.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		F0AC2F9F.Columns.AddRange(CC9C1B0E, cTuKhoa, BBA8F02A);
		F0AC2F9F.Location = new Point(11, 43);
		F0AC2F9F.Name = "dgv";
		F0AC2F9F.ReadOnly = true;
		F0AC2F9F.RowHeadersVisible = false;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.ForeColor = Color.Black;
		dataGridViewCellStyle2.SelectionBackColor = Color.White;
		dataGridViewCellStyle2.SelectionForeColor = Color.Black;
		F0AC2F9F.RowsDefaultCellStyle = dataGridViewCellStyle2;
		F0AC2F9F.RowTemplate.Resizable = DataGridViewTriState.True;
		F0AC2F9F.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		F0AC2F9F.Size = new Size(547, 447);
		F0AC2F9F.TabIndex = 75;
		CC9C1B0E.HeaderText = "STT";
		CC9C1B0E.Name = "cSTT";
		CC9C1B0E.ReadOnly = true;
		CC9C1B0E.SortMode = DataGridViewColumnSortMode.NotSortable;
		CC9C1B0E.Width = 40;
		cTuKhoa.HeaderText = "Từ khóa";
		cTuKhoa.Name = "cTuKhoa";
		cTuKhoa.ReadOnly = true;
		cTuKhoa.Width = 80;
		BBA8F02A.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		BBA8F02A.HeaderText = "Nội dung random";
		BBA8F02A.Name = "cNoiDung";
		BBA8F02A.ReadOnly = true;
		BBA8F02A.Resizable = DataGridViewTriState.True;
		BBA8F02A.SortMode = DataGridViewColumnSortMode.Automatic;
		bunifuCards2.BackColor = Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new Size(570, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(570, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button2.Cursor = Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = FlatStyle.Flat;
		button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button2.ForeColor = Color.White;
		button2.Image = Resources.C400940B;
		button2.Location = new Point(539, 1);
		button2.Name = "button2";
		button2.Size = new Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += C298F4A9;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Location = new Point(899, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(570, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Hướng dẫn random nội dung";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		contextMenuStrip1.Items.AddRange(new ToolStripItem[3] { ECB8C295, toolStripMenuItem_0, toolStripMenuItem_1 });
		contextMenuStrip1.Name = "contextMenuStrip1";
		contextMenuStrip1.Size = new Size(153, 70);
		ECB8C295.Name = "thêmMớiToolStripMenuItem";
		ECB8C295.Size = new Size(152, 22);
		ECB8C295.Text = "Thêm chủ đề";
		toolStripMenuItem_0.Name = "sửaToolStripMenuItem";
		toolStripMenuItem_0.Size = new Size(152, 22);
		toolStripMenuItem_0.Text = "Sửa tên chủ đề";
		toolStripMenuItem_1.Name = "xóaToolStripMenuItem";
		toolStripMenuItem_1.Size = new Size(152, 22);
		toolStripMenuItem_1.Text = "Xóa chủ đề";
		AA8D3124.Fixed = true;
		AA8D3124.Horizontal = true;
		AA8D3124.TargetControl = bunifuCustomLabel1;
		AA8D3124.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(572, 503);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHuongDanRandom";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Cấu hình chung";
		base.Load += fHuongDanRandom_Load;
		panel1.ResumeLayout(performLayout: false);
		((ISupportInitialize)F0AC2F9F).EndInit();
		bunifuCards2.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		contextMenuStrip1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
