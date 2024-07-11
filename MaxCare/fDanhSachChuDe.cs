using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fDanhSachChuDe : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl D2344780;

	private ToolTip toolTip_0;

	private GroupBox groupBox2;

	public DataGridView dgvChuDe;

	private Label B52663AC;

	private Label label7;

	private BunifuCards B4886D84;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox AC934797;

	private Button btnMinimize;

	private BunifuCustomLabel bunifuCustomLabel1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn B4137719;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem D632D72C;

	private ToolStripMenuItem C5A75999;

	private ToolStripMenuItem FE2A3638;

	private ToolStripMenuItem toolStripMenuItem_0;

	public fDanhSachChuDe()
	{
		A29EE812();
		Language.SetLanguage(this);
		method_0();
	}

	private void method_0()
	{
		List<string> list = CommonSQL.smethod_21();
		for (int i = 0; i < list.Count; i++)
		{
			dgvChuDe.Rows.Add(i + 1, list[i]);
		}
		B52663AC.Text = list.Count().ToString();
	}

	private void BF846B88(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void C120E720(object sender, EventArgs e)
	{
		Common.ShowForm(new fThemChuDe());
		dgvChuDe.Rows.Clear();
		method_0();
	}

	private void C5A75999_Click(object sender, EventArgs e)
	{
		string cBBA = dgvChuDe.SelectedRows[0].Cells[1].Value.ToString();
		Common.ShowForm(new fSuaChuDe(cBBA));
		dgvChuDe.Rows.Clear();
		method_0();
	}

	private void label7_Click(object sender, EventArgs e)
	{
	}

	private void A82435A4(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void A48CCD86(object sender, PopupEventArgs e)
	{
	}

	private void B81B2911(object sender, EventArgs e)
	{
		if (MessageBoxHelper.ShowMessages("Bạn có muốn xóa chủ đề này không?") == DialogResult.Yes)
		{
			string string_ = dgvChuDe.SelectedRows[0].Cells[1].Value.ToString();
			CommonSQL.smethod_24(string_);
			CommonSQL.smethod_25(string_);
			dgvChuDe.Rows.Clear();
			method_0();
		}
	}

	private void FC830DBB(object sender, EventArgs e)
	{
		dgvChuDe.Rows.Clear();
		method_0();
	}

	private void E8267792(object sender, EventArgs e)
	{
	}

	private void FFA6CA28(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void A504D114_Load(object sender, EventArgs e)
	{
	}

	private void groupBox2_Enter(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void A29EE812()
	{
		icontainer_0 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		bunifuCards1 = new BunifuCards();
		panel1 = new Panel();
		B4886D84 = new BunifuCards();
		pnlHeader = new Panel();
		button2 = new Button();
		AC934797 = new PictureBox();
		btnMinimize = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		groupBox2 = new GroupBox();
		B52663AC = new Label();
		label7 = new Label();
		dgvChuDe = new DataGridView();
		dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		B4137719 = new DataGridViewTextBoxColumn();
		contextMenuStrip1 = new ContextMenuStrip(icontainer_0);
		D632D72C = new ToolStripMenuItem();
		C5A75999 = new ToolStripMenuItem();
		FE2A3638 = new ToolStripMenuItem();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		D2344780 = new BunifuDragControl(icontainer_0);
		toolTip_0 = new ToolTip(icontainer_0);
		panel1.SuspendLayout();
		B4886D84.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)AC934797).BeginInit();
		groupBox2.SuspendLayout();
		((ISupportInitialize)dgvChuDe).BeginInit();
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
		bunifuCards1.Size = new Size(0, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(B4886D84);
		panel1.Controls.Add(groupBox2);
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Margin = new Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new Size(329, 317);
		panel1.TabIndex = 37;
		panel1.Paint += panel1_Paint;
		B4886D84.BackColor = Color.White;
		B4886D84.BorderRadius = 0;
		B4886D84.BottomSahddow = true;
		B4886D84.color = Color.SaddleBrown;
		B4886D84.Controls.Add(pnlHeader);
		B4886D84.Dock = DockStyle.Top;
		B4886D84.LeftSahddow = false;
		B4886D84.Location = new Point(0, 0);
		B4886D84.Name = "bunifuCards2";
		B4886D84.RightSahddow = true;
		B4886D84.ShadowDepth = 20;
		B4886D84.Size = new Size(327, 37);
		B4886D84.TabIndex = 43;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(AC934797);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(327, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button2.Cursor = Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = FlatStyle.Flat;
		button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button2.ForeColor = Color.White;
		button2.Image = Resources.Bitmap_66;
		button2.Location = new Point(296, 1);
		button2.Name = "button2";
		button2.Size = new Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += button2_Click;
		AC934797.Cursor = Cursors.Default;
		AC934797.Image = Resources.Bitmap_4;
		AC934797.Location = new Point(3, 2);
		AC934797.Name = "pictureBox1";
		AC934797.Size = new Size(34, 27);
		AC934797.SizeMode = PictureBoxSizeMode.Zoom;
		AC934797.TabIndex = 76;
		AC934797.TabStop = false;
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
		bunifuCustomLabel1.Size = new Size(327, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Danh sách chủ đề";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		groupBox2.BackColor = Color.White;
		groupBox2.Controls.Add(B52663AC);
		groupBox2.Controls.Add(label7);
		groupBox2.Controls.Add(dgvChuDe);
		groupBox2.Location = new Point(6, 40);
		groupBox2.Margin = new Padding(3, 5, 3, 5);
		groupBox2.Name = "groupBox2";
		groupBox2.Padding = new Padding(3, 5, 3, 5);
		groupBox2.Size = new Size(311, 269);
		groupBox2.TabIndex = 41;
		groupBox2.TabStop = false;
		groupBox2.Text = "Danh sách chủ đề";
		groupBox2.Enter += groupBox2_Enter;
		B52663AC.AutoSize = true;
		B52663AC.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		B52663AC.ForeColor = Color.Blue;
		B52663AC.Location = new Point(273, 248);
		B52663AC.Name = "lblCountChuDe";
		B52663AC.Size = new Size(16, 16);
		B52663AC.TabIndex = 78;
		B52663AC.Text = "0";
		B52663AC.Click += A82435A4;
		label7.AutoSize = true;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		label7.Location = new Point(231, 248);
		label7.Name = "label7";
		label7.Size = new Size(44, 16);
		label7.TabIndex = 79;
		label7.Text = "Tổng:";
		label7.Click += label7_Click;
		dgvChuDe.AllowUserToAddRows = false;
		dgvChuDe.AllowUserToDeleteRows = false;
		dgvChuDe.AllowUserToResizeRows = false;
		dgvChuDe.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		dgvChuDe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dgvChuDe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvChuDe.Columns.AddRange(dataGridViewTextBoxColumn1, B4137719);
		dgvChuDe.ContextMenuStrip = contextMenuStrip1;
		dgvChuDe.EditMode = DataGridViewEditMode.EditProgrammatically;
		dgvChuDe.Location = new Point(9, 23);
		dgvChuDe.Margin = new Padding(3, 4, 3, 4);
		dgvChuDe.MultiSelect = false;
		dgvChuDe.Name = "dgvChuDe";
		dgvChuDe.RowHeadersVisible = false;
		dgvChuDe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvChuDe.Size = new Size(293, 221);
		dgvChuDe.TabIndex = 76;
		dgvChuDe.CellContentClick += FFA6CA28;
		dgvChuDe.Click += E8267792;
		dataGridViewTextBoxColumn1.HeaderText = "STT";
		dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
		dataGridViewTextBoxColumn1.Width = 35;
		B4137719.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		B4137719.HeaderText = "Tên chủ đề";
		B4137719.Name = "dataGridViewTextBoxColumn4";
		contextMenuStrip1.Items.AddRange(new ToolStripItem[4] { D632D72C, C5A75999, FE2A3638, toolStripMenuItem_0 });
		contextMenuStrip1.Name = "contextMenuStrip1";
		contextMenuStrip1.Size = new Size(179, 92);
		D632D72C.Name = "thêmMớiToolStripMenuItem";
		D632D72C.Size = new Size(178, 22);
		D632D72C.Text = "Thêm chủ đề";
		D632D72C.Click += C120E720;
		C5A75999.Name = "sửaToolStripMenuItem";
		C5A75999.Size = new Size(178, 22);
		C5A75999.Text = "Sửa tên chủ đề";
		C5A75999.Click += C5A75999_Click;
		FE2A3638.Name = "xóaToolStripMenuItem";
		FE2A3638.Size = new Size(178, 22);
		FE2A3638.Text = "Xóa chủ đề";
		FE2A3638.Click += B81B2911;
		toolStripMenuItem_0.Name = "tảiLạiToolStripMenuItem";
		toolStripMenuItem_0.Size = new Size(178, 22);
		toolStripMenuItem_0.Text = "Làm mới danh sách";
		toolStripMenuItem_0.Click += FC830DBB;
		D2344780.Fixed = true;
		D2344780.Horizontal = true;
		D2344780.TargetControl = bunifuCustomLabel1;
		D2344780.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		toolTip_0.Popup += A48CCD86;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(329, 317);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fDanhSachChuDe";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Cấu hình chung";
		base.Load += A504D114_Load;
		panel1.ResumeLayout(performLayout: false);
		B4886D84.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)AC934797).EndInit();
		groupBox2.ResumeLayout(performLayout: false);
		groupBox2.PerformLayout();
		((ISupportInitialize)dgvChuDe).EndInit();
		contextMenuStrip1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
