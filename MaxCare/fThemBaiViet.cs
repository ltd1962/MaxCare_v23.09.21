using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fThemBaiViet : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel E0B89429;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem F40B49B7;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private Button metroButton1;

	private Label D53CD6B4;

	private ComboBox cbbChuDe;

	private BunifuCards DB85463C;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private BunifuCustomLabel DF0CE330;

	private DataGridView dgvPic;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private TextBox txtName;

	private Label E1135117;

	private Label label5;

	private Button btnCancel;

	private Button button1;

	private Label lblNanh;

	private Button AC0DB0AF;

	private Button metroButton2;

	private RichTextBox txtConten;

	private Label AA350822;

	public fThemBaiViet(int BF3BC233)
	{
		D025F891();
		Language.SetLanguage(this);
		method_0();
		cbbChuDe.SelectedIndex = BF3BC233;
	}

	private void method_0()
	{
		List<string> list = CommonSQL.smethod_21();
		for (int i = 0; i < list.Count; i++)
		{
			cbbChuDe.Items.Add(list[i]);
		}
		try
		{
			cbbChuDe.SelectedIndex = 0;
		}
		catch
		{
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		Close();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fDanhSachChuDe());
		cbbChuDe.Items.Clear();
		method_0();
	}

	private void FC34D314(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
		openFileDialog.FilterIndex = 0;
		openFileDialog.Multiselect = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			string[] fileNames = openFileDialog.FileNames;
			for (int i = 0; i < fileNames.Length; i++)
			{
				dgvPic.Rows.Add(fileNames[i]);
			}
			lblNanh.Text = "Ảnh (" + dgvPic.Rows.Count + "):";
		}
	}

	private void CB95BA06(object sender, EventArgs e)
	{
		foreach (DataGridViewRow selectedRow in dgvPic.SelectedRows)
		{
			dgvPic.Rows.RemoveAt(selectedRow.Index);
		}
		lblNanh.Text = "Ảnh (" + dgvPic.Rows.Count + "):";
	}

	private void E734CBB5(object sender, EventArgs e)
	{
		if (txtName.Text != "")
		{
			string text = "";
			if (dgvPic.Rows.Count != 0)
			{
				for (int i = 0; i < dgvPic.Rows.Count; i++)
				{
					text = text + dgvPic.Rows[i].Cells[0].Value.ToString() + "|";
				}
			}
			string string_ = "";
			string string_2 = cbbChuDe.SelectedItem.ToString();
			BaiViet class68_ = new BaiViet
			{
				String_0 = txtName.Text,
				String_1 = text,
				String_2 = string_,
				String_3 = DateTime.Now.ToString("dd/MM/yyyy"),
				F836E2B8 = txtConten.Text
			};
			CommonSQL.smethod_29(string_2, class68_);
			DialogResult dialogResult = MessageBoxHelper.ShowMessages("Thêm thành công. Bạn muốn có muốn đóng cửa sổ không?");
			if (dialogResult == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			MessageBoxHelper.Show("Chưa nhập tiêu đề!", 2);
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void dgvPic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		Process.Start(dgvPic.SelectedRows[0].Cells[0].Value.ToString());
	}

	private void cbbChuDe_Click(object sender, EventArgs e)
	{
	}

	private void E0B89429_Paint(object sender, PaintEventArgs e)
	{
	}

	private void E8143B15(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DF0CE330_Click(object sender, EventArgs e)
	{
	}

	private void A20BFBB5(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	protected override void Dispose(bool B100A1BE)
	{
		if (B100A1BE && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B100A1BE);
	}

	private void D025F891()
	{
		icontainer_0 = new Container();
		bunifuCards1 = new BunifuCards();
		E0B89429 = new Panel();
		txtConten = new RichTextBox();
		AC0DB0AF = new Button();
		metroButton2 = new Button();
		lblNanh = new Label();
		btnCancel = new Button();
		button1 = new Button();
		dgvPic = new DataGridView();
		dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		txtName = new TextBox();
		E1135117 = new Label();
		label5 = new Label();
		metroButton1 = new Button();
		D53CD6B4 = new Label();
		cbbChuDe = new ComboBox();
		DB85463C = new BunifuCards();
		pnlHeader = new Panel();
		button2 = new Button();
		pictureBox1 = new PictureBox();
		DF0CE330 = new BunifuCustomLabel();
		contextMenuStrip1 = new ContextMenuStrip(icontainer_0);
		F40B49B7 = new ToolStripMenuItem();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		toolTip_0 = new ToolTip(icontainer_0);
		AA350822 = new Label();
		E0B89429.SuspendLayout();
		((ISupportInitialize)dgvPic).BeginInit();
		DB85463C.SuspendLayout();
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
		bunifuCards1.Size = new Size(43, 47);
		bunifuCards1.TabIndex = 12;
		E0B89429.BackColor = Color.White;
		E0B89429.BorderStyle = BorderStyle.FixedSingle;
		E0B89429.Controls.Add(AA350822);
		E0B89429.Controls.Add(txtConten);
		E0B89429.Controls.Add(AC0DB0AF);
		E0B89429.Controls.Add(metroButton2);
		E0B89429.Controls.Add(lblNanh);
		E0B89429.Controls.Add(btnCancel);
		E0B89429.Controls.Add(button1);
		E0B89429.Controls.Add(dgvPic);
		E0B89429.Controls.Add(txtName);
		E0B89429.Controls.Add(E1135117);
		E0B89429.Controls.Add(label5);
		E0B89429.Controls.Add(metroButton1);
		E0B89429.Controls.Add(D53CD6B4);
		E0B89429.Controls.Add(cbbChuDe);
		E0B89429.Controls.Add(DB85463C);
		E0B89429.Dock = DockStyle.Fill;
		E0B89429.Location = new Point(0, 0);
		E0B89429.Margin = new Padding(3, 4, 3, 4);
		E0B89429.Name = "panel1";
		E0B89429.Size = new Size(372, 411);
		E0B89429.TabIndex = 37;
		E0B89429.Paint += E0B89429_Paint;
		txtConten.Location = new Point(76, 187);
		txtConten.Name = "txtConten";
		txtConten.Size = new Size(271, 149);
		txtConten.TabIndex = 120;
		txtConten.Text = "";
		txtConten.WordWrap = false;
		AC0DB0AF.BackgroundImage = Resources.C0B32A8A;
		AC0DB0AF.Cursor = Cursors.Hand;
		AC0DB0AF.Location = new Point(317, 149);
		AC0DB0AF.Name = "metroButton3";
		AC0DB0AF.Size = new Size(30, 30);
		AC0DB0AF.TabIndex = 114;
		AC0DB0AF.Click += CB95BA06;
		metroButton2.BackgroundImage = Resources.CA3D229B;
		metroButton2.Cursor = Cursors.Hand;
		metroButton2.Location = new Point(317, 110);
		metroButton2.Name = "metroButton2";
		metroButton2.Size = new Size(30, 30);
		metroButton2.TabIndex = 115;
		metroButton2.Click += FC34D314;
		lblNanh.AutoSize = true;
		lblNanh.Location = new Point(6, 110);
		lblNanh.Name = "lblNanh";
		lblNanh.Size = new Size(56, 16);
		lblNanh.TabIndex = 109;
		lblNanh.Text = "Ảnh (0):";
		lblNanh.TextAlign = ContentAlignment.MiddleCenter;
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(184, 369);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 108;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		button1.Anchor = AnchorStyles.Bottom;
		button1.BackColor = Color.FromArgb(53, 120, 229);
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Location = new Point(77, 369);
		button1.Name = "button1";
		button1.Size = new Size(92, 29);
		button1.TabIndex = 107;
		button1.Text = "Lưu";
		button1.UseVisualStyleBackColor = false;
		button1.Click += E734CBB5;
		dgvPic.AllowUserToAddRows = false;
		dgvPic.AllowUserToDeleteRows = false;
		dgvPic.AllowUserToResizeColumns = false;
		dgvPic.AllowUserToResizeRows = false;
		dgvPic.BackgroundColor = Color.White;
		dgvPic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvPic.ColumnHeadersVisible = false;
		dgvPic.Columns.AddRange(dataGridViewTextBoxColumn4);
		dgvPic.Cursor = Cursors.Hand;
		dgvPic.EditMode = DataGridViewEditMode.EditProgrammatically;
		dgvPic.Location = new Point(77, 109);
		dgvPic.Margin = new Padding(3, 4, 3, 4);
		dgvPic.Name = "dgvPic";
		dgvPic.RowHeadersVisible = false;
		dgvPic.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvPic.Size = new Size(234, 70);
		dgvPic.TabIndex = 83;
		dgvPic.CellDoubleClick += dgvPic_CellDoubleClick;
		dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn4.DataPropertyName = "Day";
		dataGridViewTextBoxColumn4.FillWeight = 57.38708f;
		dataGridViewTextBoxColumn4.HeaderText = "Đường dẫn";
		dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
		txtName.Cursor = Cursors.IBeam;
		txtName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtName.Location = new Point(77, 78);
		txtName.Margin = new Padding(3, 4, 3, 4);
		txtName.Name = "txtName";
		txtName.Size = new Size(270, 23);
		txtName.TabIndex = 87;
		E1135117.AutoSize = true;
		E1135117.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		E1135117.ForeColor = SystemColors.ControlText;
		E1135117.Location = new Point(6, 187);
		E1135117.Name = "label2";
		E1135117.Size = new Size(63, 16);
		E1135117.TabIndex = 86;
		E1135117.Text = "Nội dung:";
		E1135117.TextAlign = ContentAlignment.MiddleLeft;
		label5.AutoSize = true;
		label5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label5.ForeColor = SystemColors.ControlText;
		label5.Location = new Point(6, 81);
		label5.Name = "label5";
		label5.Size = new Size(56, 16);
		label5.TabIndex = 85;
		label5.Text = "Tiêu đề:";
		label5.TextAlign = ContentAlignment.MiddleLeft;
		metroButton1.Cursor = Cursors.Hand;
		metroButton1.Location = new Point(254, 46);
		metroButton1.Name = "metroButton1";
		metroButton1.Size = new Size(93, 25);
		metroButton1.TabIndex = 82;
		metroButton1.Text = "Quản lý chủ đề";
		metroButton1.Click += metroButton1_Click;
		D53CD6B4.AutoSize = true;
		D53CD6B4.Location = new Point(6, 50);
		D53CD6B4.Name = "label1";
		D53CD6B4.Size = new Size(53, 16);
		D53CD6B4.TabIndex = 81;
		D53CD6B4.Text = "Chủ đề:";
		cbbChuDe.Cursor = Cursors.Hand;
		cbbChuDe.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbChuDe.FormattingEnabled = true;
		cbbChuDe.Location = new Point(77, 47);
		cbbChuDe.Name = "cbbChuDe";
		cbbChuDe.Size = new Size(171, 24);
		cbbChuDe.TabIndex = 80;
		cbbChuDe.Click += cbbChuDe_Click;
		DB85463C.BackColor = Color.White;
		DB85463C.BorderRadius = 0;
		DB85463C.BottomSahddow = true;
		DB85463C.color = Color.SaddleBrown;
		DB85463C.Controls.Add(pnlHeader);
		DB85463C.Dock = DockStyle.Top;
		DB85463C.LeftSahddow = false;
		DB85463C.Location = new Point(0, 0);
		DB85463C.Name = "bunifuCards2";
		DB85463C.RightSahddow = true;
		DB85463C.ShadowDepth = 20;
		DB85463C.Size = new Size(370, 37);
		DB85463C.TabIndex = 43;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(DF0CE330);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(370, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button2.Cursor = Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = FlatStyle.Flat;
		button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button2.ForeColor = Color.White;
		button2.Image = Resources.C400940B;
		button2.Location = new Point(339, 1);
		button2.Name = "button2";
		button2.Size = new Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += button2_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		DF0CE330.BackColor = Color.Transparent;
		DF0CE330.Cursor = Cursors.SizeAll;
		DF0CE330.Dock = DockStyle.Fill;
		DF0CE330.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DF0CE330.ForeColor = Color.Black;
		DF0CE330.Location = new Point(0, 0);
		DF0CE330.Name = "bunifuCustomLabel1";
		DF0CE330.Size = new Size(370, 31);
		DF0CE330.TabIndex = 12;
		DF0CE330.Text = "Thêm bình luận";
		DF0CE330.TextAlign = ContentAlignment.MiddleCenter;
		DF0CE330.Click += DF0CE330_Click;
		contextMenuStrip1.Items.AddRange(new ToolStripItem[3] { F40B49B7, toolStripMenuItem_0, toolStripMenuItem_1 });
		contextMenuStrip1.Name = "contextMenuStrip1";
		contextMenuStrip1.Size = new Size(153, 70);
		F40B49B7.Name = "thêmMớiToolStripMenuItem";
		F40B49B7.Size = new Size(152, 22);
		F40B49B7.Text = "Thêm chủ đề";
		toolStripMenuItem_0.Name = "sửaToolStripMenuItem";
		toolStripMenuItem_0.Size = new Size(152, 22);
		toolStripMenuItem_0.Text = "Sửa tên chủ đề";
		toolStripMenuItem_1.Name = "xóaToolStripMenuItem";
		toolStripMenuItem_1.Size = new Size(152, 22);
		toolStripMenuItem_1.Text = "Xóa chủ đề";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DF0CE330;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		AA350822.AutoSize = true;
		AA350822.Location = new Point(74, 339);
		AA350822.Name = "label8";
		AA350822.Size = new Size(134, 16);
		AA350822.TabIndex = 121;
		AA350822.Text = "Spin nội dung {a|b|c}";
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(372, 411);
		base.Controls.Add(E0B89429);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fThemBaiViet";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		E0B89429.ResumeLayout(performLayout: false);
		E0B89429.PerformLayout();
		((ISupportInitialize)dgvPic).EndInit();
		DB85463C.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		contextMenuStrip1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
