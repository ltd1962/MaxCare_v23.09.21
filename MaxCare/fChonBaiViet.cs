using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChonBaiViet : Form
{
	private bool F3BE8B18 = false;

	private List<string> list_0 = new List<string>();

	private IContainer E197C735 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl DC31600E;

	private ToolTip ED1251A7;

	private Button btnCancel;

	private Button C0222896;

	private GroupBox groupBox2;

	private GroupBox groupBox1;

	public DataGridView dgvDSBaiViet;

	private Button metroButton1;

	private Label label1;

	private ComboBox cbbChuDe;

	private Label lblCountAcc;

	private Label C8B04A9F;

	private BunifuCards bunifuCards2;

	private Panel A21B3911;

	private PictureBox CB1F5BBD;

	private Button C29C4201;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label label2;

	public DataGridView dgvBaiVietDaChon;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem D3A57B8D;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem C499B513;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private Label C8934793;

	private DataGridViewTextBoxColumn cStt1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn cId;

	private DataGridViewTextBoxColumn B0B30A01;

	private DataGridViewTextBoxColumn CBA8BD94;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn E425F411;

	private DataGridViewTextBoxColumn DEB980A9;

	private DataGridViewTextBoxColumn cIdBaiViet;

	private DataGridViewTextBoxColumn cTieuDe;

	private DataGridViewTextBoxColumn BAB2C61D;

	private DataGridViewTextBoxColumn cVideo;

	public fChonBaiViet(ref List<string> list_1)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		CB25159D();
		list_0 = list_1;
		method_0();
	}

	private void method_0()
	{
		if (list_0.Count <= 0)
		{
			return;
		}
		dgvBaiVietDaChon.Rows.Clear();
		for (int i = 0; i < list_0.Count; i++)
		{
			try
			{
				BaiViet @class = E2AFA82B(list_0[i]);
				dgvBaiVietDaChon.Rows.Add(i + 1, @class.D0B8AABE, @class.Int32_0, @class.String_0, @class.String_1.Split('|').Length - 1, @class.String_2.Split('|').Length - 1);
			}
			catch
			{
				list_0.RemoveAt(i--);
			}
		}
	}

	private BaiViet E2AFA82B(string string_0)
	{
		BaiViet result = new BaiViet();
		try
		{
			result = CommonSQL.GetListBaiVietByID(string_0)[0];
		}
		catch
		{
		}
		return result;
	}

	private void CB25159D(bool E58A7A01 = false)
	{
		int selectedIndex = cbbChuDe.SelectedIndex;
		cbbChuDe.Items.Clear();
		List<string> list = CommonSQL.smethod_21();
		for (int i = 0; i < list.Count; i++)
		{
			cbbChuDe.Items.Add(list[i]);
		}
		if (cbbChuDe.Items.Count == 0)
		{
			cbbChuDe.SelectedIndex = -1;
		}
		else if (cbbChuDe.Items.Count == 1)
		{
			cbbChuDe.SelectedIndex = 0;
		}
		else if (selectedIndex == -1)
		{
			cbbChuDe.SelectedIndex = 0;
		}
		else if (cbbChuDe.Items.Count - 1 < selectedIndex)
		{
			cbbChuDe.SelectedIndex = cbbChuDe.Items.Count - 1;
		}
		else
		{
			cbbChuDe.SelectedIndex = selectedIndex;
		}
		E81CD681(E58A7A01);
		method_0();
	}

	private void E81CD681(bool bool_0 = true)
	{
		try
		{
			dgvDSBaiViet.Rows.Clear();
			List<BaiViet> list = new List<BaiViet>();
			list = (bool_0 ? CommonSQL.smethod_22() : CommonSQL.smethod_22(cbbChuDe.SelectedItem.ToString()));
			BaiViet @class = new BaiViet();
			for (int i = 0; i < list.Count; i++)
			{
				@class = list[i];
				dgvDSBaiViet.Rows.Add(i + 1, @class.D0B8AABE, @class.Int32_0, @class.String_0, @class.String_1.Split('|').Length - 1, @class.String_2.Split('|').Length - 1);
			}
		}
		catch
		{
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fChonBaiViet_Load(object sender, EventArgs e)
	{
	}

	private void C0222896_Click(object sender, EventArgs e)
	{
		list_0.Clear();
		for (int i = 0; i < dgvBaiVietDaChon.RowCount; i++)
		{
			list_0.Add(dgvBaiVietDaChon.Rows[i].Cells["cId"].Value.ToString());
		}
		if (MessageBoxHelper.ShowMessages("Lưu thành công, bạn có muốn đóng cửa sổ?") == DialogResult.Yes)
		{
			Close();
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
		Close();
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fDanhSachChuDe());
		CB25159D(F3BE8B18);
	}

	private void FCB9DFB4(object sender, EventArgs e)
	{
		try
		{
			int count = CommonSQL.smethod_22().Count;
			Common.ShowForm(new fThemBaiViet(cbbChuDe.SelectedIndex));
			int count2 = CommonSQL.smethod_22().Count;
			if (count2 > count)
			{
				BaiViet @class = CommonSQL.smethod_26()[0];
				dgvDSBaiViet.Rows.Add(dgvDSBaiViet.RowCount + 1, @class.D0B8AABE, @class.Int32_0, @class.String_0, @class.String_1.Split('|').Length - 1, @class.String_2.Split('|').Length - 1);
			}
		}
		catch
		{
		}
	}

	private void D3A57B8D_Click(object sender, EventArgs e)
	{
		try
		{
			DataGridViewRow dataGridViewRow = dgvDSBaiViet.SelectedRows[0];
			int int_ = Convert.ToInt32(dataGridViewRow.Cells[2].Value);
			Common.ShowForm(new fSuaBaiViet(int_));
			BaiViet @class = CommonSQL.GetListBaiVietByID(int_.ToString())[0];
			Common.SetStatusDataGridView(dgvDSBaiViet, dataGridViewRow.Index, "cTieuDe", @class.String_0);
			Common.SetStatusDataGridView(dgvDSBaiViet, dataGridViewRow.Index, "cAnh", @class.String_1.Split('|').Length - 1);
			Common.SetStatusDataGridView(dgvDSBaiViet, dataGridViewRow.Index, "cVideo", @class.String_2.Split('|').Length - 1);
			method_0();
		}
		catch
		{
		}
	}

	private bool AC35A006(string DBB73784)
	{
		bool result = false;
		for (int i = 0; i < dgvBaiVietDaChon.Rows.Count; i++)
		{
			if (DBB73784 == dgvBaiVietDaChon.Rows[i].Cells[2].Value.ToString())
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void A60AD615(object sender, DataGridViewCellEventArgs e)
	{
		int num = Convert.ToInt32(dgvDSBaiViet.SelectedRows[0].Cells[2].Value);
		List<BaiViet> list = CommonSQL.GetListBaiVietByID(num.ToString());
		BaiViet @class = new BaiViet();
		for (int i = 0; i < list.Count; i++)
		{
			if (AC35A006(num.ToString()))
			{
				break;
			}
			@class = list[i];
			dgvBaiVietDaChon.Rows.Add(dgvBaiVietDaChon.Rows.Count + 1, @class.D0B8AABE, @class.Int32_0, @class.String_0, @class.String_1.Split('|').Length - 1, @class.String_2.Split('|').Length - 1);
			list_0.Add(@class.Int32_0.ToString());
		}
		lblCountAcc.Text = dgvBaiVietDaChon.Rows.Count.ToString();
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		try
		{
			int int_ = Convert.ToInt32(dgvDSBaiViet.SelectedRows[0].Cells[2].Value);
			fChiTietBaiViet d0AF = new fChiTietBaiViet(int_);
			d0AF.Show();
		}
		catch
		{
		}
	}

	private void method_2()
	{
		for (int i = 0; i < dgvBaiVietDaChon.RowCount; i++)
		{
			Common.SetStatusDataGridView(dgvBaiVietDaChon, i, "cStt1", i + 1);
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		dgvDSBaiViet.Rows.Clear();
		List<BaiViet> list = CommonSQL.smethod_22(cbbChuDe.SelectedItem.ToString());
		BaiViet @class = new BaiViet();
		for (int i = 0; i < list.Count; i++)
		{
			try
			{
				@class = list[i];
				dgvDSBaiViet.Rows.Add(i + 1, @class.D0B8AABE, @class.Int32_0, @class.String_0, @class.String_1.Split('|').Length - 1, @class.String_2.Split('|').Length - 1);
			}
			catch
			{
			}
		}
	}

	private void C499B513_Click(object sender, EventArgs e)
	{
		E81CD681(F3BE8B18);
	}

	private void BD862699(object sender, EventArgs e)
	{
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		F3BE8B18 = true;
		dgvDSBaiViet.Rows.Clear();
		E81CD681(F3BE8B18);
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void dgvBaiVietDaChon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		foreach (DataGridViewRow selectedRow in dgvBaiVietDaChon.SelectedRows)
		{
			dgvBaiVietDaChon.Rows.RemoveAt(selectedRow.Index);
		}
		lblCountAcc.Text = dgvBaiVietDaChon.Rows.Count.ToString();
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		try
		{
			DataGridViewRow dataGridViewRow = dgvDSBaiViet.SelectedRows[0];
			if (dataGridViewRow != null && MessageBoxHelper.ShowMessages("Bạn có muốn xóa bài viết này không?") == DialogResult.Yes)
			{
				int int_ = Convert.ToInt32(dataGridViewRow.Cells[2].Value);
				CommonSQL.smethod_23(int_);
				dgvDSBaiViet.Rows.Remove(dataGridViewRow);
				method_0();
			}
		}
		catch
		{
		}
	}

	private void dgvDSBaiViet_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
	{
	}

	private void dgvBaiVietDaChon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		method_2();
		lblCountAcc.Text = dgvBaiVietDaChon.Rows.Count.ToString();
	}

	private void dgvBaiVietDaChon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		method_2();
		lblCountAcc.Text = dgvBaiVietDaChon.Rows.Count.ToString();
	}

	private void cbbChuDe_SelectedIndexChanged(object sender, EventArgs e)
	{
		F3BE8B18 = false;
		E81CD681(F3BE8B18);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && E197C735 != null)
		{
			E197C735.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.E197C735 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonBaiViet));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.panel1 = new System.Windows.Forms.Panel();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.A21B3911 = new System.Windows.Forms.Panel();
		this.CB1F5BBD = new System.Windows.Forms.PictureBox();
		this.C29C4201 = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.C8934793 = new System.Windows.Forms.Label();
		this.lblCountAcc = new System.Windows.Forms.Label();
		this.C8B04A9F = new System.Windows.Forms.Label();
		this.dgvBaiVietDaChon = new System.Windows.Forms.DataGridView();
		this.cStt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.B0B30A01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.CBA8BD94 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label2 = new System.Windows.Forms.Label();
		this.metroButton1 = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.cbbChuDe = new System.Windows.Forms.ComboBox();
		this.dgvDSBaiViet = new System.Windows.Forms.DataGridView();
		this.E425F411 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DEB980A9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cIdBaiViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.BAB2C61D = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.E197C735);
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.D3A57B8D = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.C499B513 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		this.btnCancel = new System.Windows.Forms.Button();
		this.C0222896 = new System.Windows.Forms.Button();
		this.DC31600E = new Bunifu.Framework.UI.BunifuDragControl(this.E197C735);
		this.ED1251A7 = new System.Windows.Forms.ToolTip(this.E197C735);
		this.panel1.SuspendLayout();
		this.bunifuCards2.SuspendLayout();
		this.A21B3911.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CB1F5BBD).BeginInit();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvBaiVietDaChon).BeginInit();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvDSBaiViet).BeginInit();
		this.contextMenuStrip1.SuspendLayout();
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
		this.bunifuCards1.Size = new System.Drawing.Size(270, 47);
		this.bunifuCards1.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.C0222896);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(927, 517);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.bunifuCards2.BackColor = System.Drawing.Color.White;
		this.bunifuCards2.BorderRadius = 0;
		this.bunifuCards2.BottomSahddow = true;
		this.bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards2.Controls.Add(this.A21B3911);
		this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards2.LeftSahddow = false;
		this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards2.Name = "bunifuCards2";
		this.bunifuCards2.RightSahddow = true;
		this.bunifuCards2.ShadowDepth = 20;
		this.bunifuCards2.Size = new System.Drawing.Size(925, 37);
		this.bunifuCards2.TabIndex = 43;
		this.A21B3911.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.A21B3911.BackColor = System.Drawing.Color.White;
		this.A21B3911.Controls.Add(this.CB1F5BBD);
		this.A21B3911.Controls.Add(this.C29C4201);
		this.A21B3911.Controls.Add(this.bunifuCustomLabel1);
		this.A21B3911.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.A21B3911.Location = new System.Drawing.Point(0, 3);
		this.A21B3911.Name = "pnlHeader";
		this.A21B3911.Size = new System.Drawing.Size(925, 31);
		this.A21B3911.TabIndex = 9;
		this.CB1F5BBD.Cursor = System.Windows.Forms.Cursors.Default;
		this.CB1F5BBD.Image = Resources.Bitmap_4;
		this.CB1F5BBD.Location = new System.Drawing.Point(0, 4);
		this.CB1F5BBD.Name = "pictureBox1";
		this.CB1F5BBD.Size = new System.Drawing.Size(34, 27);
		this.CB1F5BBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.CB1F5BBD.TabIndex = 76;
		this.CB1F5BBD.TabStop = false;
		this.C29C4201.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C29C4201.FlatAppearance.BorderSize = 0;
		this.C29C4201.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C29C4201.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C29C4201.ForeColor = System.Drawing.Color.White;
		this.C29C4201.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.C29C4201.Location = new System.Drawing.Point(896, 3);
		this.C29C4201.Name = "btnMinimize";
		this.C29C4201.Size = new System.Drawing.Size(30, 30);
		this.C29C4201.TabIndex = 9;
		this.C29C4201.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.C29C4201.UseVisualStyleBackColor = true;
		this.C29C4201.Click += new System.EventHandler(btnCancel_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(925, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Chọn bình luận";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.groupBox2.BackColor = System.Drawing.Color.White;
		this.groupBox2.Controls.Add(this.C8934793);
		this.groupBox2.Controls.Add(this.lblCountAcc);
		this.groupBox2.Controls.Add(this.C8B04A9F);
		this.groupBox2.Controls.Add(this.dgvBaiVietDaChon);
		this.groupBox2.Location = new System.Drawing.Point(465, 40);
		this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
		this.groupBox2.Size = new System.Drawing.Size(454, 423);
		this.groupBox2.TabIndex = 41;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Bình luận cần sử dụng";
		this.C8934793.AutoSize = true;
		this.C8934793.ForeColor = System.Drawing.Color.Red;
		this.C8934793.Location = new System.Drawing.Point(6, 401);
		this.C8934793.Name = "label3";
		this.C8934793.Size = new System.Drawing.Size(166, 16);
		this.C8934793.TabIndex = 80;
		this.C8934793.Text = "(Click đúp vào dòng để xóa)";
		this.lblCountAcc.AutoSize = true;
		this.lblCountAcc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.lblCountAcc.ForeColor = System.Drawing.Color.Blue;
		this.lblCountAcc.Location = new System.Drawing.Point(349, 401);
		this.lblCountAcc.Name = "lblCountAcc";
		this.lblCountAcc.Size = new System.Drawing.Size(15, 16);
		this.lblCountAcc.TabIndex = 78;
		this.lblCountAcc.Text = "0";
		this.C8B04A9F.AutoSize = true;
		this.C8B04A9F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.C8B04A9F.Location = new System.Drawing.Point(307, 401);
		this.C8B04A9F.Name = "label7";
		this.C8B04A9F.Size = new System.Drawing.Size(43, 16);
		this.C8B04A9F.TabIndex = 79;
		this.C8B04A9F.Text = "Tổng:";
		this.dgvBaiVietDaChon.AllowUserToAddRows = false;
		this.dgvBaiVietDaChon.AllowUserToDeleteRows = false;
		this.dgvBaiVietDaChon.AllowUserToResizeRows = false;
		this.dgvBaiVietDaChon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dgvBaiVietDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dgvBaiVietDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvBaiVietDaChon.Columns.AddRange(this.cStt1, this.dataGridViewTextBoxColumn2, this.cId, this.B0B30A01, this.CBA8BD94, this.Column1);
		this.dgvBaiVietDaChon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dgvBaiVietDaChon.Location = new System.Drawing.Point(6, 52);
		this.dgvBaiVietDaChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.dgvBaiVietDaChon.MultiSelect = false;
		this.dgvBaiVietDaChon.Name = "dgvBaiVietDaChon";
		this.dgvBaiVietDaChon.RowHeadersVisible = false;
		this.dgvBaiVietDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvBaiVietDaChon.Size = new System.Drawing.Size(444, 345);
		this.dgvBaiVietDaChon.TabIndex = 76;
		this.dgvBaiVietDaChon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvBaiVietDaChon_CellDoubleClick);
		this.dgvBaiVietDaChon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(dgvBaiVietDaChon_RowsAdded);
		this.dgvBaiVietDaChon.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(dgvBaiVietDaChon_RowsRemoved);
		this.cStt1.HeaderText = "STT";
		this.cStt1.Name = "cStt1";
		this.cStt1.Width = 35;
		this.dataGridViewTextBoxColumn2.HeaderText = "Chủ đề";
		this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
		this.cId.HeaderText = "ID Bài viết";
		this.cId.Name = "cId";
		this.cId.Visible = false;
		this.cId.Width = 90;
		this.B0B30A01.HeaderText = "Tiêu đề";
		this.B0B30A01.Name = "dataGridViewTextBoxColumn4";
		this.B0B30A01.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.B0B30A01.Width = 230;
		this.CBA8BD94.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.CBA8BD94.HeaderText = "Ảnh";
		this.CBA8BD94.Name = "dataGridViewTextBoxColumn5";
		this.Column1.HeaderText = "Video";
		this.Column1.Name = "Column1";
		this.Column1.Visible = false;
		this.Column1.Width = 50;
		this.groupBox1.BackColor = System.Drawing.Color.White;
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.metroButton1);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.cbbChuDe);
		this.groupBox1.Controls.Add(this.dgvDSBaiViet);
		this.groupBox1.Location = new System.Drawing.Point(3, 39);
		this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
		this.groupBox1.Size = new System.Drawing.Size(456, 423);
		this.groupBox1.TabIndex = 42;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Danh sách bình luận";
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.Red;
		this.label2.Location = new System.Drawing.Point(7, 401);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(173, 16);
		this.label2.TabIndex = 80;
		this.label2.Text = "(Click đúp vào dòng để chọn)";
		this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton1.Location = new System.Drawing.Point(341, 23);
		this.metroButton1.Name = "metroButton1";
		this.metroButton1.Size = new System.Drawing.Size(109, 25);
		this.metroButton1.TabIndex = 79;
		this.metroButton1.Text = "Quản lý chủ đề";
		this.metroButton1.Click += new System.EventHandler(metroButton1_Click);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(8, 27);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(52, 16);
		this.label1.TabIndex = 78;
		this.label1.Text = "Chủ đề:";
		this.cbbChuDe.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbChuDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbChuDe.FormattingEnabled = true;
		this.cbbChuDe.Location = new System.Drawing.Point(64, 23);
		this.cbbChuDe.Name = "cbbChuDe";
		this.cbbChuDe.Size = new System.Drawing.Size(271, 24);
		this.cbbChuDe.TabIndex = 77;
		this.cbbChuDe.SelectedIndexChanged += new System.EventHandler(cbbChuDe_SelectedIndexChanged);
		this.dgvDSBaiViet.AllowUserToAddRows = false;
		this.dgvDSBaiViet.AllowUserToDeleteRows = false;
		this.dgvDSBaiViet.AllowUserToResizeRows = false;
		this.dgvDSBaiViet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dgvDSBaiViet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.dgvDSBaiViet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvDSBaiViet.Columns.AddRange(this.E425F411, this.DEB980A9, this.cIdBaiViet, this.cTieuDe, this.BAB2C61D, this.cVideo);
		this.dgvDSBaiViet.ContextMenuStrip = this.contextMenuStrip1;
		this.dgvDSBaiViet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dgvDSBaiViet.Location = new System.Drawing.Point(10, 54);
		this.dgvDSBaiViet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.dgvDSBaiViet.MultiSelect = false;
		this.dgvDSBaiViet.Name = "dgvDSBaiViet";
		this.dgvDSBaiViet.RowHeadersVisible = false;
		this.dgvDSBaiViet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvDSBaiViet.Size = new System.Drawing.Size(440, 343);
		this.dgvDSBaiViet.TabIndex = 76;
		this.dgvDSBaiViet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvDSBaiViet_CellContentClick);
		this.dgvDSBaiViet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(A60AD615);
		this.E425F411.HeaderText = "STT";
		this.E425F411.Name = "cStt";
		this.E425F411.Width = 35;
		this.DEB980A9.HeaderText = "Chủ đề";
		this.DEB980A9.Name = "cChuDe";
		this.cIdBaiViet.HeaderText = "ID Bài viết";
		this.cIdBaiViet.Name = "cIdBaiViet";
		this.cIdBaiViet.Visible = false;
		this.cIdBaiViet.Width = 90;
		this.cTieuDe.HeaderText = "Tiêu đề";
		this.cTieuDe.Name = "cTieuDe";
		this.cTieuDe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cTieuDe.Width = 230;
		this.BAB2C61D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.BAB2C61D.HeaderText = "Ảnh";
		this.BAB2C61D.Name = "cAnh";
		this.cVideo.HeaderText = "Video";
		this.cVideo.Name = "cVideo";
		this.cVideo.Visible = false;
		this.cVideo.Width = 50;
		this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.toolStripMenuItem_0, this.D3A57B8D, this.toolStripMenuItem_1, this.toolStripMenuItem_2, this.C499B513, this.toolStripMenuItem_3 });
		this.contextMenuStrip1.Name = "contextMenuStrip1";
		this.contextMenuStrip1.Size = new System.Drawing.Size(202, 136);
		this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(contextMenuStrip1_Opening);
		this.toolStripMenuItem_0.Name = "thêmBàiViếtToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_0.Text = "Thêm bình luận";
		this.toolStripMenuItem_0.Click += new System.EventHandler(FCB9DFB4);
		this.D3A57B8D.Name = "sửaBàiViếtToolStripMenuItem";
		this.D3A57B8D.Size = new System.Drawing.Size(201, 22);
		this.D3A57B8D.Text = "Sửa bình luận";
		this.D3A57B8D.Click += new System.EventHandler(D3A57B8D_Click);
		this.toolStripMenuItem_1.Name = "xóaBàiViếtToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_1.Text = "Xóa bình luận";
		this.toolStripMenuItem_1.Click += new System.EventHandler(toolStripMenuItem_1_Click);
		this.toolStripMenuItem_2.Name = "chiTiếtBàiViếtToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_2.Text = "Chi tiết bình luận";
		this.toolStripMenuItem_2.Click += new System.EventHandler(toolStripMenuItem_2_Click);
		this.C499B513.Name = "làmMớiDanhSáchToolStripMenuItem";
		this.C499B513.Size = new System.Drawing.Size(201, 22);
		this.C499B513.Text = "Làm mới danh sách";
		this.C499B513.Click += new System.EventHandler(C499B513_Click);
		this.toolStripMenuItem_3.Name = "hiểnThịTấtCảBàiViếtToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new System.Drawing.Size(201, 22);
		this.toolStripMenuItem_3.Text = "Hiển thị tất cả bình luận";
		this.toolStripMenuItem_3.Click += new System.EventHandler(toolStripMenuItem_3_Click);
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(468, 473);
		this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 20;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.C0222896.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.C0222896.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C0222896.FlatAppearance.BorderSize = 0;
		this.C0222896.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C0222896.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C0222896.ForeColor = System.Drawing.Color.White;
		this.C0222896.Location = new System.Drawing.Point(361, 473);
		this.C0222896.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.C0222896.Name = "btnSave";
		this.C0222896.Size = new System.Drawing.Size(92, 29);
		this.C0222896.TabIndex = 19;
		this.C0222896.Text = "Lưu";
		this.C0222896.UseVisualStyleBackColor = false;
		this.C0222896.Click += new System.EventHandler(C0222896_Click);
		this.DC31600E.Fixed = true;
		this.DC31600E.Horizontal = true;
		this.DC31600E.TargetControl = this.bunifuCustomLabel1;
		this.DC31600E.Vertical = true;
		this.ED1251A7.AutomaticDelay = 0;
		this.ED1251A7.AutoPopDelay = 10000;
		this.ED1251A7.InitialDelay = 200;
		this.ED1251A7.ReshowDelay = 40;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(927, 517);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fChonBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fChonBaiViet_Load);
		this.panel1.ResumeLayout(false);
		this.bunifuCards2.ResumeLayout(false);
		this.A21B3911.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.CB1F5BBD).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvBaiVietDaChon).EndInit();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvDSBaiViet).EndInit();
		this.contextMenuStrip1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
