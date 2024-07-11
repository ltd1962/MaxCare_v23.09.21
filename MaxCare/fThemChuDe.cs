using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fThemChuDe : Form
{
	private IContainer CBBC4AB4 = null;

	private BunifuCards E514362F;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private BunifuCards bunifuCards2;

	private Panel C993A2B1;

	private Button button2;

	private PictureBox E0B8BA32;

	private Button btnMinimize;

	private BunifuCustomLabel AE297A36;

	private ContextMenuStrip A62E5D0D;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private Label label2;

	private Button btnCancel;

	private Button btnAdd;

	private TextBox txtChuDe;

	public fThemChuDe()
	{
		A9877922();
		Language.SetLanguage(this);
	}

	private void EC2991BA(object sender, EventArgs e)
	{
		Close();
	}

	private void fThemChuDe_Load(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void DA061037(object sender, EventArgs e)
	{
		Close();
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void BB23D40A(object sender, EventArgs e)
	{
		List<string> list = CommonSQL.smethod_21();
		string text = txtChuDe.Text;
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập tên chủ đề mới!", 2);
		}
		else if (!list.Contains(text))
		{
			CommonSQL.E4A3E496(text);
			if (MessageBoxHelper.ShowMessages("Thêm thành công, bạn có muốn đóng cửa sổ?") == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			MessageBoxHelper.Show("Tên chủ đề đã tồn tại, vui lòng đổi tên khác!", 2);
		}
	}

	private void A0A345AC(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool C3170E27)
	{
		if (C3170E27 && CBBC4AB4 != null)
		{
			CBBC4AB4.Dispose();
		}
		base.Dispose(C3170E27);
	}

	private void A9877922()
	{
		CBBC4AB4 = new Container();
		E514362F = new BunifuCards();
		panel1 = new Panel();
		label2 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		txtChuDe = new TextBox();
		bunifuCards2 = new BunifuCards();
		C993A2B1 = new Panel();
		button2 = new Button();
		E0B8BA32 = new PictureBox();
		btnMinimize = new Button();
		AE297A36 = new BunifuCustomLabel();
		A62E5D0D = new ContextMenuStrip(CBBC4AB4);
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		toolStripMenuItem_2 = new ToolStripMenuItem();
		bunifuDragControl_0 = new BunifuDragControl(CBBC4AB4);
		toolTip_0 = new ToolTip(CBBC4AB4);
		panel1.SuspendLayout();
		bunifuCards2.SuspendLayout();
		C993A2B1.SuspendLayout();
		((ISupportInitialize)E0B8BA32).BeginInit();
		A62E5D0D.SuspendLayout();
		SuspendLayout();
		E514362F.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		E514362F.BackColor = Color.White;
		E514362F.BorderRadius = 5;
		E514362F.BottomSahddow = true;
		E514362F.color = Color.SaddleBrown;
		E514362F.LeftSahddow = false;
		E514362F.Location = new Point(0, 0);
		E514362F.Margin = new Padding(3, 4, 3, 4);
		E514362F.Name = "bunifuCards1";
		E514362F.RightSahddow = true;
		E514362F.ShadowDepth = 20;
		E514362F.Size = new Size(0, 47);
		E514362F.TabIndex = 12;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(label2);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(txtChuDe);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Margin = new Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new Size(329, 138);
		panel1.TabIndex = 37;
		panel1.Paint += panel1_Paint;
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label2.Location = new Point(28, 53);
		label2.Name = "label2";
		label2.Size = new Size(77, 16);
		label2.TabIndex = 47;
		label2.Text = "Tên chủ đề:";
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(167, 94);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 46;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += A0A345AC;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(63, 94);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += BB23D40A;
		txtChuDe.Lines = new string[0];
		txtChuDe.Location = new Point(111, 50);
		txtChuDe.MaxLength = 32767;
		txtChuDe.Name = "txtChuDe";
		txtChuDe.PasswordChar = '\0';
		txtChuDe.ScrollBars = ScrollBars.None;
		txtChuDe.SelectedText = "";
		txtChuDe.SelectionLength = 0;
		txtChuDe.SelectionStart = 0;
		txtChuDe.ShortcutsEnabled = true;
		txtChuDe.Size = new Size(180, 23);
		txtChuDe.TabIndex = 44;
		bunifuCards2.BackColor = Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = Color.SaddleBrown;
		bunifuCards2.Controls.Add(C993A2B1);
		bunifuCards2.Dock = DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new Size(327, 37);
		bunifuCards2.TabIndex = 43;
		C993A2B1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		C993A2B1.BackColor = Color.White;
		C993A2B1.Controls.Add(button2);
		C993A2B1.Controls.Add(E0B8BA32);
		C993A2B1.Controls.Add(btnMinimize);
		C993A2B1.Controls.Add(AE297A36);
		C993A2B1.Cursor = Cursors.SizeAll;
		C993A2B1.Location = new Point(0, 3);
		C993A2B1.Name = "pnlHeader";
		C993A2B1.Size = new Size(327, 31);
		C993A2B1.TabIndex = 9;
		button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button2.Cursor = Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = FlatStyle.Flat;
		button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button2.ForeColor = Color.White;
		button2.Image = Resources.C400940B;
		button2.Location = new Point(296, 1);
		button2.Name = "button2";
		button2.Size = new Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += DA061037;
		E0B8BA32.Cursor = Cursors.Default;
		E0B8BA32.Image = Resources.Bitmap_4;
		E0B8BA32.Location = new Point(3, 2);
		E0B8BA32.Name = "pictureBox1";
		E0B8BA32.Size = new Size(34, 27);
		E0B8BA32.SizeMode = PictureBoxSizeMode.Zoom;
		E0B8BA32.TabIndex = 76;
		E0B8BA32.TabStop = false;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Location = new Point(899, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		AE297A36.BackColor = Color.Transparent;
		AE297A36.Cursor = Cursors.SizeAll;
		AE297A36.Dock = DockStyle.Fill;
		AE297A36.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		AE297A36.ForeColor = Color.Black;
		AE297A36.Location = new Point(0, 0);
		AE297A36.Name = "bunifuCustomLabel1";
		AE297A36.Size = new Size(327, 31);
		AE297A36.TabIndex = 12;
		AE297A36.Text = "Thêm chủ đề";
		AE297A36.TextAlign = ContentAlignment.MiddleCenter;
		A62E5D0D.Items.AddRange(new ToolStripItem[3] { toolStripMenuItem_0, toolStripMenuItem_1, toolStripMenuItem_2 });
		A62E5D0D.Name = "contextMenuStrip1";
		A62E5D0D.Size = new Size(153, 70);
		toolStripMenuItem_0.Name = "thêmMớiToolStripMenuItem";
		toolStripMenuItem_0.Size = new Size(152, 22);
		toolStripMenuItem_0.Text = "Thêm chủ đề";
		toolStripMenuItem_1.Name = "sửaToolStripMenuItem";
		toolStripMenuItem_1.Size = new Size(152, 22);
		toolStripMenuItem_1.Text = "Sửa tên chủ đề";
		toolStripMenuItem_2.Name = "xóaToolStripMenuItem";
		toolStripMenuItem_2.Size = new Size(152, 22);
		toolStripMenuItem_2.Text = "Xóa chủ đề";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = AE297A36;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(329, 138);
		base.Controls.Add(panel1);
		base.Controls.Add(E514362F);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fThemChuDe";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += fThemChuDe_Load;
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		bunifuCards2.ResumeLayout(performLayout: false);
		C993A2B1.ResumeLayout(performLayout: false);
		((ISupportInitialize)E0B8BA32).EndInit();
		A62E5D0D.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
