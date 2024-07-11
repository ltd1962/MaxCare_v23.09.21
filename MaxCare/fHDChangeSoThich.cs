using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDChangeSoThich : Form
{
	private JSON_Settings gclass8_0 = null;

	private string D636D52C;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer AD9CA819 = null;

	private BunifuDragControl F1B521B9;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label EE9F5528;

	private Label label6;

	private Label label5;

	private Label FB990588;

	private Button C28E24BD;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox C6B20985;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown B1B532BD;

	private Label E9265A1B;

	private Label label4;

	private Label label3;

	private RichTextBox txtTuKhoa;

	private Label label2;

	public fHDChangeSoThich(string D692BD1C, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		D636D52C = D692BD1C;
		string_1 = string_2;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDChangeSoThich").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDChangeSoThich', 'Thay đổi sở thích');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDChangeSoThich");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void E395EDBC()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(FB990588);
		Language.smethod_0(label5);
		Language.smethod_0(EE9F5528);
		Language.smethod_0(label6);
		Language.smethod_0(btnAdd);
		Language.smethod_0(C28E24BD);
	}

	private void A1909B01(object sender, EventArgs e)
	{
		try
		{
			B1B532BD.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 1);
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			txtTuKhoa.Text = gclass8_0.GetValue("txtTuKhoa");
		}
		catch
		{
		}
		txtTuKhoa_TextChanged(null, null);
	}

	private void A638202D(object sender, EventArgs e)
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
		gClass.GetJson("nudSoLuongFrom", B1B532BD.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("txtTuKhoa", txtTuKhoa.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(D636D52C, text, string_0, string_))
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
			if (InteractSQL.smethod_13(string_1, text, string_))
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

	private void D282060F(object sender, EventArgs e)
	{
		Close();
	}

	private void B4956730(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void txtTuKhoa_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtTuKhoa.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			label2.Text = string.Format(Language.GetValue("Danh sa\u0301ch từ khóa ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool E19E5328)
	{
		if (E19E5328 && AD9CA819 != null)
		{
			AD9CA819.Dispose();
		}
		base.Dispose(E19E5328);
	}

	private void InitializeComponent()
	{
		this.AD9CA819 = new System.ComponentModel.Container();
		this.F1B521B9 = new Bunifu.Framework.UI.BunifuDragControl(this.AD9CA819);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.AD9CA819);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.C6B20985 = new System.Windows.Forms.PictureBox();
		this.button1 = new System.Windows.Forms.Button();
		this.panel1 = new System.Windows.Forms.Panel();
		this.txtTuKhoa = new System.Windows.Forms.RichTextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.B1B532BD = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.E9265A1B = new System.Windows.Forms.Label();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.EE9F5528 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.FB990588 = new System.Windows.Forms.Label();
		this.C28E24BD = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.C6B20985).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.B1B532BD).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.F1B521B9.Fixed = true;
		this.F1B521B9.Horizontal = true;
		this.F1B521B9.TargetControl = this.bunifuCustomLabel1;
		this.F1B521B9.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(357, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Thay đổi sở thích";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.C6B20985);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(357, 31);
		this.pnlHeader.TabIndex = 9;
		this.C6B20985.Cursor = System.Windows.Forms.Cursors.Default;
		this.C6B20985.Image = Resources.Bitmap_4;
		this.C6B20985.Location = new System.Drawing.Point(3, 2);
		this.C6B20985.Name = "pictureBox1";
		this.C6B20985.Size = new System.Drawing.Size(34, 27);
		this.C6B20985.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.C6B20985.TabIndex = 76;
		this.C6B20985.TabStop = false;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = Resources.C400940B;
		this.button1.Location = new System.Drawing.Point(324, 5);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(A638202D);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.txtTuKhoa);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.B1B532BD);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.E9265A1B);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.EE9F5528);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.FB990588);
		this.panel1.Controls.Add(this.C28E24BD);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(359, 418);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(B4956730);
		this.txtTuKhoa.Location = new System.Drawing.Point(30, 156);
		this.txtTuKhoa.Name = "txtTuKhoa";
		this.txtTuKhoa.Size = new System.Drawing.Size(296, 201);
		this.txtTuKhoa.TabIndex = 41;
		this.txtTuKhoa.Text = "";
		this.txtTuKhoa.WordWrap = false;
		this.txtTuKhoa.TextChanged += new System.EventHandler(txtTuKhoa_TextChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 136);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(139, 16);
		this.label2.TabIndex = 43;
		this.label2.Text = "Danh sa\u0301ch từ khóa (0):";
		this.nudSoLuongTo.Location = new System.Drawing.Point(216, 78);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 4;
		this.nudDelayTo.Location = new System.Drawing.Point(216, 107);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.B1B532BD.Location = new System.Drawing.Point(132, 78);
		this.B1B532BD.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.B1B532BD.Name = "nudSoLuongFrom";
		this.B1B532BD.Size = new System.Drawing.Size(56, 23);
		this.B1B532BD.TabIndex = 3;
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 107);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.E9265A1B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E9265A1B.Location = new System.Drawing.Point(188, 80);
		this.E9265A1B.Name = "label8";
		this.E9265A1B.Size = new System.Drawing.Size(29, 16);
		this.E9265A1B.TabIndex = 38;
		this.E9265A1B.Text = ">";
		this.E9265A1B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(274, 80);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(51, 16);
		this.label4.TabIndex = 36;
		this.label4.Text = "sở thích";
		this.EE9F5528.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.EE9F5528.Location = new System.Drawing.Point(188, 109);
		this.EE9F5528.Name = "label7";
		this.EE9F5528.Size = new System.Drawing.Size(29, 16);
		this.EE9F5528.TabIndex = 38;
		this.EE9F5528.Text = ">";
		this.EE9F5528.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(274, 109);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(27, 80);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(63, 16);
		this.label3.TabIndex = 34;
		this.label3.Text = "Số lượng:";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 109);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.FB990588.AutoSize = true;
		this.FB990588.Location = new System.Drawing.Point(27, 52);
		this.FB990588.Name = "label1";
		this.FB990588.Size = new System.Drawing.Size(98, 16);
		this.FB990588.TabIndex = 31;
		this.FB990588.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.C28E24BD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.C28E24BD.BackColor = System.Drawing.Color.Maroon;
		this.C28E24BD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C28E24BD.FlatAppearance.BorderSize = 0;
		this.C28E24BD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C28E24BD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C28E24BD.ForeColor = System.Drawing.Color.White;
		this.C28E24BD.Location = new System.Drawing.Point(183, 376);
		this.C28E24BD.Name = "btnCancel";
		this.C28E24BD.Size = new System.Drawing.Size(92, 29);
		this.C28E24BD.TabIndex = 10;
		this.C28E24BD.Text = "Đóng";
		this.C28E24BD.UseVisualStyleBackColor = false;
		this.C28E24BD.Click += new System.EventHandler(D282060F);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(76, 376);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.button1);
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(357, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(359, 418);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDChangeSoThich";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A1909B01);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.C6B20985).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.B1B532BD).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
