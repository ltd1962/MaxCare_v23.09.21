using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChonThuMuc : Form
{
	private bool bool_0 = false;

	public static List<string> DE35F309;

	public static List<string> list_0;

	public static bool bool_1;

	private IContainer F92F7097 = null;

	private BunifuCards bunifuCards1;

	private Panel C8897817;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button AE22CE05;

	private Button A42E282E;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox B9B5E83C;

	private Label label1;

	private Label E7039C2F;

	private Label B6AA6826;

	private Label lblCountChoose;

	private Label label2;

	public DataGridView F716C685;

	private CheckBox checkBox1;

	private DataGridViewCheckBoxColumn C13FB530;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cId;

	private DataGridViewTextBoxColumn cThuMuc;

	private Button button4;

	private Button button5;

	public fChonThuMuc(bool bool_2 = false)
	{
		InitializeComponent();
		bool_1 = false;
		bool_0 = bool_2;
		Language.SetLanguage(this);
	}

	private void FB89A913(object sender, EventArgs e)
	{
		Close();
	}

	private void A42E282E_Click(object sender, EventArgs e)
	{
		bool_1 = true;
		if (bool_0)
		{
			list_0 = new List<string>();
			for (int i = 0; i < F716C685.Rows.Count; i++)
			{
				if (Convert.ToBoolean(F716C685.Rows[i].Cells["cChose"].Value))
				{
					list_0.Add(DatagridviewHelper.GetStatusDataGridView(F716C685, i, "cId"));
				}
			}
			if (list_0.Count == 0)
			{
				MessageBoxHelper.Show("Vui lòng chọn ít nhất 1 thư mục!", 2);
				return;
			}
		}
		else
		{
			DE35F309 = new List<string>();
			for (int j = 0; j < F716C685.Rows.Count; j++)
			{
				if (Convert.ToBoolean(F716C685.Rows[j].Cells["cChose"].Value))
				{
					DE35F309.Add(DatagridviewHelper.GetStatusDataGridView(F716C685, j, "cId"));
				}
			}
			if (DE35F309.Count == 0)
			{
				MessageBoxHelper.Show("Vui lòng chọn ít nhất 1 thư mục!", 2);
				return;
			}
		}
		Close();
	}

	private void B98C1301(object sender, EventArgs e)
	{
		Close();
	}

	private void FE37D7A7(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (list_0 == null)
			{
				list_0 = new List<string>();
			}
			A8B8E237(list_0);
		}
		else
		{
			if (DE35F309 == null)
			{
				DE35F309 = new List<string>();
			}
			A8B8E237(DE35F309);
		}
	}

	private void A8B8E237(List<string> list_1 = null)
	{
		try
		{
			DataTable dataTable = ((!bool_0) ? CommonSQL.C6B3348F() : CommonSQL.C6B3348F(CAB18A83: false, bool_0: true));
			if (list_1 != null && list_1.Count > 0)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					if (list_1.Contains(dataTable.Rows[i]["id"].ToString()))
					{
						F716C685.Rows.Add(true, i + 1, dataTable.Rows[i]["id"], dataTable.Rows[i]["name"]);
					}
					else
					{
						F716C685.Rows.Add(false, i + 1, dataTable.Rows[i]["id"], dataTable.Rows[i]["name"]);
					}
				}
			}
			else
			{
				for (int j = 0; j < dataTable.Rows.Count; j++)
				{
					F716C685.Rows.Add(false, j + 1, dataTable.Rows[j]["id"], dataTable.Rows[j]["name"]);
				}
			}
			method_0();
			method_1();
			if (method_2() == F716C685.RowCount)
			{
				checkBox1.Checked = true;
			}
			else
			{
				checkBox1.Checked = false;
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError2(exception_, "LoadListFiles");
			MessageBoxHelper.Show("Có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void method_0()
	{
		try
		{
			lblCountChoose.Text = method_2().ToString();
		}
		catch
		{
		}
	}

	private void F716C685_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0 && e.RowIndex > -1)
		{
			method_0();
			if (method_2() == F716C685.RowCount)
			{
				checkBox1.Checked = true;
			}
			else
			{
				checkBox1.Checked = false;
			}
		}
	}

	private void method_1()
	{
		try
		{
			E7039C2F.Text = F716C685.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	private void F716C685_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (Convert.ToBoolean(F716C685.CurrentRow.Cells["cChose"].Value))
			{
				F716C685.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				F716C685.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private int method_2()
	{
		int num = 0;
		for (int i = 0; i < F716C685.Rows.Count; i++)
		{
			if (Convert.ToBoolean(F716C685.Rows[i].Cells["cChose"].Value))
			{
				num++;
			}
		}
		return num;
	}

	private void FA16EAA2(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 0 || e.RowIndex <= -1)
		{
			return;
		}
		try
		{
			if (Convert.ToBoolean(F716C685.CurrentRow.Cells["cChose"].Value))
			{
				F716C685.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				F716C685.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private void B63143BC(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			for (int i = 0; i < F716C685.Rows.Count; i++)
			{
				DatagridviewHelper.SetStatusDataGridView(F716C685, i, "cChose", true);
			}
		}
		else
		{
			for (int j = 0; j < F716C685.Rows.Count; j++)
			{
				DatagridviewHelper.SetStatusDataGridView(F716C685, j, "cChose", false);
			}
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		int index = F716C685.SelectedRows[0].Index;
		if (index == 0)
		{
			return;
		}
		string text = DatagridviewHelper.GetStatusDataGridView(F716C685, index - 1, "cId");
		string text2 = DatagridviewHelper.GetStatusDataGridView(F716C685, index, "cId");
		if (text + text2 != "")
		{
			if (CommonSQL.smethod_33(text, text2))
			{
				Common.smethod_69(ref F716C685, index, index - 1, 2);
				F716C685.ClearSelection();
				F716C685.Rows[index - 1].Selected = true;
			}
			else
			{
				MessageBoxHelper.Show("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		int index = F716C685.SelectedRows[0].Index;
		if (index == F716C685.RowCount - 1)
		{
			return;
		}
		string text = DatagridviewHelper.GetStatusDataGridView(F716C685, index + 1, "cId");
		string text2 = DatagridviewHelper.GetStatusDataGridView(F716C685, index, "cId");
		if (text + text2 != "")
		{
			if (CommonSQL.smethod_33(text, text2))
			{
				Common.smethod_69(ref F716C685, index, index + 1, 2);
				F716C685.ClearSelection();
				F716C685.Rows[index + 1].Selected = true;
			}
			else
			{
				MessageBoxHelper.Show("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void F716C685_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 32)
		{
			for (int i = 0; i < F716C685.SelectedRows.Count; i++)
			{
				int index = F716C685.SelectedRows[i].Index;
				DatagridviewHelper.SetStatusDataGridView(F716C685, index, "cChose", !Convert.ToBoolean(DatagridviewHelper.GetStatusDataGridView(F716C685, index, "cChose")));
			}
			method_2();
		}
	}

	protected override void Dispose(bool A72595AE)
	{
		if (A72595AE && F92F7097 != null)
		{
			F92F7097.Dispose();
		}
		base.Dispose(A72595AE);
	}

	private void InitializeComponent()
	{
		this.F92F7097 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonThuMuc));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.C8897817 = new System.Windows.Forms.Panel();
		this.B9B5E83C = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.AE22CE05 = new System.Windows.Forms.Button();
		this.A42E282E = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.F92F7097);
		this.label1 = new System.Windows.Forms.Label();
		this.E7039C2F = new System.Windows.Forms.Label();
		this.B6AA6826 = new System.Windows.Forms.Label();
		this.lblCountChoose = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.F716C685 = new System.Windows.Forms.DataGridView();
		this.C13FB530 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cThuMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.button4 = new System.Windows.Forms.Button();
		this.button5 = new System.Windows.Forms.Button();
		this.bunifuCards1.SuspendLayout();
		this.C8897817.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.B9B5E83C).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F716C685).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.C8897817);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(487, 34);
		this.bunifuCards1.TabIndex = 0;
		this.C8897817.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.C8897817.BackColor = System.Drawing.Color.White;
		this.C8897817.Controls.Add(this.B9B5E83C);
		this.C8897817.Controls.Add(this.btnMinimize);
		this.C8897817.Controls.Add(this.bunifuCustomLabel1);
		this.C8897817.Location = new System.Drawing.Point(0, 3);
		this.C8897817.Name = "pnlHeader";
		this.C8897817.Size = new System.Drawing.Size(487, 28);
		this.C8897817.TabIndex = 9;
		this.B9B5E83C.Cursor = System.Windows.Forms.Cursors.Default;
		this.B9B5E83C.Image = Resources.Bitmap_4;
		this.B9B5E83C.Location = new System.Drawing.Point(3, 2);
		this.B9B5E83C.Name = "pictureBox1";
		this.B9B5E83C.Size = new System.Drawing.Size(34, 27);
		this.B9B5E83C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.B9B5E83C.TabIndex = 17;
		this.B9B5E83C.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(455, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 28);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(FB89A913);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(487, 28);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Chọn Danh sách thư mục";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.AE22CE05.BackColor = System.Drawing.Color.Maroon;
		this.AE22CE05.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AE22CE05.FlatAppearance.BorderSize = 0;
		this.AE22CE05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.AE22CE05.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AE22CE05.ForeColor = System.Drawing.Color.White;
		this.AE22CE05.Location = new System.Drawing.Point(248, 374);
		this.AE22CE05.Name = "btnCancel";
		this.AE22CE05.Size = new System.Drawing.Size(92, 29);
		this.AE22CE05.TabIndex = 4;
		this.AE22CE05.Text = "Đo\u0301ng";
		this.AE22CE05.UseVisualStyleBackColor = false;
		this.AE22CE05.Click += new System.EventHandler(B98C1301);
		this.A42E282E.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.A42E282E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A42E282E.FlatAppearance.BorderSize = 0;
		this.A42E282E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A42E282E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A42E282E.ForeColor = System.Drawing.Color.White;
		this.A42E282E.Location = new System.Drawing.Point(144, 374);
		this.A42E282E.Name = "btnAdd";
		this.A42E282E.Size = new System.Drawing.Size(92, 29);
		this.A42E282E.TabIndex = 3;
		this.A42E282E.Text = "Lưu";
		this.A42E282E.UseVisualStyleBackColor = false;
		this.A42E282E.Click += new System.EventHandler(A42E282E_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(263, 346);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(58, 16);
		this.label1.TabIndex = 6;
		this.label1.Text = "Tổng số:";
		this.E7039C2F.AutoSize = true;
		this.E7039C2F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.E7039C2F.ForeColor = System.Drawing.Color.DarkRed;
		this.E7039C2F.Location = new System.Drawing.Point(321, 347);
		this.E7039C2F.Name = "lblCountTotal";
		this.E7039C2F.Size = new System.Drawing.Size(14, 16);
		this.E7039C2F.TabIndex = 6;
		this.E7039C2F.Text = "0";
		this.B6AA6826.AutoSize = true;
		this.B6AA6826.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B6AA6826.Location = new System.Drawing.Point(128, 346);
		this.B6AA6826.Name = "label3";
		this.B6AA6826.Size = new System.Drawing.Size(59, 16);
		this.B6AA6826.TabIndex = 6;
		this.B6AA6826.Text = "Đã chọn:";
		this.lblCountChoose.AutoSize = true;
		this.lblCountChoose.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCountChoose.ForeColor = System.Drawing.Color.DarkGreen;
		this.lblCountChoose.Location = new System.Drawing.Point(186, 347);
		this.lblCountChoose.Name = "lblCountChoose";
		this.lblCountChoose.Size = new System.Drawing.Size(14, 16);
		this.lblCountChoose.TabIndex = 6;
		this.lblCountChoose.Text = "0";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.Color.DarkRed;
		this.label2.Location = new System.Drawing.Point(12, 320);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(177, 16);
		this.label2.TabIndex = 6;
		this.label2.Text = "(Click đúp vào dòng để chọn!)";
		this.F716C685.AllowUserToAddRows = false;
		this.F716C685.AllowUserToDeleteRows = false;
		this.F716C685.AllowUserToResizeRows = false;
		this.F716C685.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.F716C685.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.F716C685.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.F716C685.Columns.AddRange(this.C13FB530, this.cStt, this.cId, this.cThuMuc);
		this.F716C685.Location = new System.Drawing.Point(15, 40);
		this.F716C685.Name = "dtgvAcc";
		this.F716C685.ReadOnly = true;
		this.F716C685.RowHeadersVisible = false;
		this.F716C685.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.F716C685.Size = new System.Drawing.Size(415, 277);
		this.F716C685.TabIndex = 7;
		this.F716C685.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(FA16EAA2);
		this.F716C685.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(F716C685_CellDoubleClick);
		this.F716C685.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(F716C685_CellValueChanged);
		this.F716C685.KeyDown += new System.Windows.Forms.KeyEventHandler(F716C685_KeyDown);
		this.C13FB530.HeaderText = "";
		this.C13FB530.Name = "cChose";
		this.C13FB530.ReadOnly = true;
		this.C13FB530.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.C13FB530.Width = 30;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.cStt.DefaultCellStyle = dataGridViewCellStyle2;
		this.cStt.HeaderText = "STT";
		this.cStt.Name = "cStt";
		this.cStt.ReadOnly = true;
		this.cStt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.cStt.Width = 35;
		this.cId.HeaderText = "Id";
		this.cId.Name = "cId";
		this.cId.ReadOnly = true;
		this.cId.Visible = false;
		this.cId.Width = 90;
		this.cThuMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cThuMuc.HeaderText = "Thư mục";
		this.cThuMuc.Name = "cThuMuc";
		this.cThuMuc.ReadOnly = true;
		this.checkBox1.AutoSize = true;
		this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkBox1.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBox1.Location = new System.Drawing.Point(25, 45);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(15, 14);
		this.checkBox1.TabIndex = 8;
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.Click += new System.EventHandler(B63143BC);
		this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button4.Image = Resources.DFACFA22;
		this.button4.Location = new System.Drawing.Point(436, 85);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(41, 38);
		this.button4.TabIndex = 81;
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button5.Image = Resources.Bitmap_143;
		this.button5.Location = new System.Drawing.Point(436, 40);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(41, 38);
		this.button5.TabIndex = 82;
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(button5_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(487, 415);
		base.Controls.Add(this.button4);
		base.Controls.Add(this.button5);
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.F716C685);
		base.Controls.Add(this.lblCountChoose);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.E7039C2F);
		base.Controls.Add(this.B6AA6826);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.AE22CE05);
		base.Controls.Add(this.A42E282E);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fChonThuMuc";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(FE37D7A7);
		this.bunifuCards1.ResumeLayout(false);
		this.C8897817.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.B9B5E83C).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F716C685).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
