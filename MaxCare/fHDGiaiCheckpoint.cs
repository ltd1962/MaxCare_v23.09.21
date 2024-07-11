using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDGiaiCheckpoint : Form
{
	private JSON_Settings D4211E3B;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer C019CB81 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label EF8F5E0A;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards DB1F5A0E;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox ED00CE21;

	private BunifuCustomLabel B09DBF9D;

	private CheckBox B3B0BC97;

	private TextBox txtImage;

	private CheckBox ckbImage;

	private TextBox txtPhone;

	private CheckBox ckbPhone;

	private TextBox EC3EEF15;

	public fHDGiaiCheckpoint(string string_3, int A511E61C = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = A511E61C;
		if (InteractSQL.B484648C("", "HDGiaiCheckpoint").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDGiaiCheckpoint', 'Giải checkpoint');");
		}
		string text = "";
		switch (A511E61C)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDGiaiCheckpoint");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_4);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		D4211E3B = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void E0BD071C()
	{
		Language.smethod_0(B09DBF9D);
		Language.smethod_0(EF8F5E0A);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void E62089B2(object sender, EventArgs e)
	{
		try
		{
			B3B0BC97.Checked = D4211E3B.GetValueBool("ckbCaptcha");
			EC3EEF15.Text = D4211E3B.GetValue("txtCaptcha");
			ckbPhone.Checked = D4211E3B.GetValueBool("ckbPhone");
			txtPhone.Text = D4211E3B.GetValue("txtPhone");
			ckbImage.Checked = D4211E3B.GetValueBool("ckbImage");
			txtImage.Text = D4211E3B.GetValue("txtImage");
		}
		catch
		{
		}
		method_0();
	}

	private void button1_Click(object sender, EventArgs e)
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
		gClass.GetJson("ckbCaptcha", B3B0BC97.Checked);
		gClass.GetJson("txtCaptcha", EC3EEF15.Text);
		gClass.GetJson("ckbPhone", ckbPhone.Checked);
		gClass.GetJson("txtPhone", txtPhone.Text);
		gClass.GetJson("ckbImage", ckbImage.Checked);
		gClass.GetJson("txtImage", txtImage.Text);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					bool_0 = true;
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
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void method_0()
	{
		B3B0BC97_CheckedChanged(null, null);
		CE863187(null, null);
		ckbImage_CheckedChanged(null, null);
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BC06F9A6(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void B3B0BC97_CheckedChanged(object sender, EventArgs e)
	{
		EC3EEF15.Enabled = B3B0BC97.Checked;
	}

	private void CE863187(object sender, EventArgs e)
	{
		txtPhone.Enabled = ckbPhone.Checked;
	}

	private void ckbImage_CheckedChanged(object sender, EventArgs e)
	{
		txtImage.Enabled = ckbImage.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && C019CB81 != null)
		{
			C019CB81.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.C019CB81 = new System.ComponentModel.Container();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.C019CB81);
		this.B09DBF9D = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.C019CB81);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.ED00CE21 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.txtImage = new System.Windows.Forms.TextBox();
		this.ckbImage = new System.Windows.Forms.CheckBox();
		this.txtPhone = new System.Windows.Forms.TextBox();
		this.ckbPhone = new System.Windows.Forms.CheckBox();
		this.EC3EEF15 = new System.Windows.Forms.TextBox();
		this.B3B0BC97 = new System.Windows.Forms.CheckBox();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.EF8F5E0A = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.DB1F5A0E = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ED00CE21).BeginInit();
		this.panel1.SuspendLayout();
		this.DB1F5A0E.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.B09DBF9D;
		this.bunifuDragControl_0.Vertical = true;
		this.B09DBF9D.BackColor = System.Drawing.Color.Transparent;
		this.B09DBF9D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.B09DBF9D.Dock = System.Windows.Forms.DockStyle.Fill;
		this.B09DBF9D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B09DBF9D.ForeColor = System.Drawing.Color.Black;
		this.B09DBF9D.Location = new System.Drawing.Point(0, 0);
		this.B09DBF9D.Name = "bunifuCustomLabel1";
		this.B09DBF9D.Size = new System.Drawing.Size(359, 31);
		this.B09DBF9D.TabIndex = 12;
		this.B09DBF9D.Text = "Cấu hình Giải Checkpoint";
		this.B09DBF9D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.ED00CE21);
		this.pnlHeader.Controls.Add(this.B09DBF9D);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = Resources.A13F2207;
		this.button1.Location = new System.Drawing.Point(328, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.ED00CE21.Cursor = System.Windows.Forms.Cursors.Default;
		this.ED00CE21.Image = Resources.Bitmap_4;
		this.ED00CE21.Location = new System.Drawing.Point(3, 2);
		this.ED00CE21.Name = "pictureBox1";
		this.ED00CE21.Size = new System.Drawing.Size(34, 27);
		this.ED00CE21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ED00CE21.TabIndex = 76;
		this.ED00CE21.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.txtImage);
		this.panel1.Controls.Add(this.ckbImage);
		this.panel1.Controls.Add(this.txtPhone);
		this.panel1.Controls.Add(this.ckbPhone);
		this.panel1.Controls.Add(this.EC3EEF15);
		this.panel1.Controls.Add(this.B3B0BC97);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.EF8F5E0A);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.DB1F5A0E);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 222);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(BC06F9A6);
		this.txtImage.Location = new System.Drawing.Point(122, 138);
		this.txtImage.Name = "txtImage";
		this.txtImage.Size = new System.Drawing.Size(220, 23);
		this.txtImage.TabIndex = 37;
		this.ckbImage.AutoSize = true;
		this.ckbImage.Location = new System.Drawing.Point(20, 140);
		this.ckbImage.Name = "ckbImage";
		this.ckbImage.Size = new System.Drawing.Size(72, 20);
		this.ckbImage.TabIndex = 36;
		this.ckbImage.Text = "Up ảnh:";
		this.ckbImage.UseVisualStyleBackColor = true;
		this.ckbImage.CheckedChanged += new System.EventHandler(ckbImage_CheckedChanged);
		this.txtPhone.Location = new System.Drawing.Point(122, 109);
		this.txtPhone.Name = "txtPhone";
		this.txtPhone.Size = new System.Drawing.Size(220, 23);
		this.txtPhone.TabIndex = 35;
		this.ckbPhone.AutoSize = true;
		this.ckbPhone.Location = new System.Drawing.Point(20, 111);
		this.ckbPhone.Name = "ckbPhone";
		this.ckbPhone.Size = new System.Drawing.Size(94, 20);
		this.ckbPhone.TabIndex = 34;
		this.ckbPhone.Text = "Thêm SĐT:";
		this.ckbPhone.UseVisualStyleBackColor = true;
		this.ckbPhone.CheckedChanged += new System.EventHandler(CE863187);
		this.EC3EEF15.Location = new System.Drawing.Point(122, 80);
		this.EC3EEF15.Name = "txtCaptcha";
		this.EC3EEF15.Size = new System.Drawing.Size(220, 23);
		this.EC3EEF15.TabIndex = 33;
		this.B3B0BC97.AutoSize = true;
		this.B3B0BC97.Location = new System.Drawing.Point(20, 82);
		this.B3B0BC97.Name = "ckbCaptcha";
		this.B3B0BC97.Size = new System.Drawing.Size(101, 20);
		this.B3B0BC97.TabIndex = 32;
		this.B3B0BC97.Text = "Giải captcha:";
		this.B3B0BC97.UseVisualStyleBackColor = true;
		this.B3B0BC97.CheckedChanged += new System.EventHandler(B3B0BC97_CheckedChanged);
		this.txtTenHanhDong.Location = new System.Drawing.Point(122, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(220, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.EF8F5E0A.AutoSize = true;
		this.EF8F5E0A.Location = new System.Drawing.Point(17, 52);
		this.EF8F5E0A.Name = "label1";
		this.EF8F5E0A.Size = new System.Drawing.Size(99, 16);
		this.EF8F5E0A.TabIndex = 31;
		this.EF8F5E0A.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(191, 180);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(84, 180);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.DB1F5A0E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.DB1F5A0E.BackColor = System.Drawing.Color.White;
		this.DB1F5A0E.BorderRadius = 0;
		this.DB1F5A0E.BottomSahddow = true;
		this.DB1F5A0E.color = System.Drawing.Color.DarkViolet;
		this.DB1F5A0E.Controls.Add(this.pnlHeader);
		this.DB1F5A0E.LeftSahddow = false;
		this.DB1F5A0E.Location = new System.Drawing.Point(1, 0);
		this.DB1F5A0E.Name = "bunifuCards1";
		this.DB1F5A0E.RightSahddow = true;
		this.DB1F5A0E.ShadowDepth = 20;
		this.DB1F5A0E.Size = new System.Drawing.Size(359, 37);
		this.DB1F5A0E.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 222);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDGiaiCheckpoint";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(E62089B2);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.ED00CE21).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.DB1F5A0E.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
