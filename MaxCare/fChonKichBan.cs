using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChonKichBan : Form
{
	private IContainer icontainer_0 = null;

	private ToolTip BD020696;

	private BunifuDragControl BE85A583;

	private BunifuDragControl FB131129;

	private GroupBox E6117185;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private PictureBox AF1A5023;

	private BunifuCustomLabel E69D4401;

	private Button A888733D;

	public DataGridView dtgvKichBan;

	private Panel panel1;

	private Button A0BFA39D;

	private Button button3;

	private GroupBox groupBox2;

	private Label label2;

	private Button btnCancel;

	private Button btnSave;

	private Label lblCountAcc;

	private Label label7;

	private Label A98AE8B0;

	public DataGridView dtgvKichBanChoose;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cIdKichBan;

	private DataGridViewTextBoxColumn E626A985;

	private DataGridViewTextBoxColumn cSTTChoose;

	private DataGridViewTextBoxColumn cIdKichBanChoose;

	private DataGridViewTextBoxColumn F3B30F27;

	public fChonKichBan()
	{
		FBAE6108();
		Language.SetLanguage(this);
	}

	private void B52CC134(object sender, EventArgs e)
	{
		method_0();
		method_0(SettingsTool.GetSettings("configInteractGeneral").GetValueList("lstIdKichBan"));
	}

	private void method_0(List<string> list_0 = null)
	{
		try
		{
			if (list_0 != null && list_0.Count > 0)
			{
				dtgvKichBanChoose.Rows.Clear();
				for (int i = 0; i < list_0.Count; i++)
				{
					DataTable dataTable = InteractSQL.B6A0BD0E(list_0[i]);
					if (dataTable.Rows.Count > 0)
					{
						DataRow dataRow = dataTable.Rows[0];
						dtgvKichBanChoose.Rows.Add(dtgvKichBanChoose.RowCount + 1, dataRow["Id_KichBan"], dataRow["TenKichBan"]);
					}
				}
				return;
			}
			dtgvKichBan.Rows.Clear();
			DataTable dataTable2 = InteractSQL.GetAllKichBan();
			if (dataTable2.Rows.Count > 0)
			{
				for (int j = 0; j < dataTable2.Rows.Count; j++)
				{
					DataRow dataRow2 = dataTable2.Rows[j];
					dtgvKichBan.Rows.Add(j + 1, dataRow2["Id_KichBan"], dataRow2["TenKichBan"]);
				}
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
		}
	}

	private void A888733D_Click(object sender, EventArgs e)
	{
		Close();
	}

	public void method_1(ref DataGridView CF2AFC36, int BF8E5501, int int_0)
	{
		string text = "";
		for (int i = 1; i < CF2AFC36.Columns.Count; i++)
		{
			text = DatagridviewHelper.GetStatusDataGridView(CF2AFC36, BF8E5501, i);
			DatagridviewHelper.smethod_5(CF2AFC36, BF8E5501, i, DatagridviewHelper.GetStatusDataGridView(CF2AFC36, int_0, i));
			DatagridviewHelper.smethod_5(CF2AFC36, int_0, i, text);
		}
	}

	private void A0BFA39D_Click(object sender, EventArgs e)
	{
		int index = dtgvKichBanChoose.SelectedRows[0].Index;
		if (index != 0)
		{
			string text = DatagridviewHelper.GetStatusDataGridView(dtgvKichBanChoose, index - 1, "cIdKichBanChoose");
			string text2 = DatagridviewHelper.GetStatusDataGridView(dtgvKichBanChoose, index, "cIdKichBanChoose");
			if (text + text2 != "")
			{
				method_1(ref dtgvKichBanChoose, index, index - 1);
				dtgvKichBanChoose.Rows[index - 1].Selected = true;
			}
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		int index = dtgvKichBanChoose.SelectedRows[0].Index;
		if (index != dtgvKichBanChoose.RowCount - 1)
		{
			string text = DatagridviewHelper.GetStatusDataGridView(dtgvKichBanChoose, index + 1, "cIdKichBanChoose");
			string text2 = DatagridviewHelper.GetStatusDataGridView(dtgvKichBanChoose, index, "cIdKichBanChoose");
			if (text + text2 != "")
			{
				method_1(ref dtgvKichBanChoose, index, index + 1);
				dtgvKichBanChoose.Rows[index + 1].Selected = true;
			}
		}
	}

	private void D7273C14(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private bool method_2(string D6967E33)
	{
		bool result = false;
		for (int i = 0; i < dtgvKichBanChoose.RowCount; i++)
		{
			if (D6967E33 == dtgvKichBanChoose.Rows[i].Cells[1].Value.ToString())
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void F29CA992(object sender, DataGridViewCellEventArgs e)
	{
		int num = Convert.ToInt32(dtgvKichBan.SelectedRows[0].Cells[1].Value);
		string text = dtgvKichBan.SelectedRows[0].Cells[2].Value.ToString();
		if (!method_2(num.ToString()))
		{
			dtgvKichBanChoose.Rows.Add(dtgvKichBanChoose.RowCount + 1, num, text);
		}
	}

	private void dtgvKichBanChoose_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		dtgvKichBanChoose.Rows.RemoveAt(dtgvKichBanChoose.SelectedRows[0].Index);
		for (int i = 0; i < dtgvKichBanChoose.RowCount; i++)
		{
			DatagridviewHelper.SetStatusDataGridView(dtgvKichBanChoose, i, "cSTTChoose", i + 1);
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvKichBanChoose.RowCount; i++)
			{
				list.Add(DatagridviewHelper.GetStatusDataGridView(dtgvKichBanChoose, i, "cIdKichBanChoose"));
			}
			SettingsTool.GetSettings("configInteractGeneral").method_5("lstIdKichBan", list);
			SettingsTool.Save("configInteractGeneral");
			Close();
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 3);
		}
	}

	private void dtgvKichBanChoose_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		lblCountAcc.Text = dtgvKichBanChoose.RowCount.ToString();
	}

	private void dtgvKichBanChoose_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		lblCountAcc.Text = dtgvKichBanChoose.RowCount.ToString();
	}

	protected override void Dispose(bool C4338CA0)
	{
		if (C4338CA0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C4338CA0);
	}

	private void FBAE6108()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fChonKichBan));
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		BD020696 = new ToolTip(icontainer_0);
		BE85A583 = new BunifuDragControl(icontainer_0);
		E69D4401 = new BunifuCustomLabel();
		FB131129 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		A888733D = new Button();
		AF1A5023 = new PictureBox();
		E6117185 = new GroupBox();
		label2 = new Label();
		dtgvKichBan = new DataGridView();
		cStt = new DataGridViewTextBoxColumn();
		cIdKichBan = new DataGridViewTextBoxColumn();
		E626A985 = new DataGridViewTextBoxColumn();
		bunifuCards1 = new BunifuCards();
		panel1 = new Panel();
		btnCancel = new Button();
		btnSave = new Button();
		groupBox2 = new GroupBox();
		lblCountAcc = new Label();
		label7 = new Label();
		A98AE8B0 = new Label();
		button3 = new Button();
		dtgvKichBanChoose = new DataGridView();
		cSTTChoose = new DataGridViewTextBoxColumn();
		cIdKichBanChoose = new DataGridViewTextBoxColumn();
		F3B30F27 = new DataGridViewTextBoxColumn();
		A0BFA39D = new Button();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)AF1A5023).BeginInit();
		E6117185.SuspendLayout();
		((ISupportInitialize)dtgvKichBan).BeginInit();
		bunifuCards1.SuspendLayout();
		panel1.SuspendLayout();
		groupBox2.SuspendLayout();
		((ISupportInitialize)dtgvKichBanChoose).BeginInit();
		SuspendLayout();
		BD020696.AutomaticDelay = 0;
		BD020696.AutoPopDelay = 10000;
		BD020696.InitialDelay = 200;
		BD020696.ReshowDelay = 40;
		BD020696.ToolTipTitle = "Chú thích";
		BE85A583.Fixed = true;
		BE85A583.Horizontal = true;
		BE85A583.TargetControl = E69D4401;
		BE85A583.Vertical = true;
		E69D4401.BackColor = Color.Transparent;
		E69D4401.Cursor = Cursors.SizeAll;
		E69D4401.Dock = DockStyle.Fill;
		E69D4401.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E69D4401.ForeColor = Color.Black;
		E69D4401.Location = new Point(0, 0);
		E69D4401.Name = "bunifuCustomLabel1";
		E69D4401.Size = new Size(696, 31);
		E69D4401.TabIndex = 12;
		E69D4401.Text = "Chọn danh sách kịch bản chạy";
		E69D4401.TextAlign = ContentAlignment.MiddleCenter;
		FB131129.Fixed = true;
		FB131129.Horizontal = true;
		FB131129.TargetControl = pnlHeader;
		FB131129.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(A888733D);
		pnlHeader.Controls.Add(AF1A5023);
		pnlHeader.Controls.Add(E69D4401);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(696, 31);
		pnlHeader.TabIndex = 9;
		A888733D.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		A888733D.Cursor = Cursors.Hand;
		A888733D.FlatAppearance.BorderSize = 0;
		A888733D.FlatStyle = FlatStyle.Flat;
		A888733D.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		A888733D.ForeColor = Color.White;
		A888733D.Image = (Image)componentResourceManager.GetObject("button1.Image");
		A888733D.Location = new Point(667, 2);
		A888733D.Name = "button1";
		A888733D.Size = new Size(30, 30);
		A888733D.TabIndex = 77;
		A888733D.TextImageRelation = TextImageRelation.ImageBeforeText;
		A888733D.UseVisualStyleBackColor = true;
		A888733D.Click += A888733D_Click;
		AF1A5023.Cursor = Cursors.Default;
		AF1A5023.Image = Resources.Bitmap_4;
		AF1A5023.Location = new Point(3, 2);
		AF1A5023.Name = "pictureBox1";
		AF1A5023.Size = new Size(34, 27);
		AF1A5023.SizeMode = PictureBoxSizeMode.Zoom;
		AF1A5023.TabIndex = 76;
		AF1A5023.TabStop = false;
		E6117185.BackColor = Color.White;
		E6117185.Controls.Add(label2);
		E6117185.Controls.Add(dtgvKichBan);
		E6117185.Location = new Point(12, 41);
		E6117185.Margin = new Padding(3, 4, 3, 4);
		E6117185.Name = "groupBox1";
		E6117185.Padding = new Padding(3, 4, 3, 4);
		E6117185.Size = new Size(308, 302);
		E6117185.TabIndex = 1;
		E6117185.TabStop = false;
		E6117185.Text = "Danh sách kịch bản";
		label2.AutoSize = true;
		label2.ForeColor = Color.Red;
		label2.Location = new Point(3, 281);
		label2.Name = "label2";
		label2.Size = new Size(192, 16);
		label2.TabIndex = 81;
		label2.Text = "(Click đúp vào kịch bản để chọn)";
		dtgvKichBan.AllowUserToAddRows = false;
		dtgvKichBan.AllowUserToDeleteRows = false;
		dtgvKichBan.AllowUserToResizeRows = false;
		dtgvKichBan.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		dtgvKichBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dtgvKichBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvKichBan.Columns.AddRange(cStt, cIdKichBan, E626A985);
		dtgvKichBan.EditMode = DataGridViewEditMode.EditProgrammatically;
		dtgvKichBan.Location = new Point(6, 20);
		dtgvKichBan.MultiSelect = false;
		dtgvKichBan.Name = "dtgvKichBan";
		dtgvKichBan.RowHeadersVisible = false;
		dtgvKichBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dtgvKichBan.Size = new Size(296, 258);
		dtgvKichBan.TabIndex = 76;
		dtgvKichBan.CellDoubleClick += F29CA992;
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.Width = 35;
		cIdKichBan.HeaderText = "Id kịch bản";
		cIdKichBan.Name = "cIdKichBan";
		cIdKichBan.Visible = false;
		E626A985.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		E626A985.HeaderText = "Tên kịch bản";
		E626A985.Name = "cTenKichBan";
		E626A985.SortMode = DataGridViewColumnSortMode.NotSortable;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(699, 37);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnSave);
		panel1.Controls.Add(bunifuCards1);
		panel1.Controls.Add(groupBox2);
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(702, 391);
		panel1.TabIndex = 13;
		panel1.Paint += D7273C14;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(359, 350);
		btnCancel.Margin = new Padding(3, 4, 3, 4);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 22;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnSave.BackColor = Color.FromArgb(53, 120, 229);
		btnSave.Cursor = Cursors.Hand;
		btnSave.FlatAppearance.BorderSize = 0;
		btnSave.FlatStyle = FlatStyle.Flat;
		btnSave.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnSave.ForeColor = Color.White;
		btnSave.Location = new Point(252, 350);
		btnSave.Margin = new Padding(3, 4, 3, 4);
		btnSave.Name = "btnSave";
		btnSave.Size = new Size(92, 29);
		btnSave.TabIndex = 21;
		btnSave.Text = "Lưu";
		btnSave.UseVisualStyleBackColor = false;
		btnSave.Click += btnSave_Click;
		groupBox2.BackColor = Color.White;
		groupBox2.Controls.Add(lblCountAcc);
		groupBox2.Controls.Add(label7);
		groupBox2.Controls.Add(A98AE8B0);
		groupBox2.Controls.Add(button3);
		groupBox2.Controls.Add(dtgvKichBanChoose);
		groupBox2.Controls.Add(A0BFA39D);
		groupBox2.Location = new Point(325, 40);
		groupBox2.Margin = new Padding(3, 4, 3, 4);
		groupBox2.Name = "groupBox2";
		groupBox2.Padding = new Padding(3, 4, 3, 4);
		groupBox2.Size = new Size(363, 302);
		groupBox2.TabIndex = 1;
		groupBox2.TabStop = false;
		groupBox2.Text = "Kịch bản cần chạy";
		lblCountAcc.AutoSize = true;
		lblCountAcc.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		lblCountAcc.ForeColor = Color.Blue;
		lblCountAcc.Location = new Point(297, 281);
		lblCountAcc.Name = "lblCountAcc";
		lblCountAcc.Size = new Size(15, 16);
		lblCountAcc.TabIndex = 82;
		lblCountAcc.Text = "0";
		label7.AutoSize = true;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		label7.Location = new Point(255, 281);
		label7.Name = "label7";
		label7.Size = new Size(43, 16);
		label7.TabIndex = 83;
		label7.Text = "Tổng:";
		A98AE8B0.AutoSize = true;
		A98AE8B0.ForeColor = Color.Red;
		A98AE8B0.Location = new Point(4, 282);
		A98AE8B0.Name = "label1";
		A98AE8B0.Size = new Size(185, 16);
		A98AE8B0.TabIndex = 81;
		A98AE8B0.Text = "(Click đúp vào kịch bản để xóa)";
		button3.Cursor = Cursors.Hand;
		button3.Image = Resources.DFACFA22;
		button3.Location = new Point(314, 64);
		button3.Name = "button3";
		button3.Size = new Size(41, 38);
		button3.TabIndex = 78;
		button3.UseVisualStyleBackColor = true;
		button3.Click += button3_Click;
		dtgvKichBanChoose.AllowUserToAddRows = false;
		dtgvKichBanChoose.AllowUserToDeleteRows = false;
		dtgvKichBanChoose.AllowUserToResizeRows = false;
		dtgvKichBanChoose.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = SystemColors.Control;
		dataGridViewCellStyle2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
		dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
		dtgvKichBanChoose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		dtgvKichBanChoose.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvKichBanChoose.Columns.AddRange(cSTTChoose, cIdKichBanChoose, F3B30F27);
		dtgvKichBanChoose.EditMode = DataGridViewEditMode.EditProgrammatically;
		dtgvKichBanChoose.Location = new Point(6, 20);
		dtgvKichBanChoose.MultiSelect = false;
		dtgvKichBanChoose.Name = "dtgvKichBanChoose";
		dtgvKichBanChoose.RowHeadersVisible = false;
		dtgvKichBanChoose.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dtgvKichBanChoose.Size = new Size(302, 258);
		dtgvKichBanChoose.TabIndex = 76;
		dtgvKichBanChoose.CellDoubleClick += dtgvKichBanChoose_CellDoubleClick;
		dtgvKichBanChoose.RowsAdded += dtgvKichBanChoose_RowsAdded;
		dtgvKichBanChoose.RowsRemoved += dtgvKichBanChoose_RowsRemoved;
		cSTTChoose.HeaderText = "STT";
		cSTTChoose.Name = "cSTTChoose";
		cSTTChoose.Width = 35;
		cIdKichBanChoose.HeaderText = "Id kịch bản";
		cIdKichBanChoose.Name = "cIdKichBanChoose";
		cIdKichBanChoose.Visible = false;
		F3B30F27.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		F3B30F27.HeaderText = "Tên kịch bản";
		F3B30F27.Name = "cTenKichBanChoose";
		F3B30F27.SortMode = DataGridViewColumnSortMode.NotSortable;
		A0BFA39D.Cursor = Cursors.Hand;
		A0BFA39D.Image = Resources.Bitmap_143;
		A0BFA39D.Location = new Point(314, 19);
		A0BFA39D.Name = "button2";
		A0BFA39D.Size = new Size(41, 38);
		A0BFA39D.TabIndex = 78;
		A0BFA39D.UseVisualStyleBackColor = true;
		A0BFA39D.Click += A0BFA39D_Click;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(702, 391);
		base.Controls.Add(E6117185);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fChonKichBan";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Cấu hình tương tác";
		base.Load += B52CC134;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)AF1A5023).EndInit();
		E6117185.ResumeLayout(performLayout: false);
		E6117185.PerformLayout();
		((ISupportInitialize)dtgvKichBan).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		panel1.ResumeLayout(performLayout: false);
		groupBox2.ResumeLayout(performLayout: false);
		groupBox2.PerformLayout();
		((ISupportInitialize)dtgvKichBanChoose).EndInit();
		ResumeLayout(performLayout: false);
	}
}
