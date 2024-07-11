using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDChangeTenPhu : Form
{
	private JSON_Settings F62486A3 = null;

	private string string_0;

	private string F7A7EF88;

	private string B798748E;

	private int int_0;

	public static bool A8AAA224;

	private IContainer E13CB693 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel D23EB381;

	private TextBox B7165FBB;

	private Label label1;

	private Button D50A3105;

	private Button D40C1335;

	private BunifuCards CF2B389A;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private RichTextBox txtTenPhu;

	private Label label2;

	public fHDChangeTenPhu(string BD28470E, int CBB8FE04 = 0, string string_1 = "")
	{
		InitializeComponent();
		A8AAA224 = false;
		string_0 = BD28470E;
		B798748E = string_1;
		int_0 = CBB8FE04;
		if (InteractSQL.B484648C("", "HDChangeTenPhu").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDChangeTenPhu', 'Thay đổi tên phụ');");
		}
		string text = "";
		switch (CBB8FE04)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDChangeTenPhu");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			F7A7EF88 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B7165FBB.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_1);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			D40C1335.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			B7165FBB.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F62486A3 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(D40C1335);
		Language.smethod_0(D50A3105);
	}

	private void A0B0CB9B(object sender, EventArgs e)
	{
		try
		{
			txtTenPhu.Text = F62486A3.GetValue("txtTenPhu");
		}
		catch
		{
		}
		txtTenPhu_TextChanged(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D40C1335_Click(object sender, EventArgs e)
	{
		string text = B7165FBB.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("txtTenPhu", txtTenPhu.Text.Trim());
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, F7A7EF88, text2))
				{
					A8AAA224 = true;
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
			if (InteractSQL.smethod_13(B798748E, text, text2))
			{
				A8AAA224 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void D50A3105_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D23EB381_Paint(object sender, PaintEventArgs e)
	{
		if (D23EB381.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, D23EB381.ClientSize.Width - num, D23EB381.ClientSize.Height - num));
		}
	}

	private void txtTenPhu_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtTenPhu.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			label2.Text = string.Format(Language.GetValue("Danh sa\u0301ch tên phụ ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && E13CB693 != null)
		{
			E13CB693.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.E13CB693 = new System.ComponentModel.Container();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.E13CB693);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.E13CB693);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.button1 = new System.Windows.Forms.Button();
		this.D23EB381 = new System.Windows.Forms.Panel();
		this.txtTenPhu = new System.Windows.Forms.RichTextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.B7165FBB = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.D50A3105 = new System.Windows.Forms.Button();
		this.D40C1335 = new System.Windows.Forms.Button();
		this.CF2B389A = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.D23EB381.SuspendLayout();
		this.CF2B389A.SuspendLayout();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(358, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Thay đổi tên phụ";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(358, 31);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = Resources.C400940B;
		this.button1.Location = new System.Drawing.Point(325, 5);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.D23EB381.BackColor = System.Drawing.Color.White;
		this.D23EB381.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.D23EB381.Controls.Add(this.txtTenPhu);
		this.D23EB381.Controls.Add(this.label2);
		this.D23EB381.Controls.Add(this.B7165FBB);
		this.D23EB381.Controls.Add(this.label1);
		this.D23EB381.Controls.Add(this.D50A3105);
		this.D23EB381.Controls.Add(this.D40C1335);
		this.D23EB381.Controls.Add(this.CF2B389A);
		this.D23EB381.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.D23EB381.Dock = System.Windows.Forms.DockStyle.Fill;
		this.D23EB381.Location = new System.Drawing.Point(0, 0);
		this.D23EB381.Name = "panel1";
		this.D23EB381.Size = new System.Drawing.Size(360, 348);
		this.D23EB381.TabIndex = 0;
		this.D23EB381.Paint += new System.Windows.Forms.PaintEventHandler(D23EB381_Paint);
		this.txtTenPhu.Location = new System.Drawing.Point(30, 95);
		this.txtTenPhu.Name = "txtTenPhu";
		this.txtTenPhu.Size = new System.Drawing.Size(296, 189);
		this.txtTenPhu.TabIndex = 41;
		this.txtTenPhu.Text = "";
		this.txtTenPhu.WordWrap = false;
		this.txtTenPhu.TextChanged += new System.EventHandler(txtTenPhu_TextChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 75);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(139, 16);
		this.label2.TabIndex = 43;
		this.label2.Text = "Danh sa\u0301ch tên phụ (0):";
		this.B7165FBB.Location = new System.Drawing.Point(132, 49);
		this.B7165FBB.Name = "txtTenHanhDong";
		this.B7165FBB.Size = new System.Drawing.Size(194, 23);
		this.B7165FBB.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.D50A3105.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.D50A3105.BackColor = System.Drawing.Color.Maroon;
		this.D50A3105.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D50A3105.FlatAppearance.BorderSize = 0;
		this.D50A3105.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D50A3105.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D50A3105.ForeColor = System.Drawing.Color.White;
		this.D50A3105.Location = new System.Drawing.Point(187, 303);
		this.D50A3105.Name = "btnCancel";
		this.D50A3105.Size = new System.Drawing.Size(92, 29);
		this.D50A3105.TabIndex = 10;
		this.D50A3105.Text = "Đóng";
		this.D50A3105.UseVisualStyleBackColor = false;
		this.D50A3105.Click += new System.EventHandler(D50A3105_Click);
		this.D40C1335.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.D40C1335.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.D40C1335.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D40C1335.FlatAppearance.BorderSize = 0;
		this.D40C1335.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D40C1335.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D40C1335.ForeColor = System.Drawing.Color.White;
		this.D40C1335.Location = new System.Drawing.Point(80, 303);
		this.D40C1335.Name = "btnAdd";
		this.D40C1335.Size = new System.Drawing.Size(92, 29);
		this.D40C1335.TabIndex = 9;
		this.D40C1335.Text = "Thêm";
		this.D40C1335.UseVisualStyleBackColor = false;
		this.D40C1335.Click += new System.EventHandler(D40C1335_Click);
		this.CF2B389A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.CF2B389A.BackColor = System.Drawing.Color.White;
		this.CF2B389A.BorderRadius = 0;
		this.CF2B389A.BottomSahddow = true;
		this.CF2B389A.color = System.Drawing.Color.DarkViolet;
		this.CF2B389A.Controls.Add(this.button1);
		this.CF2B389A.Controls.Add(this.pnlHeader);
		this.CF2B389A.LeftSahddow = false;
		this.CF2B389A.Location = new System.Drawing.Point(1, 0);
		this.CF2B389A.Name = "bunifuCards1";
		this.CF2B389A.RightSahddow = true;
		this.CF2B389A.ShadowDepth = 20;
		this.CF2B389A.Size = new System.Drawing.Size(358, 37);
		this.CF2B389A.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(360, 348);
		base.Controls.Add(this.D23EB381);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDChangeTenPhu";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A0B0CB9B);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.D23EB381.ResumeLayout(false);
		this.D23EB381.PerformLayout();
		this.CF2B389A.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
