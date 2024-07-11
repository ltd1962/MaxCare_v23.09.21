using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDHuyLoiMoiKetBan : Form
{
	private JObject jobject_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int F5386293;

	public static bool BD36041F;

	private IContainer C4083A3D = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel C9BDC692;

	private NumericUpDown DA8358B5;

	private NumericUpDown E538E00A;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label D70CEB05;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel C33D19A4;

	private Button EE3BC7A6;

	private PictureBox pictureBox1;

	private BunifuCustomLabel D3AD0F0B;

	private NumericUpDown CA9DF205;

	private NumericUpDown nudDelayFrom;

	private Label F73CEE07;

	private Label label6;

	private Label label5;

	public fHDHuyLoiMoiKetBan(string string_3, int int_0 = 0, string string_4 = "")
	{
		InitializeComponent();
		BD36041F = false;
		string_0 = string_3;
		string_2 = string_4;
		F5386293 = int_0;
		string json = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDHuyLoiMoiKetBan");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_4);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(D3AD0F0B);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(D70CEB05);
		Language.smethod_0(label5);
		Language.smethod_0(F73CEE07);
		Language.smethod_0(label6);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void D8BD6D22_Load(object sender, EventArgs e)
	{
		try
		{
			E538E00A.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			DA8358B5.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			CA9DF205.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
		}
		catch
		{
		}
	}

	private void EE3BC7A6_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", E538E00A.Value);
		gClass.GetJson("nudSoLuongTo", DA8358B5.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", CA9DF205.Value);
		string string_ = gClass.D9A09B34();
		if (F5386293 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					BD36041F = true;
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
			if (InteractSQL.smethod_13(string_2, text, string_))
			{
				BD36041F = true;
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

	private void D41ADB09(object sender, PaintEventArgs e)
	{
		if (C9BDC692.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C9BDC692.ClientSize.Width - num, C9BDC692.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && C4083A3D != null)
		{
			C4083A3D.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.C4083A3D = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDHuyLoiMoiKetBan));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.C4083A3D);
		this.D3AD0F0B = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.C4083A3D);
		this.C33D19A4 = new System.Windows.Forms.Panel();
		this.EE3BC7A6 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.C9BDC692 = new System.Windows.Forms.Panel();
		this.CA9DF205 = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.F73CEE07 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.DA8358B5 = new System.Windows.Forms.NumericUpDown();
		this.E538E00A = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.D70CEB05 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.C33D19A4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.C9BDC692.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CA9DF205).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DA8358B5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.E538E00A).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.D3AD0F0B;
		this.bunifuDragControl_0.Vertical = true;
		this.D3AD0F0B.BackColor = System.Drawing.Color.Transparent;
		this.D3AD0F0B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.D3AD0F0B.Dock = System.Windows.Forms.DockStyle.Fill;
		this.D3AD0F0B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D3AD0F0B.ForeColor = System.Drawing.Color.Black;
		this.D3AD0F0B.Location = new System.Drawing.Point(0, 0);
		this.D3AD0F0B.Name = "bunifuCustomLabel1";
		this.D3AD0F0B.Size = new System.Drawing.Size(359, 31);
		this.D3AD0F0B.TabIndex = 12;
		this.D3AD0F0B.Text = "Cấu hình Hủy lời mời kết bạn";
		this.D3AD0F0B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.C33D19A4;
		this.bunifuDragControl_1.Vertical = true;
		this.C33D19A4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.C33D19A4.BackColor = System.Drawing.Color.White;
		this.C33D19A4.Controls.Add(this.EE3BC7A6);
		this.C33D19A4.Controls.Add(this.pictureBox1);
		this.C33D19A4.Controls.Add(this.D3AD0F0B);
		this.C33D19A4.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.C33D19A4.Location = new System.Drawing.Point(0, 3);
		this.C33D19A4.Name = "pnlHeader";
		this.C33D19A4.Size = new System.Drawing.Size(359, 31);
		this.C33D19A4.TabIndex = 9;
		this.EE3BC7A6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.EE3BC7A6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EE3BC7A6.FlatAppearance.BorderSize = 0;
		this.EE3BC7A6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.EE3BC7A6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EE3BC7A6.ForeColor = System.Drawing.Color.White;
		this.EE3BC7A6.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.EE3BC7A6.Location = new System.Drawing.Point(328, 1);
		this.EE3BC7A6.Name = "button1";
		this.EE3BC7A6.Size = new System.Drawing.Size(30, 30);
		this.EE3BC7A6.TabIndex = 77;
		this.EE3BC7A6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.EE3BC7A6.UseVisualStyleBackColor = true;
		this.EE3BC7A6.Click += new System.EventHandler(EE3BC7A6_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.C9BDC692.BackColor = System.Drawing.Color.White;
		this.C9BDC692.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C9BDC692.Controls.Add(this.CA9DF205);
		this.C9BDC692.Controls.Add(this.nudDelayFrom);
		this.C9BDC692.Controls.Add(this.F73CEE07);
		this.C9BDC692.Controls.Add(this.label6);
		this.C9BDC692.Controls.Add(this.label5);
		this.C9BDC692.Controls.Add(this.DA8358B5);
		this.C9BDC692.Controls.Add(this.E538E00A);
		this.C9BDC692.Controls.Add(this.txtTenHanhDong);
		this.C9BDC692.Controls.Add(this.label3);
		this.C9BDC692.Controls.Add(this.D70CEB05);
		this.C9BDC692.Controls.Add(this.label2);
		this.C9BDC692.Controls.Add(this.label1);
		this.C9BDC692.Controls.Add(this.btnCancel);
		this.C9BDC692.Controls.Add(this.btnAdd);
		this.C9BDC692.Controls.Add(this.bunifuCards1);
		this.C9BDC692.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.C9BDC692.Dock = System.Windows.Forms.DockStyle.Fill;
		this.C9BDC692.Location = new System.Drawing.Point(0, 0);
		this.C9BDC692.Name = "panel1";
		this.C9BDC692.Size = new System.Drawing.Size(362, 206);
		this.C9BDC692.TabIndex = 0;
		this.C9BDC692.Paint += new System.Windows.Forms.PaintEventHandler(D41ADB09);
		this.CA9DF205.Location = new System.Drawing.Point(223, 112);
		this.CA9DF205.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.CA9DF205.Name = "nudDelayTo";
		this.CA9DF205.Size = new System.Drawing.Size(56, 23);
		this.CA9DF205.TabIndex = 4;
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 112);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.F73CEE07.Location = new System.Drawing.Point(191, 114);
		this.F73CEE07.Name = "label7";
		this.F73CEE07.Size = new System.Drawing.Size(29, 16);
		this.F73CEE07.TabIndex = 46;
		this.F73CEE07.Text = "đê\u0301n";
		this.F73CEE07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(280, 114);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 114);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.DA8358B5.Location = new System.Drawing.Point(223, 81);
		this.DA8358B5.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.DA8358B5.Name = "nudSoLuongTo";
		this.DA8358B5.Size = new System.Drawing.Size(56, 23);
		this.DA8358B5.TabIndex = 2;
		this.E538E00A.Location = new System.Drawing.Point(132, 81);
		this.E538E00A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.E538E00A.Name = "nudSoLuongFrom";
		this.E538E00A.Size = new System.Drawing.Size(56, 23);
		this.E538E00A.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(191, 83);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D70CEB05.AutoSize = true;
		this.D70CEB05.Location = new System.Drawing.Point(280, 83);
		this.D70CEB05.Name = "label4";
		this.D70CEB05.Size = new System.Drawing.Size(45, 16);
		this.D70CEB05.TabIndex = 35;
		this.D70CEB05.Text = "lời mời";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 83);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(63, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng:";
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
		this.btnCancel.Location = new System.Drawing.Point(191, 158);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(84, 158);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.C33D19A4);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 206);
		base.Controls.Add(this.C9BDC692);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDHuyLoiMoiKetBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(D8BD6D22_Load);
		this.C33D19A4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.C9BDC692.ResumeLayout(false);
		this.C9BDC692.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.CA9DF205).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DA8358B5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.E538E00A).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
