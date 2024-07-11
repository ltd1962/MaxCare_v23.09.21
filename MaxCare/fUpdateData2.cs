using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fUpdateData2 : Form
{
	private fQuanLyTinNhan EA9FD99F;

	private IContainer F6B8481E = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private ComboBox cbbTypeUpdate;

	private Label label1;

	private TextBox txbData;

	private Label C0045D96;

	private Button btnCancel;

	private Button btnAdd;

	private PictureBox pictureBox1;

	private Label label3;

	private ComboBox cbbTypeProxy;

	public fUpdateData2(fQuanLyTinNhan a8A63D33_0, string string_0)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		EA9FD99F = a8A63D33_0;
		cbbTypeUpdate.Text = string_0;
		cbbTypeProxy.SelectedIndex = 0;
	}

	private void E20D02AA()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(C0045D96);
		Language.smethod_0(label3);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void B78A0A13(object sender, EventArgs e)
	{
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C425F907(object sender, EventArgs e)
	{
		try
		{
			bool flag = false;
			if (txbData.Text.Equals("") || txbData.Text.Equals("|"))
			{
				if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Ba\u0323n co\u0301 chă\u0301c muô\u0301n xo\u0301a dư\u0303 liê\u0323u của {0} tài khoản?"), EA9FD99F.F1B81226())) == DialogResult.Yes)
				{
					flag = true;
				}
			}
			else if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Ba\u0323n co\u0301 chă\u0301c muô\u0301n câ\u0323p nhâ\u0323t dư\u0303 liê\u0323u của {0} tài khoản?"), EA9FD99F.F1B81226())) == DialogResult.Yes)
			{
				flag = true;
			}
			if (!flag)
			{
				return;
			}
			List<string> list = new List<string>();
			string text = txbData.Text;
			for (int i = 0; i < EA9FD99F.dgvTaiKhoan.SelectedRows.Count; i++)
			{
				list.Add(EA9FD99F.B92D3D0E(EA9FD99F.dgvTaiKhoan.SelectedRows[i].Index, "cId"));
			}
			string text2 = cbbTypeUpdate.Text;
			string text3 = text2;
			if (text3 == "Notes" && CommonSQL.smethod_9(list, "ghiChu", text))
			{
				for (int j = 0; j < EA9FD99F.dgvTaiKhoan.SelectedRows.Count; j++)
				{
					EA9FD99F.method_0(EA9FD99F.dgvTaiKhoan.SelectedRows[j].Index, "cGhiChu", text);
				}
			}
			Close();
		}
		catch
		{
			MessageBoxHelper.Show("Vui lòng thử lại sau!", 2);
		}
	}

	private void cbbTypeUpdate_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool visible = cbbTypeUpdate.Text == "Proxy";
		label3.Visible = visible;
		cbbTypeProxy.Visible = visible;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && F6B8481E != null)
		{
			F6B8481E.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUpdateData2));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.cbbTypeUpdate = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.txbData = new System.Windows.Forms.TextBox();
		this.C0045D96 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.cbbTypeProxy = new System.Windows.Forms.ComboBox();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 5;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(416, 38);
		this.bunifuCards1.TabIndex = 12;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(416, 32);
		this.pnlHeader.TabIndex = 9;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(382, -1);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(B78A0A13);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 79;
		this.pictureBox1.TabStop = false;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(416, 32);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.cbbTypeUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTypeUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTypeUpdate.FormattingEnabled = true;
		this.cbbTypeUpdate.ItemHeight = 16;
		this.cbbTypeUpdate.Items.AddRange(new object[10] { "Token", "Cookie", "Password", "Mail|pass", "PassMail", "2FA", "Birthday", "Useragent", "Proxy", "Notes" });
		this.cbbTypeUpdate.Location = new System.Drawing.Point(146, 43);
		this.cbbTypeUpdate.Name = "cbbTypeUpdate";
		this.cbbTypeUpdate.Size = new System.Drawing.Size(238, 24);
		this.cbbTypeUpdate.TabIndex = 13;
		this.cbbTypeUpdate.SelectedIndexChanged += new System.EventHandler(cbbTypeUpdate_SelectedIndexChanged);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(34, 46);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(105, 16);
		this.label1.TabIndex = 14;
		this.label1.Text = "Dữ liệu cập nhật:";
		this.txbData.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txbData.Location = new System.Drawing.Point(146, 73);
		this.txbData.Name = "txbData";
		this.txbData.Size = new System.Drawing.Size(238, 23);
		this.txbData.TabIndex = 15;
		this.C0045D96.AutoSize = true;
		this.C0045D96.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C0045D96.Location = new System.Drawing.Point(34, 76);
		this.C0045D96.Name = "label2";
		this.C0045D96.Size = new System.Drawing.Size(84, 16);
		this.C0045D96.TabIndex = 16;
		this.C0045D96.Text = "Nhập dữ liệu:";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(209, 139);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 18;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(111, 139);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 17;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(C425F907);
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(34, 105);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(70, 16);
		this.label3.TabIndex = 16;
		this.label3.Text = "Loại proxy:";
		this.cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbTypeProxy.FormattingEnabled = true;
		this.cbbTypeProxy.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		this.cbbTypeProxy.Location = new System.Drawing.Point(146, 102);
		this.cbbTypeProxy.Name = "cbbTypeProxy";
		this.cbbTypeProxy.Size = new System.Drawing.Size(130, 24);
		this.cbbTypeProxy.TabIndex = 124;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(416, 181);
		base.Controls.Add(this.cbbTypeProxy);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.C0045D96);
		base.Controls.Add(this.txbData);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.cbbTypeUpdate);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fUpdateData2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fUpdateData";
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
