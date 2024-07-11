using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fSuaBaiViet : Form
{
	private int C717841D;

	private IContainer icontainer_0 = null;

	private BunifuCards A43B9282;

	private Panel panel1;

	private BunifuDragControl E52ABE2C;

	private ToolTip toolTip_0;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private Label A3A94010;

	private ComboBox cbbChuDe;

	private BunifuCards FEB5B937;

	private Panel C69771AD;

	private Button button2;

	private PictureBox pictureBox1;

	private BunifuCustomLabel D6ADB195;

	private Label AB13E800;

	private DataGridView FB8613B0;

	private DataGridViewTextBoxColumn A184371E;

	private TextBox txtName;

	private Label E388B81F;

	private Label A118ADAC;

	private Button btnCancel;

	private Button button1;

	private Button A834E53D;

	private Button metroButton3;

	private Label label8;

	private RichTextBox B43A7736;

	public fSuaBaiViet(int int_0)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		method_0();
		C717841D = int_0;
		List<BaiViet> list = CommonSQL.GetListBaiVietByID(int_0.ToString());
		foreach (BaiViet item in list)
		{
			cbbChuDe.Text = item.D0B8AABE;
			txtName.Text = item.String_0;
			B43A7736.Text = item.F836E2B8;
			string[] array = item.String_1.Split('|');
			AB13E800.Text = "Ảnh (" + (array.Length - 1) + "):";
			item.String_2.Split('|');
			for (int i = 0; i < array.Length - 1; i++)
			{
				FB8613B0.Rows.Add(array[i]);
			}
		}
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

	private void BA140BA6(object sender, EventArgs e)
	{
	}

	private void E82F9B33(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (txtName.Text != "")
		{
			string text = "";
			if (FB8613B0.Rows.Count != 0)
			{
				for (int i = 0; i < FB8613B0.Rows.Count; i++)
				{
					text = text + FB8613B0.Rows[i].Cells[0].Value.ToString() + "|";
				}
			}
			string string_ = "";
			BaiViet e5349E = new BaiViet
			{
				String_0 = txtName.Text,
				String_1 = text,
				String_2 = string_,
				F836E2B8 = B43A7736.Text
			};
			CommonSQL.smethod_27(C717841D, e5349E);
			if (MessageBoxHelper.ShowMessages("Cập nhập thành công. Bạn có muốn thoát?") == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			MessageBoxHelper.Show("Chưa nhập tiêu đề");
		}
	}

	private void A834E53D_Click(object sender, EventArgs e)
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
				FB8613B0.Rows.Add(fileNames[i]);
			}
			AB13E800.Text = "Ảnh (" + FB8613B0.Rows.Count + "):";
		}
	}

	private void metroButton3_Click(object sender, EventArgs e)
	{
		foreach (DataGridViewRow selectedRow in FB8613B0.SelectedRows)
		{
			FB8613B0.Rows.RemoveAt(selectedRow.Index);
		}
		AB13E800.Text = "Ảnh (" + FB8613B0.Rows.Count + "):";
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FB8613B0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		Process.Start(FB8613B0.SelectedRows[0].Cells[0].Value.ToString());
	}

	private void cbbChuDe_Click(object sender, EventArgs e)
	{
	}

	private void fSuaBaiViet_FormClosed(object sender, FormClosedEventArgs e)
	{
		List<string> list_ = new List<string>();
		new fChonBaiViet(ref list_);
	}

	private void D1A73525(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
		Common.ShowForm(new fDanhSachChuDe());
		cbbChuDe.Items.Clear();
		method_0();
	}

	private void method_3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
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
		this.A43B9282 = new Bunifu.Framework.UI.BunifuCards();
		this.panel1 = new System.Windows.Forms.Panel();
		this.B43A7736 = new System.Windows.Forms.RichTextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.metroButton3 = new System.Windows.Forms.Button();
		this.A834E53D = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.AB13E800 = new System.Windows.Forms.Label();
		this.FB8613B0 = new System.Windows.Forms.DataGridView();
		this.A184371E = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.txtName = new System.Windows.Forms.TextBox();
		this.E388B81F = new System.Windows.Forms.Label();
		this.A118ADAC = new System.Windows.Forms.Label();
		this.A3A94010 = new System.Windows.Forms.Label();
		this.cbbChuDe = new System.Windows.Forms.ComboBox();
		this.FEB5B937 = new Bunifu.Framework.UI.BunifuCards();
		this.C69771AD = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.D6ADB195 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.E52ABE2C = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.FB8613B0).BeginInit();
		this.FEB5B937.SuspendLayout();
		this.C69771AD.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.contextMenuStrip1.SuspendLayout();
		base.SuspendLayout();
		this.A43B9282.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.A43B9282.BackColor = System.Drawing.Color.White;
		this.A43B9282.BorderRadius = 5;
		this.A43B9282.BottomSahddow = true;
		this.A43B9282.color = System.Drawing.Color.SaddleBrown;
		this.A43B9282.LeftSahddow = false;
		this.A43B9282.Location = new System.Drawing.Point(0, 0);
		this.A43B9282.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.A43B9282.Name = "bunifuCards1";
		this.A43B9282.RightSahddow = true;
		this.A43B9282.ShadowDepth = 20;
		this.A43B9282.Size = new System.Drawing.Size(46, 47);
		this.A43B9282.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.B43A7736);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.metroButton3);
		this.panel1.Controls.Add(this.A834E53D);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.button1);
		this.panel1.Controls.Add(this.AB13E800);
		this.panel1.Controls.Add(this.FB8613B0);
		this.panel1.Controls.Add(this.txtName);
		this.panel1.Controls.Add(this.E388B81F);
		this.panel1.Controls.Add(this.A118ADAC);
		this.panel1.Controls.Add(this.A3A94010);
		this.panel1.Controls.Add(this.cbbChuDe);
		this.panel1.Controls.Add(this.FEB5B937);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(375, 414);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.B43A7736.Location = new System.Drawing.Point(89, 184);
		this.B43A7736.Name = "txtConten";
		this.B43A7736.Size = new System.Drawing.Size(271, 149);
		this.B43A7736.TabIndex = 119;
		this.B43A7736.Text = "";
		this.B43A7736.WordWrap = false;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(86, 336);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(134, 16);
		this.label8.TabIndex = 117;
		this.label8.Text = "Spin nội dung {a|b|c}";
		this.metroButton3.BackgroundImage = Resources.C0B32A8A;
		this.metroButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton3.Location = new System.Drawing.Point(330, 148);
		this.metroButton3.Name = "metroButton3";
		this.metroButton3.Size = new System.Drawing.Size(30, 30);
		this.metroButton3.TabIndex = 113;
		this.metroButton3.Click += new System.EventHandler(metroButton3_Click);
		this.A834E53D.BackgroundImage = Resources.CA3D229B;
		this.A834E53D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A834E53D.Location = new System.Drawing.Point(330, 109);
		this.A834E53D.Name = "metroButton2";
		this.A834E53D.Size = new System.Drawing.Size(30, 30);
		this.A834E53D.TabIndex = 113;
		this.A834E53D.Click += new System.EventHandler(A834E53D_Click);
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(192, 370);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 103;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.button1.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Location = new System.Drawing.Point(85, 370);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(92, 29);
		this.button1.TabIndex = 102;
		this.button1.Text = "Cập nhật";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.AB13E800.AutoSize = true;
		this.AB13E800.Location = new System.Drawing.Point(11, 109);
		this.AB13E800.Name = "lblNanh";
		this.AB13E800.Size = new System.Drawing.Size(56, 16);
		this.AB13E800.TabIndex = 90;
		this.AB13E800.Text = "Ảnh (0):";
		this.AB13E800.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.FB8613B0.AllowUserToAddRows = false;
		this.FB8613B0.AllowUserToDeleteRows = false;
		this.FB8613B0.AllowUserToResizeColumns = false;
		this.FB8613B0.AllowUserToResizeRows = false;
		this.FB8613B0.BackgroundColor = System.Drawing.Color.White;
		this.FB8613B0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.FB8613B0.ColumnHeadersVisible = false;
		this.FB8613B0.Columns.AddRange(this.A184371E);
		this.FB8613B0.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FB8613B0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.FB8613B0.Location = new System.Drawing.Point(90, 109);
		this.FB8613B0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.FB8613B0.Name = "dgvPic";
		this.FB8613B0.RowHeadersVisible = false;
		this.FB8613B0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.FB8613B0.Size = new System.Drawing.Size(236, 69);
		this.FB8613B0.TabIndex = 83;
		this.FB8613B0.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(FB8613B0_CellDoubleClick);
		this.A184371E.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.A184371E.DataPropertyName = "Day";
		this.A184371E.FillWeight = 57.38708f;
		this.A184371E.HeaderText = "Đường dẫn";
		this.A184371E.Name = "dataGridViewTextBoxColumn4";
		this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtName.Location = new System.Drawing.Point(90, 78);
		this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(269, 23);
		this.txtName.TabIndex = 87;
		this.E388B81F.AutoSize = true;
		this.E388B81F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.E388B81F.ForeColor = System.Drawing.SystemColors.ControlText;
		this.E388B81F.Location = new System.Drawing.Point(11, 187);
		this.E388B81F.Name = "label2";
		this.E388B81F.Size = new System.Drawing.Size(63, 16);
		this.E388B81F.TabIndex = 86;
		this.E388B81F.Text = "Nội dung:";
		this.E388B81F.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.A118ADAC.AutoSize = true;
		this.A118ADAC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A118ADAC.ForeColor = System.Drawing.SystemColors.ControlText;
		this.A118ADAC.Location = new System.Drawing.Point(11, 81);
		this.A118ADAC.Name = "label5";
		this.A118ADAC.Size = new System.Drawing.Size(56, 16);
		this.A118ADAC.TabIndex = 85;
		this.A118ADAC.Text = "Tiêu đề:";
		this.A118ADAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.A3A94010.AutoSize = true;
		this.A3A94010.Location = new System.Drawing.Point(11, 50);
		this.A3A94010.Name = "label1";
		this.A3A94010.Size = new System.Drawing.Size(53, 16);
		this.A3A94010.TabIndex = 81;
		this.A3A94010.Text = "Chủ đề:";
		this.cbbChuDe.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbChuDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbChuDe.Enabled = false;
		this.cbbChuDe.FormattingEnabled = true;
		this.cbbChuDe.Location = new System.Drawing.Point(90, 47);
		this.cbbChuDe.Name = "cbbChuDe";
		this.cbbChuDe.Size = new System.Drawing.Size(269, 24);
		this.cbbChuDe.TabIndex = 80;
		this.cbbChuDe.SelectedIndexChanged += new System.EventHandler(D1A73525);
		this.cbbChuDe.Click += new System.EventHandler(cbbChuDe_Click);
		this.FEB5B937.BackColor = System.Drawing.Color.White;
		this.FEB5B937.BorderRadius = 0;
		this.FEB5B937.BottomSahddow = true;
		this.FEB5B937.color = System.Drawing.Color.SaddleBrown;
		this.FEB5B937.Controls.Add(this.C69771AD);
		this.FEB5B937.Dock = System.Windows.Forms.DockStyle.Top;
		this.FEB5B937.LeftSahddow = false;
		this.FEB5B937.Location = new System.Drawing.Point(0, 0);
		this.FEB5B937.Name = "bunifuCards2";
		this.FEB5B937.RightSahddow = true;
		this.FEB5B937.ShadowDepth = 20;
		this.FEB5B937.Size = new System.Drawing.Size(373, 37);
		this.FEB5B937.TabIndex = 43;
		this.C69771AD.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.C69771AD.BackColor = System.Drawing.Color.White;
		this.C69771AD.Controls.Add(this.button2);
		this.C69771AD.Controls.Add(this.pictureBox1);
		this.C69771AD.Controls.Add(this.D6ADB195);
		this.C69771AD.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.C69771AD.Location = new System.Drawing.Point(0, 3);
		this.C69771AD.Name = "pnlHeader";
		this.C69771AD.Size = new System.Drawing.Size(373, 31);
		this.C69771AD.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Resources.C400940B;
		this.button2.Location = new System.Drawing.Point(342, 1);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(30, 30);
		this.button2.TabIndex = 77;
		this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.D6ADB195.BackColor = System.Drawing.Color.Transparent;
		this.D6ADB195.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.D6ADB195.Dock = System.Windows.Forms.DockStyle.Fill;
		this.D6ADB195.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D6ADB195.ForeColor = System.Drawing.Color.Black;
		this.D6ADB195.Location = new System.Drawing.Point(0, 0);
		this.D6ADB195.Name = "bunifuCustomLabel1";
		this.D6ADB195.Size = new System.Drawing.Size(373, 31);
		this.D6ADB195.TabIndex = 12;
		this.D6ADB195.Text = "Sửa bình luận";
		this.D6ADB195.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2 });
		this.contextMenuStrip1.Name = "contextMenuStrip1";
		this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
		this.toolStripMenuItem_0.Name = "thêmMớiToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(152, 22);
		this.toolStripMenuItem_0.Text = "Thêm chủ đề";
		this.toolStripMenuItem_1.Name = "sửaToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(152, 22);
		this.toolStripMenuItem_1.Text = "Sửa tên chủ đề";
		this.toolStripMenuItem_2.Name = "xóaToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(152, 22);
		this.toolStripMenuItem_2.Text = "Xóa chủ đề";
		this.E52ABE2C.Fixed = true;
		this.E52ABE2C.Horizontal = true;
		this.E52ABE2C.TargetControl = this.D6ADB195;
		this.E52ABE2C.Vertical = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 200;
		this.toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(375, 414);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.A43B9282);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fSuaBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cấu hình chung";
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(fSuaBaiViet_FormClosed);
		base.Load += new System.EventHandler(BA140BA6);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.FB8613B0).EndInit();
		this.FEB5B937.ResumeLayout(false);
		this.C69771AD.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.contextMenuStrip1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
