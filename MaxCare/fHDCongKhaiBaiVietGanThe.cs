using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Bunifu.Framework.UI;

public class fHDCongKhaiBaiVietGanThe : Form
{
	private JSON_Settings F7957917 = null;

	private string D4340CB3;

	private string string_0;

	private string B41F7518;

	private int int_0;

	public static bool A982A002;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button FA8F8BB6;

	private BunifuCards bunifuCards1;

	private Panel F8088088;

	private Button F30DB9BF;

	private PictureBox FB0EE21B;

	private BunifuCustomLabel bunifuCustomLabel1;

	public fHDCongKhaiBaiVietGanThe(string A215AC2C, int int_1 = 0, string C30DE491 = "")
	{
		InitializeComponent();
		A982A002 = false;
		D4340CB3 = A215AC2C;
		B41F7518 = C30DE491;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDCongKhaiBaiVietGanThe").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDCongKhaiBaiVietGanThe', 'Công khai bài viết gắn thẻ');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDCongKhaiBaiVietGanThe");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(C30DE491);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			FA8F8BB6.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F7957917 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(FA8F8BB6);
		Language.smethod_0(btnCancel);
	}

	private void C825AA10(object sender, EventArgs e)
	{
		try
		{
		}
		catch
		{
		}
	}

	private void F30DB9BF_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FA8F8BB6_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(D4340CB3, text, string_0, text2))
				{
					A982A002 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(B41F7518, text, text2))
			{
				A982A002 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool D68EC9B8)
	{
		if (D68EC9B8 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D68EC9B8);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDCongKhaiBaiVietGanThe));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.F8088088 = new System.Windows.Forms.Panel();
		this.F30DB9BF = new System.Windows.Forms.Button();
		this.FB0EE21B = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.FA8F8BB6 = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.F8088088.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.FB0EE21B).BeginInit();
		this.panel1.SuspendLayout();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Công khai bài viết gắn thẻ";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.F8088088;
		this.bunifuDragControl_1.Vertical = true;
		this.F8088088.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.F8088088.BackColor = System.Drawing.Color.White;
		this.F8088088.Controls.Add(this.F30DB9BF);
		this.F8088088.Controls.Add(this.FB0EE21B);
		this.F8088088.Controls.Add(this.bunifuCustomLabel1);
		this.F8088088.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.F8088088.Location = new System.Drawing.Point(0, 3);
		this.F8088088.Name = "pnlHeader";
		this.F8088088.Size = new System.Drawing.Size(359, 31);
		this.F8088088.TabIndex = 9;
		this.F30DB9BF.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.F30DB9BF.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F30DB9BF.FlatAppearance.BorderSize = 0;
		this.F30DB9BF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F30DB9BF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.F30DB9BF.ForeColor = System.Drawing.Color.White;
		this.F30DB9BF.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.F30DB9BF.Location = new System.Drawing.Point(328, 1);
		this.F30DB9BF.Name = "button1";
		this.F30DB9BF.Size = new System.Drawing.Size(30, 30);
		this.F30DB9BF.TabIndex = 77;
		this.F30DB9BF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.F30DB9BF.UseVisualStyleBackColor = true;
		this.F30DB9BF.Click += new System.EventHandler(F30DB9BF_Click);
		this.FB0EE21B.Cursor = System.Windows.Forms.Cursors.Default;
		this.FB0EE21B.Image = Resources.Bitmap_4;
		this.FB0EE21B.Location = new System.Drawing.Point(3, 2);
		this.FB0EE21B.Name = "pictureBox1";
		this.FB0EE21B.Size = new System.Drawing.Size(34, 27);
		this.FB0EE21B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.FB0EE21B.TabIndex = 76;
		this.FB0EE21B.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.FA8F8BB6);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 160);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(189, 116);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.FA8F8BB6.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.FA8F8BB6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FA8F8BB6.FlatAppearance.BorderSize = 0;
		this.FA8F8BB6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.FA8F8BB6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FA8F8BB6.ForeColor = System.Drawing.Color.White;
		this.FA8F8BB6.Location = new System.Drawing.Point(82, 116);
		this.FA8F8BB6.Name = "btnAdd";
		this.FA8F8BB6.Size = new System.Drawing.Size(92, 29);
		this.FA8F8BB6.TabIndex = 9;
		this.FA8F8BB6.Text = "Thêm";
		this.FA8F8BB6.UseVisualStyleBackColor = false;
		this.FA8F8BB6.Click += new System.EventHandler(FA8F8BB6_Click);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.F8088088);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 160);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDCongKhaiBaiVietGanThe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(C825AA10);
		this.F8088088.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.FB0EE21B).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
