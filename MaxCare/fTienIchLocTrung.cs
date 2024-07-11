using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchLocTrung : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards E3158F93;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip C32FC298;

	private BunifuCards FDA40228;

	private Panel EB197A8E;

	private Button button2;

	private PictureBox pictureBox1;

	private Button BC2E1E34;

	private BunifuCustomLabel B8894592;

	private Button btnAdd;

	private RichTextBox C2BBFC1A;

	private GroupBox groupBox2;

	private RichTextBox E42641A6;

	private GroupBox groupBox1;

	private Button btnNhapTuFile;

	private TextBox D51C1A20;

	private RadioButton FD9D549D;

	private RadioButton rbNhapTuFile;

	public fTienIchLocTrung()
	{
		E1A6BF35();
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(B8894592);
		Language.smethod_0(rbNhapTuFile);
		Language.smethod_0(btnNhapTuFile);
		Language.smethod_0(FD9D549D);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F2A8EC0C(object sender, EventArgs e)
	{
		try
		{
			List<string> source = new List<string>();
			string text = D51C1A20.Text.Trim();
			if (rbNhapTuFile.Checked)
			{
				if (text.EndsWith(".txt"))
				{
					if (!File.Exists(text))
					{
						MessageBoxHelper.Show("File dữ liệu nhập không tồn tại!", 2);
					}
				}
				else
				{
					MessageBoxHelper.Show("File nhập vào chỉ hỗ trợ đối với File (.txt)!", 2);
				}
			}
			if (rbNhapTuFile.Checked)
			{
				source = File.ReadAllLines(text).ToList();
			}
			else if (FD9D549D.Checked)
			{
				source = C2BBFC1A.Lines.ToList();
			}
			List<string> list = source.Distinct().ToList();
			E42641A6.Lines = list.ToArray();
			MessageBoxHelper.Show("Đã lọc xong!");
		}
		catch (Exception)
		{
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void C2BBFC1A_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = C2BBFC1A.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			FD9D549D.Text = string.Format(Language.GetValue("Tự nhập ({0})"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void rbNhapTuFile_CheckedChanged(object sender, EventArgs e)
	{
		D51C1A20.Enabled = rbNhapTuFile.Checked;
		btnNhapTuFile.Enabled = rbNhapTuFile.Checked;
	}

	private void FD9D549D_CheckedChanged(object sender, EventArgs e)
	{
		C2BBFC1A.Enabled = FD9D549D.Checked;
	}

	private void DE8DDEAF(object sender, EventArgs e)
	{
		D51C1A20.Text = Common.SelectFile();
	}

	private void F036B323(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = E42641A6.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			groupBox2.Text = $"Output ({a2AB53A.Count.ToString()})";
		}
		catch
		{
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void ABADCBAE(object sender, EventArgs e)
	{
		rbNhapTuFile_CheckedChanged(null, null);
		FD9D549D_CheckedChanged(null, null);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void E1A6BF35()
	{
		icontainer_0 = new Container();
		E3158F93 = new BunifuCards();
		panel1 = new Panel();
		groupBox2 = new GroupBox();
		E42641A6 = new RichTextBox();
		groupBox1 = new GroupBox();
		btnNhapTuFile = new Button();
		C2BBFC1A = new RichTextBox();
		D51C1A20 = new TextBox();
		FD9D549D = new RadioButton();
		rbNhapTuFile = new RadioButton();
		btnAdd = new Button();
		FDA40228 = new BunifuCards();
		EB197A8E = new Panel();
		button2 = new Button();
		pictureBox1 = new PictureBox();
		BC2E1E34 = new Button();
		B8894592 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		C32FC298 = new ToolTip(icontainer_0);
		panel1.SuspendLayout();
		groupBox2.SuspendLayout();
		groupBox1.SuspendLayout();
		FDA40228.SuspendLayout();
		EB197A8E.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		E3158F93.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		E3158F93.BackColor = Color.White;
		E3158F93.BorderRadius = 5;
		E3158F93.BottomSahddow = true;
		E3158F93.color = Color.SaddleBrown;
		E3158F93.LeftSahddow = false;
		E3158F93.Location = new Point(0, 0);
		E3158F93.Margin = new Padding(3, 4, 3, 4);
		E3158F93.Name = "bunifuCards1";
		E3158F93.RightSahddow = true;
		E3158F93.ShadowDepth = 20;
		E3158F93.Size = new Size(509, 47);
		E3158F93.TabIndex = 12;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(groupBox2);
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(FDA40228);
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Margin = new Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new Size(838, 270);
		panel1.TabIndex = 37;
		panel1.Paint += panel1_Paint;
		groupBox2.Controls.Add(E42641A6);
		groupBox2.Location = new Point(469, 40);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new Size(361, 223);
		groupBox2.TabIndex = 51;
		groupBox2.TabStop = false;
		groupBox2.Text = "Output (0)";
		E42641A6.Location = new Point(6, 22);
		E42641A6.Name = "txtOutput";
		E42641A6.Size = new Size(349, 194);
		E42641A6.TabIndex = 50;
		E42641A6.Text = "";
		E42641A6.WordWrap = false;
		E42641A6.TextChanged += F036B323;
		groupBox1.Controls.Add(btnNhapTuFile);
		groupBox1.Controls.Add(C2BBFC1A);
		groupBox1.Controls.Add(D51C1A20);
		groupBox1.Controls.Add(FD9D549D);
		groupBox1.Controls.Add(rbNhapTuFile);
		groupBox1.Location = new Point(6, 40);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(361, 223);
		groupBox1.TabIndex = 51;
		groupBox1.TabStop = false;
		groupBox1.Text = "Input";
		btnNhapTuFile.Cursor = Cursors.Hand;
		btnNhapTuFile.Location = new Point(287, 22);
		btnNhapTuFile.Name = "btnNhapTuFile";
		btnNhapTuFile.Size = new Size(65, 24);
		btnNhapTuFile.TabIndex = 2;
		btnNhapTuFile.Text = "Chọn";
		btnNhapTuFile.Click += DE8DDEAF;
		C2BBFC1A.Location = new Point(30, 75);
		C2BBFC1A.Name = "txtInput";
		C2BBFC1A.Size = new Size(322, 141);
		C2BBFC1A.TabIndex = 50;
		C2BBFC1A.Text = "";
		C2BBFC1A.WordWrap = false;
		C2BBFC1A.TextChanged += C2BBFC1A_TextChanged;
		D51C1A20.Location = new Point(110, 22);
		D51C1A20.Name = "txtNhapTuFile";
		D51C1A20.Size = new Size(171, 23);
		D51C1A20.TabIndex = 1;
		FD9D549D.AutoSize = true;
		FD9D549D.Cursor = Cursors.Hand;
		FD9D549D.Location = new Point(9, 49);
		FD9D549D.Name = "rbTuNhap";
		FD9D549D.Size = new Size(95, 20);
		FD9D549D.TabIndex = 0;
		FD9D549D.Text = "Tự nhập (0)";
		FD9D549D.UseVisualStyleBackColor = true;
		FD9D549D.CheckedChanged += FD9D549D_CheckedChanged;
		rbNhapTuFile.AutoSize = true;
		rbNhapTuFile.Checked = true;
		rbNhapTuFile.Cursor = Cursors.Hand;
		rbNhapTuFile.Location = new Point(9, 23);
		rbNhapTuFile.Name = "rbNhapTuFile";
		rbNhapTuFile.Size = new Size(95, 20);
		rbNhapTuFile.TabIndex = 0;
		rbNhapTuFile.TabStop = true;
		rbNhapTuFile.Text = "Nhập từ File";
		rbNhapTuFile.UseVisualStyleBackColor = true;
		rbNhapTuFile.CheckedChanged += rbNhapTuFile_CheckedChanged;
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
		btnAdd.Text = "Start";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += F2A8EC0C;
		FDA40228.BackColor = Color.White;
		FDA40228.BorderRadius = 0;
		FDA40228.BottomSahddow = true;
		FDA40228.color = Color.SaddleBrown;
		FDA40228.Controls.Add(EB197A8E);
		FDA40228.Dock = DockStyle.Top;
		FDA40228.LeftSahddow = false;
		FDA40228.Location = new Point(0, 0);
		FDA40228.Name = "bunifuCards2";
		FDA40228.RightSahddow = true;
		FDA40228.ShadowDepth = 20;
		FDA40228.Size = new Size(836, 37);
		FDA40228.TabIndex = 43;
		EB197A8E.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		EB197A8E.BackColor = Color.White;
		EB197A8E.Controls.Add(button2);
		EB197A8E.Controls.Add(pictureBox1);
		EB197A8E.Controls.Add(BC2E1E34);
		EB197A8E.Controls.Add(B8894592);
		EB197A8E.Cursor = Cursors.SizeAll;
		EB197A8E.Location = new Point(0, 3);
		EB197A8E.Name = "pnlHeader";
		EB197A8E.Size = new Size(836, 31);
		EB197A8E.TabIndex = 9;
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
		button2.Click += button2_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		BC2E1E34.Cursor = Cursors.Hand;
		BC2E1E34.FlatAppearance.BorderSize = 0;
		BC2E1E34.FlatStyle = FlatStyle.Flat;
		BC2E1E34.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BC2E1E34.ForeColor = Color.White;
		BC2E1E34.Location = new Point(899, 1);
		BC2E1E34.Name = "btnMinimize";
		BC2E1E34.Size = new Size(30, 30);
		BC2E1E34.TabIndex = 9;
		BC2E1E34.TextImageRelation = TextImageRelation.ImageBeforeText;
		BC2E1E34.UseVisualStyleBackColor = true;
		B8894592.BackColor = Color.Transparent;
		B8894592.Cursor = Cursors.SizeAll;
		B8894592.Dock = DockStyle.Fill;
		B8894592.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B8894592.ForeColor = Color.Black;
		B8894592.Location = new Point(0, 0);
		B8894592.Name = "lblTitle";
		B8894592.Size = new Size(836, 31);
		B8894592.TabIndex = 12;
		B8894592.Text = "Lọc trùng dữ liệu";
		B8894592.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = B8894592;
		bunifuDragControl_0.Vertical = true;
		C32FC298.AutomaticDelay = 0;
		C32FC298.AutoPopDelay = 10000;
		C32FC298.InitialDelay = 200;
		C32FC298.ReshowDelay = 40;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(838, 270);
		base.Controls.Add(panel1);
		base.Controls.Add(E3158F93);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fTienIchLocTrung";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += ABADCBAE;
		panel1.ResumeLayout(performLayout: false);
		groupBox2.ResumeLayout(performLayout: false);
		groupBox1.ResumeLayout(performLayout: false);
		groupBox1.PerformLayout();
		FDA40228.ResumeLayout(performLayout: false);
		EB197A8E.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
	}
}
