using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChiTietBaiViet : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards EEAFF4BE;

	private Panel ED21EBAF;

	private BunifuDragControl CC0CD63D;

	private ToolTip toolTip_0;

	private BunifuCards bunifuCards2;

	private Panel BC1CD134;

	private Button BFBD2C12;

	private PictureBox CB86F1A6;

	private Button B1A0471D;

	private BunifuCustomLabel bunifuCustomLabel1;

	private ContextMenuStrip CC9B2F9E;

	private ToolStripMenuItem A291C595;

	private ToolStripMenuItem C3110C11;

	private ToolStripMenuItem toolStripMenuItem_0;

	private Label B03461A0;

	private DataGridView EA0CEF25;

	private DataGridViewTextBoxColumn C98E2AB6;

	private TextBox txtChuDe;

	private Label B21D148A;

	private TextBox A593D7AE;

	private Label label4;

	private Label label2;

	private TextBox E3B5AE32;

	public fChiTietBaiViet(int int_0)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		List<BaiViet> list = CommonSQL.GetListBaiVietByID(int_0.ToString());
		foreach (BaiViet item in list)
		{
			txtChuDe.Text = item.D0B8AABE;
			E3B5AE32.Text = item.String_0;
			A593D7AE.Text = item.F836E2B8;
			string[] array = item.String_1.Split('|');
			B03461A0.Text = "Ảnh (" + (array.Length - 1) + "):";
			item.String_2.Split('|');
			for (int i = 0; i < array.Length - 1; i++)
			{
				EA0CEF25.Rows.Add(array[i]);
			}
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		Close();
	}

	private void D0AF9187_Load(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void D31CEC82(object sender, PaintEventArgs e)
	{
	}

	private void BFBD2C12_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void F5179428(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			Process.Start(EA0CEF25.SelectedRows[0].Cells[0].Value.ToString());
		}
		catch (Exception)
		{
			MessageBoxHelper.Show("Link ảnh không tồn tại!");
		}
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void D006F195(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void EA0CEF25_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		this.EEAFF4BE = new Bunifu.Framework.UI.BunifuCards();
		this.ED21EBAF = new System.Windows.Forms.Panel();
		this.B03461A0 = new System.Windows.Forms.Label();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.BC1CD134 = new System.Windows.Forms.Panel();
		this.BFBD2C12 = new System.Windows.Forms.Button();
		this.CB86F1A6 = new System.Windows.Forms.PictureBox();
		this.B1A0471D = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.EA0CEF25 = new System.Windows.Forms.DataGridView();
		this.C98E2AB6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.txtChuDe = new System.Windows.Forms.TextBox();
		this.B21D148A = new System.Windows.Forms.Label();
		this.A593D7AE = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.E3B5AE32 = new System.Windows.Forms.TextBox();
		this.CC9B2F9E = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.A291C595 = new System.Windows.Forms.ToolStripMenuItem();
		this.C3110C11 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.CC0CD63D = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.ED21EBAF.SuspendLayout();
		this.bunifuCards2.SuspendLayout();
		this.BC1CD134.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CB86F1A6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.EA0CEF25).BeginInit();
		this.CC9B2F9E.SuspendLayout();
		base.SuspendLayout();
		this.EEAFF4BE.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.EEAFF4BE.BackColor = System.Drawing.Color.White;
		this.EEAFF4BE.BorderRadius = 5;
		this.EEAFF4BE.BottomSahddow = true;
		this.EEAFF4BE.color = System.Drawing.Color.SaddleBrown;
		this.EEAFF4BE.LeftSahddow = false;
		this.EEAFF4BE.Location = new System.Drawing.Point(0, 0);
		this.EEAFF4BE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.EEAFF4BE.Name = "bunifuCards1";
		this.EEAFF4BE.RightSahddow = true;
		this.EEAFF4BE.ShadowDepth = 20;
		this.EEAFF4BE.Size = new System.Drawing.Size(36, 47);
		this.EEAFF4BE.TabIndex = 12;
		this.ED21EBAF.BackColor = System.Drawing.Color.White;
		this.ED21EBAF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ED21EBAF.Controls.Add(this.B03461A0);
		this.ED21EBAF.Controls.Add(this.bunifuCards2);
		this.ED21EBAF.Controls.Add(this.EA0CEF25);
		this.ED21EBAF.Controls.Add(this.txtChuDe);
		this.ED21EBAF.Controls.Add(this.B21D148A);
		this.ED21EBAF.Controls.Add(this.A593D7AE);
		this.ED21EBAF.Controls.Add(this.label4);
		this.ED21EBAF.Controls.Add(this.label2);
		this.ED21EBAF.Controls.Add(this.E3B5AE32);
		this.ED21EBAF.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ED21EBAF.Location = new System.Drawing.Point(0, 0);
		this.ED21EBAF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.ED21EBAF.Name = "panel1";
		this.ED21EBAF.Size = new System.Drawing.Size(365, 342);
		this.ED21EBAF.TabIndex = 37;
		this.ED21EBAF.Paint += new System.Windows.Forms.PaintEventHandler(D31CEC82);
		this.B03461A0.AutoSize = true;
		this.B03461A0.Location = new System.Drawing.Point(6, 100);
		this.B03461A0.Name = "lblNanh";
		this.B03461A0.Size = new System.Drawing.Size(56, 16);
		this.B03461A0.TabIndex = 50;
		this.B03461A0.Text = "Ảnh (0):";
		this.B03461A0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuCards2.BackColor = System.Drawing.Color.White;
		this.bunifuCards2.BorderRadius = 0;
		this.bunifuCards2.BottomSahddow = true;
		this.bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards2.Controls.Add(this.BC1CD134);
		this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards2.LeftSahddow = false;
		this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards2.Name = "bunifuCards2";
		this.bunifuCards2.RightSahddow = true;
		this.bunifuCards2.ShadowDepth = 20;
		this.bunifuCards2.Size = new System.Drawing.Size(363, 37);
		this.bunifuCards2.TabIndex = 43;
		this.BC1CD134.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.BC1CD134.BackColor = System.Drawing.Color.White;
		this.BC1CD134.Controls.Add(this.BFBD2C12);
		this.BC1CD134.Controls.Add(this.CB86F1A6);
		this.BC1CD134.Controls.Add(this.B1A0471D);
		this.BC1CD134.Controls.Add(this.bunifuCustomLabel1);
		this.BC1CD134.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.BC1CD134.Location = new System.Drawing.Point(0, 3);
		this.BC1CD134.Name = "pnlHeader";
		this.BC1CD134.Size = new System.Drawing.Size(363, 31);
		this.BC1CD134.TabIndex = 9;
		this.BFBD2C12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.BFBD2C12.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BFBD2C12.FlatAppearance.BorderSize = 0;
		this.BFBD2C12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BFBD2C12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BFBD2C12.ForeColor = System.Drawing.Color.White;
		this.BFBD2C12.Image = Resources.C400940B;
		this.BFBD2C12.Location = new System.Drawing.Point(332, 1);
		this.BFBD2C12.Name = "button2";
		this.BFBD2C12.Size = new System.Drawing.Size(30, 30);
		this.BFBD2C12.TabIndex = 77;
		this.BFBD2C12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BFBD2C12.UseVisualStyleBackColor = true;
		this.BFBD2C12.Click += new System.EventHandler(BFBD2C12_Click);
		this.CB86F1A6.Cursor = System.Windows.Forms.Cursors.Default;
		this.CB86F1A6.Image = Resources.Bitmap_4;
		this.CB86F1A6.Location = new System.Drawing.Point(3, 2);
		this.CB86F1A6.Name = "pictureBox1";
		this.CB86F1A6.Size = new System.Drawing.Size(34, 27);
		this.CB86F1A6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.CB86F1A6.TabIndex = 76;
		this.CB86F1A6.TabStop = false;
		this.B1A0471D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B1A0471D.FlatAppearance.BorderSize = 0;
		this.B1A0471D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B1A0471D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B1A0471D.ForeColor = System.Drawing.Color.White;
		this.B1A0471D.Location = new System.Drawing.Point(899, 1);
		this.B1A0471D.Name = "btnMinimize";
		this.B1A0471D.Size = new System.Drawing.Size(30, 30);
		this.B1A0471D.TabIndex = 9;
		this.B1A0471D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.B1A0471D.UseVisualStyleBackColor = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(363, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Chi tiết bài viết";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.EA0CEF25.AllowUserToAddRows = false;
		this.EA0CEF25.AllowUserToDeleteRows = false;
		this.EA0CEF25.AllowUserToResizeColumns = false;
		this.EA0CEF25.AllowUserToResizeRows = false;
		this.EA0CEF25.BackgroundColor = System.Drawing.Color.White;
		this.EA0CEF25.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.EA0CEF25.ColumnHeadersVisible = false;
		this.EA0CEF25.Columns.AddRange(this.C98E2AB6);
		this.EA0CEF25.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EA0CEF25.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.EA0CEF25.Location = new System.Drawing.Point(85, 97);
		this.EA0CEF25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.EA0CEF25.Name = "dgvPic";
		this.EA0CEF25.RowHeadersVisible = false;
		this.EA0CEF25.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.EA0CEF25.Size = new System.Drawing.Size(270, 76);
		this.EA0CEF25.TabIndex = 42;
		this.EA0CEF25.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(EA0CEF25_CellContentClick);
		this.EA0CEF25.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(F5179428);
		this.C98E2AB6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.C98E2AB6.DataPropertyName = "Day";
		this.C98E2AB6.FillWeight = 57.38708f;
		this.C98E2AB6.HeaderText = "Đường dẫn";
		this.C98E2AB6.Name = "dataGridViewTextBoxColumn4";
		this.txtChuDe.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtChuDe.Location = new System.Drawing.Point(85, 41);
		this.txtChuDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.txtChuDe.Name = "txtChuDe";
		this.txtChuDe.ReadOnly = true;
		this.txtChuDe.Size = new System.Drawing.Size(270, 23);
		this.txtChuDe.TabIndex = 46;
		this.B21D148A.AutoSize = true;
		this.B21D148A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B21D148A.ForeColor = System.Drawing.SystemColors.ControlText;
		this.B21D148A.Location = new System.Drawing.Point(6, 72);
		this.B21D148A.Name = "label5";
		this.B21D148A.Size = new System.Drawing.Size(56, 16);
		this.B21D148A.TabIndex = 44;
		this.B21D148A.Text = "Tiêu đề:";
		this.B21D148A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.A593D7AE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A593D7AE.Location = new System.Drawing.Point(85, 181);
		this.A593D7AE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.A593D7AE.Multiline = true;
		this.A593D7AE.Name = "txtConten";
		this.A593D7AE.ReadOnly = true;
		this.A593D7AE.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.A593D7AE.Size = new System.Drawing.Size(270, 149);
		this.A593D7AE.TabIndex = 48;
		this.A593D7AE.WordWrap = false;
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
		this.label4.Location = new System.Drawing.Point(6, 44);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(53, 16);
		this.label4.TabIndex = 43;
		this.label4.Text = "Chủ đề:";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
		this.label2.Location = new System.Drawing.Point(6, 184);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(63, 16);
		this.label2.TabIndex = 45;
		this.label2.Text = "Nội dung:";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.E3B5AE32.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.E3B5AE32.Location = new System.Drawing.Point(85, 69);
		this.E3B5AE32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.E3B5AE32.Name = "txtName";
		this.E3B5AE32.ReadOnly = true;
		this.E3B5AE32.Size = new System.Drawing.Size(270, 23);
		this.E3B5AE32.TabIndex = 47;
		this.CC9B2F9E.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.A291C595, this.C3110C11, this.toolStripMenuItem_0 });
		this.CC9B2F9E.Name = "contextMenuStrip1";
		this.CC9B2F9E.Size = new System.Drawing.Size(153, 70);
		this.A291C595.Name = "thêmMớiToolStripMenuItem";
		this.A291C595.Size = new System.Drawing.Size(152, 22);
		this.A291C595.Text = "Thêm chủ đề";
		this.C3110C11.Name = "sửaToolStripMenuItem";
		this.C3110C11.Size = new System.Drawing.Size(152, 22);
		this.C3110C11.Text = "Sửa tên chủ đề";
		this.toolStripMenuItem_0.Name = "xóaToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(152, 22);
		this.toolStripMenuItem_0.Text = "Xóa chủ đề";
		this.CC0CD63D.Fixed = true;
		this.CC0CD63D.Horizontal = true;
		this.CC0CD63D.TargetControl = this.bunifuCustomLabel1;
		this.CC0CD63D.Vertical = true;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 200;
		this.toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(365, 342);
		base.Controls.Add(this.ED21EBAF);
		base.Controls.Add(this.EEAFF4BE);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fChiTietBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(D0AF9187_Load);
		this.ED21EBAF.ResumeLayout(false);
		this.ED21EBAF.PerformLayout();
		this.bunifuCards2.ResumeLayout(false);
		this.BC1CD134.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.CB86F1A6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.EA0CEF25).EndInit();
		this.CC9B2F9E.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
