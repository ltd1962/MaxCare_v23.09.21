using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fImportUseragent : Form
{
	private IContainer F883E62C = null;

	private BunifuCards bunifuCards1;

	private Panel DC1455A2;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Label label8;

	private Label F832538C;

	private RichTextBox txtUseragent;

	private Label DA2F68A9;

	private NumericUpDown nudTaiKhoanPerUa;

	private CheckBox D4BF06A5;

	private Label label2;

	private RadioButton rbNgauNhien;

	private RadioButton EB1FCA23;

	public fImportUseragent()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(F832538C);
		Language.smethod_0(DA2F68A9);
		Language.smethod_0(label8);
		Language.smethod_0(label2);
		Language.smethod_0(EB1FCA23);
		Language.smethod_0(rbNgauNhien);
		Language.smethod_0(D4BF06A5);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtUseragent.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			List<string> list = new List<string>();
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p thêm Useragent!", 3);
				return;
			}
			int num = Convert.ToInt32(nudTaiKhoanPerUa.Value);
			for (int i = 0; i < a2AB53A.Count; i++)
			{
				for (int j = 0; j < num; j++)
				{
					list.Add(a2AB53A[i]);
				}
			}
			if (rbNgauNhien.Checked)
			{
				list = Common.ShuffleList(list);
			}
			Queue<string> queue = new Queue<string>(list);
			for (int k = 0; k < fMain.AABB4798.dtgvAcc.Rows.Count; k++)
			{
				if (Convert.ToBoolean(fMain.AABB4798.GetCellAccount(k, "cChose")) && (!(fMain.AABB4798.GetCellAccount(k, "cUseragent") != "") || !D4BF06A5.Checked))
				{
					if (queue.Count == 0)
					{
						break;
					}
					string text = queue.Dequeue().Replace("'", "''");
					if (CommonSQL.UpdateFieldToAccount(fMain.AABB4798.GetCellAccount(k, "cId"), "useragent", text))
					{
						fMain.AABB4798.SetCellAccount(k, "cUseragent", text);
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

	private void AABC56AA(object sender, EventArgs e)
	{
		Close();
	}

	private void method_1(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			btnAdd_Click(null, null);
		}
	}

	private void txtUseragent_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtUseragent.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			F832538C.Text = string.Format(Language.GetValue("Danh sa\u0301ch Useragent ({0}):"), a2AB53A.Count);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && F883E62C != null)
		{
			F883E62C.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.F883E62C = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportUseragent));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.DC1455A2 = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.F883E62C);
		this.label8 = new System.Windows.Forms.Label();
		this.F832538C = new System.Windows.Forms.Label();
		this.txtUseragent = new System.Windows.Forms.RichTextBox();
		this.DA2F68A9 = new System.Windows.Forms.Label();
		this.nudTaiKhoanPerUa = new System.Windows.Forms.NumericUpDown();
		this.D4BF06A5 = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.rbNgauNhien = new System.Windows.Forms.RadioButton();
		this.EB1FCA23 = new System.Windows.Forms.RadioButton();
		this.bunifuCards1.SuspendLayout();
		this.DC1455A2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTaiKhoanPerUa).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.DC1455A2);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(477, 38);
		this.bunifuCards1.TabIndex = 0;
		this.DC1455A2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.DC1455A2.BackColor = System.Drawing.Color.White;
		this.DC1455A2.Controls.Add(this.pictureBox1);
		this.DC1455A2.Controls.Add(this.btnMinimize);
		this.DC1455A2.Controls.Add(this.bunifuCustomLabel1);
		this.DC1455A2.Location = new System.Drawing.Point(0, 5);
		this.DC1455A2.Name = "pnlHeader";
		this.DC1455A2.Size = new System.Drawing.Size(477, 32);
		this.DC1455A2.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(4, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 77;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(445, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(477, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Nhâ\u0323p Useragent";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(245, 342);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(AABC56AA);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(136, 342);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Xa\u0301c nhâ\u0323n";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.label8.AutoSize = true;
		this.label8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label8.Location = new System.Drawing.Point(301, 252);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(141, 16);
		this.label8.TabIndex = 5;
		this.label8.Text = "(Mỗi useragent 1 dòng)";
		this.F832538C.AutoSize = true;
		this.F832538C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.F832538C.Location = new System.Drawing.Point(30, 47);
		this.F832538C.Name = "lblStatus";
		this.F832538C.Size = new System.Drawing.Size(154, 16);
		this.F832538C.TabIndex = 6;
		this.F832538C.Text = "Danh sa\u0301ch Useragent (0):";
		this.txtUseragent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUseragent.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtUseragent.Location = new System.Drawing.Point(34, 66);
		this.txtUseragent.Name = "txtUseragent";
		this.txtUseragent.Size = new System.Drawing.Size(409, 181);
		this.txtUseragent.TabIndex = 118;
		this.txtUseragent.Text = "";
		this.txtUseragent.WordWrap = false;
		this.txtUseragent.TextChanged += new System.EventHandler(txtUseragent_TextChanged);
		this.DA2F68A9.AutoSize = true;
		this.DA2F68A9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DA2F68A9.Location = new System.Drawing.Point(31, 252);
		this.DA2F68A9.Name = "label1";
		this.DA2F68A9.Size = new System.Drawing.Size(146, 16);
		this.DA2F68A9.TabIndex = 119;
		this.DA2F68A9.Text = "Sô\u0301 ta\u0300i khoa\u0309n/Useragent:";
		this.nudTaiKhoanPerUa.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.nudTaiKhoanPerUa.Location = new System.Drawing.Point(184, 250);
		this.nudTaiKhoanPerUa.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTaiKhoanPerUa.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudTaiKhoanPerUa.Name = "nudTaiKhoanPerUa";
		this.nudTaiKhoanPerUa.Size = new System.Drawing.Size(69, 23);
		this.nudTaiKhoanPerUa.TabIndex = 120;
		this.nudTaiKhoanPerUa.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.D4BF06A5.AutoSize = true;
		this.D4BF06A5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D4BF06A5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D4BF06A5.Location = new System.Drawing.Point(33, 303);
		this.D4BF06A5.Name = "ckbKhongNhapTaiKhoanDaCo";
		this.D4BF06A5.Size = new System.Drawing.Size(310, 20);
		this.D4BF06A5.TabIndex = 121;
		this.D4BF06A5.Text = "Không nhâ\u0323p va\u0300o như\u0303ng ta\u0300i khoa\u0309n đa\u0303 co\u0301 Useragent";
		this.D4BF06A5.UseVisualStyleBackColor = true;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(30, 279);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(158, 16);
		this.label2.TabIndex = 119;
		this.label2.Text = "Tu\u0300y cho\u0323n nhâ\u0323p Useragent:";
		this.rbNgauNhien.AutoSize = true;
		this.rbNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNgauNhien.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbNgauNhien.Location = new System.Drawing.Point(274, 277);
		this.rbNgauNhien.Name = "rbNgauNhien";
		this.rbNgauNhien.Size = new System.Drawing.Size(89, 20);
		this.rbNgauNhien.TabIndex = 122;
		this.rbNgauNhien.Text = "Ngâ\u0303u nhiên";
		this.rbNgauNhien.UseVisualStyleBackColor = true;
		this.EB1FCA23.AutoSize = true;
		this.EB1FCA23.Checked = true;
		this.EB1FCA23.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EB1FCA23.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EB1FCA23.Location = new System.Drawing.Point(184, 277);
		this.EB1FCA23.Name = "rbLanLuot";
		this.EB1FCA23.Size = new System.Drawing.Size(71, 20);
		this.EB1FCA23.TabIndex = 122;
		this.EB1FCA23.TabStop = true;
		this.EB1FCA23.Text = "Lâ\u0300n lươ\u0323t";
		this.EB1FCA23.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(477, 388);
		base.Controls.Add(this.EB1FCA23);
		base.Controls.Add(this.rbNgauNhien);
		base.Controls.Add(this.D4BF06A5);
		base.Controls.Add(this.nudTaiKhoanPerUa);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.DA2F68A9);
		base.Controls.Add(this.txtUseragent);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.F832538C);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fImportUseragent";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		this.bunifuCards1.ResumeLayout(false);
		this.DC1455A2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTaiKhoanPerUa).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
