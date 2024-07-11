using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fImportProxy : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel A5B8A89F;

	private Button F40F8D36;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl A737DA00;

	private PictureBox pictureBox1;

	private Label label8;

	private Label lblStatus;

	private RichTextBox A9174CBE;

	private Label label1;

	private NumericUpDown nudTaiKhoanPerUa;

	private CheckBox ckbKhongNhapTaiKhoanDaCo;

	private Label FE29F92B;

	private RadioButton rbNgauNhien;

	private RadioButton rbLanLuot;

	private Label label3;

	private ComboBox A2A64BB8;

	public fImportProxy()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		A2A64BB8.SelectedIndex = 0;
	}

	private void F40F8D36_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		Language.smethod_0(A5B8A89F);
		Language.smethod_0(lblStatus);
		Language.smethod_0(label8);
		Language.smethod_0(label3);
		Language.smethod_0(label1);
		Language.smethod_0(FE29F92B);
		Language.smethod_0(rbLanLuot);
		Language.smethod_0(rbNgauNhien);
		Language.smethod_0(ckbKhongNhapTaiKhoanDaCo);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void F3257E30(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = A9174CBE.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			List<string> list = new List<string>();
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p thêm Proxy!", 3);
				return;
			}
			int num = Convert.ToInt32(nudTaiKhoanPerUa.Value);
			for (int i = 0; i < num; i++)
			{
				list.AddRange(a2AB53A);
			}
			if (rbNgauNhien.Checked)
			{
				list = Common.ShuffleList(list);
			}
			Queue<string> queue = new Queue<string>(list);
			int selectedIndex = A2A64BB8.SelectedIndex;
			List<string> list2 = new List<string>();
			for (int j = 0; j < fMain.AABB4798.dtgvAcc.Rows.Count; j++)
			{
				if (Convert.ToBoolean(fMain.AABB4798.GetCellAccount(j, "cChose")) && (!(fMain.AABB4798.GetCellAccount(j, "cProxy") != "") || !ckbKhongNhapTaiKhoanDaCo.Checked))
				{
					if (queue.Count == 0)
					{
						break;
					}
					string text = (queue.Dequeue() + "*" + selectedIndex).Replace("'", "''");
					list2.Add(fMain.AABB4798.GetCellAccount(j, "cId") + "|" + text);
				}
			}
			if (CommonSQL.smethod_4("proxy", list2))
			{
				queue = new Queue<string>(list);
				for (int k = 0; k < fMain.AABB4798.dtgvAcc.Rows.Count; k++)
				{
					if (Convert.ToBoolean(fMain.AABB4798.GetCellAccount(k, "cChose")) && (!(fMain.AABB4798.GetCellAccount(k, "cProxy") != "") || !ckbKhongNhapTaiKhoanDaCo.Checked))
					{
						if (queue.Count == 0)
						{
							break;
						}
						string object_ = (queue.Dequeue() + "*" + selectedIndex).Replace("'", "''");
						fMain.AABB4798.SetCellAccount(k, "cProxy", object_);
					}
				}
			}
			if (MessageBoxHelper.ShowMessages("Nhâ\u0323p thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
			{
				Close();
			}
		}
		catch (Exception)
		{
			MessageBoxHelper.Show("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AC36B03A(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			F3257E30(null, null);
		}
	}

	private void A9174CBE_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = A9174CBE.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch Proxy ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportProxy));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.F40F8D36 = new System.Windows.Forms.Button();
		this.A5B8A89F = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.A737DA00 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.A9174CBE = new System.Windows.Forms.RichTextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.nudTaiKhoanPerUa = new System.Windows.Forms.NumericUpDown();
		this.ckbKhongNhapTaiKhoanDaCo = new System.Windows.Forms.CheckBox();
		this.FE29F92B = new System.Windows.Forms.Label();
		this.rbNgauNhien = new System.Windows.Forms.RadioButton();
		this.rbLanLuot = new System.Windows.Forms.RadioButton();
		this.label3 = new System.Windows.Forms.Label();
		this.A2A64BB8 = new System.Windows.Forms.ComboBox();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTaiKhoanPerUa).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(477, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.F40F8D36);
		this.pnlHeader.Controls.Add(this.A5B8A89F);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(477, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(4, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 77;
		this.pictureBox1.TabStop = false;
		this.F40F8D36.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F40F8D36.Dock = System.Windows.Forms.DockStyle.Right;
		this.F40F8D36.FlatAppearance.BorderSize = 0;
		this.F40F8D36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F40F8D36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.F40F8D36.ForeColor = System.Drawing.Color.White;
		this.F40F8D36.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.F40F8D36.Location = new System.Drawing.Point(445, 0);
		this.F40F8D36.Name = "btnMinimize";
		this.F40F8D36.Size = new System.Drawing.Size(32, 32);
		this.F40F8D36.TabIndex = 9;
		this.F40F8D36.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.F40F8D36.UseVisualStyleBackColor = true;
		this.F40F8D36.Click += new System.EventHandler(F40F8D36_Click);
		this.A5B8A89F.BackColor = System.Drawing.Color.Transparent;
		this.A5B8A89F.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.A5B8A89F.Dock = System.Windows.Forms.DockStyle.Fill;
		this.A5B8A89F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A5B8A89F.ForeColor = System.Drawing.Color.Black;
		this.A5B8A89F.Location = new System.Drawing.Point(0, 0);
		this.A5B8A89F.Name = "bunifuCustomLabel1";
		this.A5B8A89F.Size = new System.Drawing.Size(477, 32);
		this.A5B8A89F.TabIndex = 1;
		this.A5B8A89F.Text = "Nhâ\u0323p Proxy";
		this.A5B8A89F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(244, 386);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(135, 386);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Xa\u0301c nhâ\u0323n";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(F3257E30);
		this.A737DA00.Fixed = true;
		this.A737DA00.Horizontal = true;
		this.A737DA00.TargetControl = this.A5B8A89F;
		this.A737DA00.Vertical = true;
		this.label8.AutoSize = true;
		this.label8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label8.Location = new System.Drawing.Point(331, 252);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(115, 16);
		this.label8.TabIndex = 5;
		this.label8.Text = "(Mỗi proxy 1 dòng)";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatus.Location = new System.Drawing.Point(30, 47);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(127, 16);
		this.lblStatus.TabIndex = 6;
		this.lblStatus.Text = "Danh sa\u0301ch Proxy (0):";
		this.A9174CBE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.A9174CBE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A9174CBE.Location = new System.Drawing.Point(34, 66);
		this.A9174CBE.Name = "txtProxy";
		this.A9174CBE.Size = new System.Drawing.Size(409, 181);
		this.A9174CBE.TabIndex = 118;
		this.A9174CBE.Text = "";
		this.A9174CBE.WordWrap = false;
		this.A9174CBE.TextChanged += new System.EventHandler(A9174CBE_TextChanged);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(31, 298);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(119, 16);
		this.label1.TabIndex = 119;
		this.label1.Text = "Sô\u0301 ta\u0300i khoa\u0309n/proxy:";
		this.nudTaiKhoanPerUa.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.nudTaiKhoanPerUa.Location = new System.Drawing.Point(157, 296);
		this.nudTaiKhoanPerUa.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTaiKhoanPerUa.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudTaiKhoanPerUa.Name = "nudTaiKhoanPerUa";
		this.nudTaiKhoanPerUa.Size = new System.Drawing.Size(69, 23);
		this.nudTaiKhoanPerUa.TabIndex = 120;
		this.nudTaiKhoanPerUa.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.ckbKhongNhapTaiKhoanDaCo.AutoSize = true;
		this.ckbKhongNhapTaiKhoanDaCo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKhongNhapTaiKhoanDaCo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbKhongNhapTaiKhoanDaCo.Location = new System.Drawing.Point(33, 349);
		this.ckbKhongNhapTaiKhoanDaCo.Name = "ckbKhongNhapTaiKhoanDaCo";
		this.ckbKhongNhapTaiKhoanDaCo.Size = new System.Drawing.Size(283, 20);
		this.ckbKhongNhapTaiKhoanDaCo.TabIndex = 121;
		this.ckbKhongNhapTaiKhoanDaCo.Text = "Không nhâ\u0323p va\u0300o như\u0303ng ta\u0300i khoa\u0309n đa\u0303 co\u0301 Proxy";
		this.ckbKhongNhapTaiKhoanDaCo.UseVisualStyleBackColor = true;
		this.FE29F92B.AutoSize = true;
		this.FE29F92B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FE29F92B.Location = new System.Drawing.Point(30, 325);
		this.FE29F92B.Name = "label2";
		this.FE29F92B.Size = new System.Drawing.Size(131, 16);
		this.FE29F92B.TabIndex = 119;
		this.FE29F92B.Text = "Tu\u0300y cho\u0323n nhâ\u0323p Proxy:";
		this.rbNgauNhien.AutoSize = true;
		this.rbNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNgauNhien.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbNgauNhien.Location = new System.Drawing.Point(246, 323);
		this.rbNgauNhien.Name = "rbNgauNhien";
		this.rbNgauNhien.Size = new System.Drawing.Size(89, 20);
		this.rbNgauNhien.TabIndex = 122;
		this.rbNgauNhien.Text = "Ngâ\u0303u nhiên";
		this.rbNgauNhien.UseVisualStyleBackColor = true;
		this.rbLanLuot.AutoSize = true;
		this.rbLanLuot.Checked = true;
		this.rbLanLuot.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbLanLuot.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbLanLuot.Location = new System.Drawing.Point(157, 323);
		this.rbLanLuot.Name = "rbLanLuot";
		this.rbLanLuot.Size = new System.Drawing.Size(71, 20);
		this.rbLanLuot.TabIndex = 122;
		this.rbLanLuot.TabStop = true;
		this.rbLanLuot.Text = "Lâ\u0300n lươ\u0323t";
		this.rbLanLuot.UseVisualStyleBackColor = true;
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(31, 267);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(70, 16);
		this.label3.TabIndex = 119;
		this.label3.Text = "Loa\u0323i Proxy:";
		this.A2A64BB8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A2A64BB8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.A2A64BB8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A2A64BB8.FormattingEnabled = true;
		this.A2A64BB8.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		this.A2A64BB8.Location = new System.Drawing.Point(157, 264);
		this.A2A64BB8.Name = "cbbTypeProxy";
		this.A2A64BB8.Size = new System.Drawing.Size(140, 24);
		this.A2A64BB8.TabIndex = 123;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(477, 432);
		base.Controls.Add(this.A2A64BB8);
		base.Controls.Add(this.rbLanLuot);
		base.Controls.Add(this.rbNgauNhien);
		base.Controls.Add(this.ckbKhongNhapTaiKhoanDaCo);
		base.Controls.Add(this.nudTaiKhoanPerUa);
		base.Controls.Add(this.FE29F92B);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.A9174CBE);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.lblStatus);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fImportProxy";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTaiKhoanPerUa).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
