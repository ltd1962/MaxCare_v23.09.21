using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchTestSpinContent : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl FCBF2316;

	private ToolTip toolTip_0;

	private BunifuCards A224A2AE;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private Button A6374FB5;

	private BunifuCustomLabel DC9C0B18;

	private Button btnAdd;

	private RichTextBox E8B53FAD;

	private GroupBox CD1D3C96;

	private RichTextBox AC390E14;

	private GroupBox groupBox1;

	public fTienIchTestSpinContent()
	{
		F034AFAD();
		Language.SetLanguage(this);
	}

	private void CF824F3E(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			string string_ = E8B53FAD.Text;
			AC390E14.Text = Common.SpinText(string_);
		}
		catch (Exception)
		{
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void E8B53FAD_TextChanged(object sender, EventArgs e)
	{
	}

	private void C404B0BD(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void AC390E14_TextChanged(object sender, EventArgs e)
	{
	}

	private void A3860719(object sender, PaintEventArgs e)
	{
	}

	private void fTienIchTestSpinContent_Load(object sender, EventArgs e)
	{
		C404B0BD(null, null);
		method_0(null, null);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void F034AFAD()
	{
		icontainer_0 = new Container();
		bunifuCards1 = new BunifuCards();
		panel1 = new Panel();
		CD1D3C96 = new GroupBox();
		AC390E14 = new RichTextBox();
		groupBox1 = new GroupBox();
		E8B53FAD = new RichTextBox();
		btnAdd = new Button();
		A224A2AE = new BunifuCards();
		pnlHeader = new Panel();
		button2 = new Button();
		pictureBox1 = new PictureBox();
		A6374FB5 = new Button();
		DC9C0B18 = new BunifuCustomLabel();
		FCBF2316 = new BunifuDragControl(icontainer_0);
		toolTip_0 = new ToolTip(icontainer_0);
		panel1.SuspendLayout();
		CD1D3C96.SuspendLayout();
		groupBox1.SuspendLayout();
		A224A2AE.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Margin = new Padding(3, 4, 3, 4);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(509, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(CD1D3C96);
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(A224A2AE);
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Margin = new Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new Size(838, 600);
		panel1.TabIndex = 37;
		panel1.Paint += A3860719;
		CD1D3C96.Controls.Add(AC390E14);
		CD1D3C96.Location = new Point(469, 40);
		CD1D3C96.Name = "groupBox2";
		CD1D3C96.Size = new Size(361, 223);
		CD1D3C96.TabIndex = 51;
		CD1D3C96.TabStop = false;
		CD1D3C96.Text = "Output";
		AC390E14.Location = new Point(6, 22);
		AC390E14.Name = "txtOutput";
		AC390E14.Size = new Size(349, 194);
		AC390E14.TabIndex = 50;
		AC390E14.Text = "";
		AC390E14.WordWrap = false;
		AC390E14.TextChanged += AC390E14_TextChanged;
		groupBox1.Controls.Add(E8B53FAD);
		groupBox1.Location = new Point(6, 40);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(361, 223);
		groupBox1.TabIndex = 51;
		groupBox1.TabStop = false;
		groupBox1.Text = "Input";
		E8B53FAD.Location = new Point(6, 22);
		E8B53FAD.Name = "txtInput";
		E8B53FAD.Size = new Size(349, 194);
		E8B53FAD.TabIndex = 50;
		E8B53FAD.Text = "";
		E8B53FAD.WordWrap = false;
		E8B53FAD.TextChanged += E8B53FAD_TextChanged;
		btnAdd.BackColor = Color.Green;
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(379, 138);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(78, 29);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Spin";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		A224A2AE.BackColor = Color.White;
		A224A2AE.BorderRadius = 0;
		A224A2AE.BottomSahddow = true;
		A224A2AE.color = Color.SaddleBrown;
		A224A2AE.Controls.Add(pnlHeader);
		A224A2AE.Dock = DockStyle.Top;
		A224A2AE.LeftSahddow = false;
		A224A2AE.Location = new Point(0, 0);
		A224A2AE.Name = "bunifuCards2";
		A224A2AE.RightSahddow = true;
		A224A2AE.ShadowDepth = 20;
		A224A2AE.Size = new Size(836, 37);
		A224A2AE.TabIndex = 43;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(A6374FB5);
		pnlHeader.Controls.Add(DC9C0B18);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(836, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button2.Cursor = Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = FlatStyle.Flat;
		button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button2.ForeColor = Color.White;
		button2.Image = Resources.C400940B;
		button2.Location = new Point(805, 1);
		button2.Name = "button2";
		button2.Size = new Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += CF824F3E;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		A6374FB5.Cursor = Cursors.Hand;
		A6374FB5.FlatAppearance.BorderSize = 0;
		A6374FB5.FlatStyle = FlatStyle.Flat;
		A6374FB5.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		A6374FB5.ForeColor = Color.White;
		A6374FB5.Location = new Point(899, 1);
		A6374FB5.Name = "btnMinimize";
		A6374FB5.Size = new Size(30, 30);
		A6374FB5.TabIndex = 9;
		A6374FB5.TextImageRelation = TextImageRelation.ImageBeforeText;
		A6374FB5.UseVisualStyleBackColor = true;
		DC9C0B18.BackColor = Color.Transparent;
		DC9C0B18.Cursor = Cursors.SizeAll;
		DC9C0B18.Dock = DockStyle.Fill;
		DC9C0B18.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DC9C0B18.ForeColor = Color.Black;
		DC9C0B18.Location = new Point(0, 0);
		DC9C0B18.Name = "lblTitle";
		DC9C0B18.Size = new Size(836, 31);
		DC9C0B18.TabIndex = 12;
		DC9C0B18.Text = "Test Spin Content";
		DC9C0B18.TextAlign = ContentAlignment.MiddleCenter;
		FCBF2316.Fixed = true;
		FCBF2316.Horizontal = true;
		FCBF2316.TargetControl = DC9C0B18;
		FCBF2316.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(838, 270);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fTienIchTestSpinContent";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += fTienIchTestSpinContent_Load;
		panel1.ResumeLayout(performLayout: false);
		CD1D3C96.ResumeLayout(performLayout: false);
		groupBox1.ResumeLayout(performLayout: false);
		A224A2AE.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
	}
}
