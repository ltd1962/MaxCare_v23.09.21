using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDVerify : Form
{
	private JSON_Settings F5A56EA6 = null;

	private string string_0;

	private string A00FF70F;

	private string BBB49CA4;

	private int F136373E;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox A4A67FA0;

	private Label label1;

	private Button F093D70D;

	private Button btnAdd;

	private BunifuCards C317738E;

	private Panel DD002D09;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox ckbUpAvatar;

	private TextBox txtPath;

	private TextBox DF3D432A;

	private Label label2;

	public fHDVerify(string FF1A5D19, int C9854B1D = 0, string C49A3F33 = "")
	{
		DFB28D37();
		bool_0 = false;
		string_0 = FF1A5D19;
		BBB49CA4 = C49A3F33;
		F136373E = C9854B1D;
		if (InteractSQL.B484648C("", "fHDVerify").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDVerify', 'Verify Phone');");
		}
		string text = "";
		switch (C9854B1D)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDVerify");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			A00FF70F = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A4A67FA0.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(C49A3F33);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			A4A67FA0.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F5A56EA6 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(btnAdd);
		Language.smethod_0(F093D70D);
	}

	private void fHDVerify_Load(object sender, EventArgs e)
	{
		try
		{
			DF3D432A.Text = F5A56EA6.GetValue("txtApi");
			ckbUpAvatar.Checked = F5A56EA6.GetValueBool("ckbUpAvatar");
			txtPath.Text = F5A56EA6.GetValue("txtPath");
		}
		catch
		{
		}
	}

	private void B2A93A94(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = A4A67FA0.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("txtApi", DF3D432A.Text);
		gClass.GetJson("ckbUpAvatar", ckbUpAvatar.Checked);
		gClass.GetJson("txtPath", txtPath.Text);
		string text2 = gClass.D9A09B34();
		if (F136373E == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, A00FF70F, text2))
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
			if (InteractSQL.smethod_13(BBB49CA4, text, text2))
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

	private void D129F194(object sender, EventArgs e)
	{
		Close();
	}

	private void B62BA92B(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void FF1CE797(object sender, EventArgs e)
	{
		txtPath.Enabled = ckbUpAvatar.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void DFB28D37()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDVerify));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		DD002D09 = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		A4A67FA0 = new TextBox();
		label1 = new Label();
		F093D70D = new Button();
		btnAdd = new Button();
		C317738E = new BunifuCards();
		label2 = new Label();
		DF3D432A = new TextBox();
		ckbUpAvatar = new CheckBox();
		txtPath = new TextBox();
		DD002D09.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		C317738E.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(424, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Verify";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = DD002D09;
		bunifuDragControl_1.Vertical = true;
		DD002D09.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		DD002D09.BackColor = Color.White;
		DD002D09.Controls.Add(button1);
		DD002D09.Controls.Add(pictureBox1);
		DD002D09.Controls.Add(bunifuCustomLabel1);
		DD002D09.Cursor = Cursors.SizeAll;
		DD002D09.Location = new Point(0, 3);
		DD002D09.Name = "pnlHeader";
		DD002D09.Size = new Size(424, 31);
		DD002D09.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(393, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += B2A93A94;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(ckbUpAvatar);
		panel1.Controls.Add(txtPath);
		panel1.Controls.Add(DF3D432A);
		panel1.Controls.Add(A4A67FA0);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(F093D70D);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(C317738E);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(427, 294);
		panel1.TabIndex = 0;
		panel1.Paint += B62BA92B;
		A4A67FA0.Location = new Point(132, 49);
		A4A67FA0.Name = "txtTenHanhDong";
		A4A67FA0.Size = new Size(274, 23);
		A4A67FA0.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		F093D70D.BackColor = Color.Maroon;
		F093D70D.Cursor = Cursors.Hand;
		F093D70D.FlatAppearance.BorderSize = 0;
		F093D70D.FlatStyle = FlatStyle.Flat;
		F093D70D.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F093D70D.ForeColor = Color.White;
		F093D70D.Location = new Point(220, 252);
		F093D70D.Name = "btnCancel";
		F093D70D.Size = new Size(92, 29);
		F093D70D.TabIndex = 10;
		F093D70D.Text = "Đóng";
		F093D70D.UseVisualStyleBackColor = false;
		F093D70D.Click += D129F194;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(113, 252);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		C317738E.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		C317738E.BackColor = Color.White;
		C317738E.BorderRadius = 0;
		C317738E.BottomSahddow = true;
		C317738E.color = Color.DarkViolet;
		C317738E.Controls.Add(DD002D09);
		C317738E.LeftSahddow = false;
		C317738E.Location = new Point(1, 0);
		C317738E.Name = "bunifuCards1";
		C317738E.RightSahddow = true;
		C317738E.ShadowDepth = 20;
		C317738E.Size = new Size(424, 37);
		C317738E.TabIndex = 28;
		label2.AutoSize = true;
		label2.Location = new Point(27, 87);
		label2.Name = "label2";
		label2.Size = new Size(54, 16);
		label2.TabIndex = 31;
		label2.Text = "Api sim:";
		DF3D432A.Location = new Point(132, 84);
		DF3D432A.Name = "txtApi";
		DF3D432A.Size = new Size(274, 23);
		DF3D432A.TabIndex = 0;
		ckbUpAvatar.AutoSize = true;
		ckbUpAvatar.Location = new Point(30, 123);
		ckbUpAvatar.Name = "ckbUpAvatar";
		ckbUpAvatar.Size = new Size(78, 20);
		ckbUpAvatar.TabIndex = 32;
		ckbUpAvatar.Text = "UpAvatar";
		ckbUpAvatar.UseVisualStyleBackColor = true;
		ckbUpAvatar.CheckedChanged += FF1CE797;
		txtPath.Location = new Point(132, 121);
		txtPath.Name = "txtPath";
		txtPath.Size = new Size(274, 23);
		txtPath.TabIndex = 0;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(427, 294);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDVerify";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDVerify_Load;
		DD002D09.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		C317738E.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
