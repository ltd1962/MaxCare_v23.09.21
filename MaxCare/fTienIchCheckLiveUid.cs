using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckLiveUid : Form
{
	[CompilerGenerated]
	private sealed class Class92
	{
		public int F4BB2ABC;

		public fTienIchCheckLiveUid fTienIchCheckLiveUid_0;
	}

	[CompilerGenerated]
	private sealed class DF374A82
	{
		public string D726C3A2;

		public Class92 F8B3C53D;

		internal void method_0()
		{
			string text = CheckInfoAccountv2.CheckLiveWall(D726C3A2);
			if (text.StartsWith("0|"))
			{
				F8B3C53D.fTienIchCheckLiveUid_0.method_1(F8B3C53D.fTienIchCheckLiveUid_0.txtDie, D726C3A2);
			}
			else if (text.StartsWith("1|"))
			{
				F8B3C53D.fTienIchCheckLiveUid_0.method_1(F8B3C53D.fTienIchCheckLiveUid_0.txtLive, D726C3A2);
			}
			else
			{
				F8B3C53D.fTienIchCheckLiveUid_0.method_1(F8B3C53D.fTienIchCheckLiveUid_0.DC3E8A8C, D726C3A2);
			}
			Interlocked.Decrement(ref F8B3C53D.F4BB2ABC);
		}
	}

	[CompilerGenerated]
	private sealed class Class93
	{
		public RichTextBox richTextBox_0;

		public string BF95A634;

		internal void method_0()
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + BF95A634 + "\r\n";
		}
	}

	private IContainer B13EE594 = null;

	private BunifuCards B71BF386;

	private Panel B395632A;

	private BunifuDragControl D5BC1B33;

	private ToolTip toolTip_0;

	private BunifuCards bunifuCards2;

	private Panel D595F413;

	private Button AEB3789B;

	private PictureBox pictureBox1;

	private BunifuCustomLabel lblTitle;

	private Button btnAdd;

	private RichTextBox B23EDE1A;

	private GroupBox grDaTao;

	private RichTextBox txtLive;

	private GroupBox groupBox1;

	private GroupBox grChuaTao;

	private RichTextBox txtDie;

	private Label DF3136B7;

	private GroupBox grKhongCheckDuoc;

	private RichTextBox DC3E8A8C;

	private NumericUpDown CE81D70E;

	private Label label2;

	public fTienIchCheckLiveUid()
	{
		B785828B();
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(groupBox1);
	}

	private void AEB3789B_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			list = B23EDE1A.Lines.ToList();
			int F4BB2ABC = 0;
			int num = Convert.ToInt32(CE81D70E.Value);
			if (num == 0)
			{
				MessageBoxHelper.Show("Số luồng phải >0, vui lòng nhập lại!", 3);
				return;
			}
			if (list.Count < num)
			{
				num = list.Count;
			}
			DF3136B7.Invoke((MethodInvoker)delegate
			{
				DF3136B7.Visible = true;
			});
			int num2 = 0;
			while (num2 < list.Count)
			{
				if (F4BB2ABC < num)
				{
					Interlocked.Increment(ref F4BB2ABC);
					string D726C3A2 = list[num2++];
					new Thread((ThreadStart)delegate
					{
						string text = CheckInfoAccountv2.CheckLiveWall(D726C3A2);
						if (text.StartsWith("0|"))
						{
							method_1(txtDie, D726C3A2);
						}
						else if (text.StartsWith("1|"))
						{
							method_1(txtLive, D726C3A2);
						}
						else
						{
							method_1(DC3E8A8C, D726C3A2);
						}
						Interlocked.Decrement(ref F4BB2ABC);
					}).Start();
				}
				else
				{
					Application.DoEvents();
					Common.Sleep(1.0);
				}
			}
			while (F4BB2ABC > 0)
			{
				Common.Sleep(1.0);
			}
			DF3136B7.Invoke((MethodInvoker)delegate
			{
				DF3136B7.Visible = false;
			});
			MessageBoxHelper.Show("Đã check xong!");
		}
		catch (Exception)
		{
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void method_1(RichTextBox richTextBox_0, string EBBA94A2)
	{
		richTextBox_0.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + EBBA94A2 + "\r\n";
		});
	}

	private void B23EDE1A_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = B23EDE1A.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			groupBox1.Text = string.Format(Language.GetValue("Nhập Uid ({0})"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void D8AA2CBA(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtLive.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			grDaTao.Text = "LIVE (" + a2AB53A.Count + ")";
		}
		catch
		{
		}
	}

	private void E22BF89F(object sender, PaintEventArgs e)
	{
	}

	private void E83C2235(object sender, EventArgs e)
	{
	}

	private void AD199A25(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtDie.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			grChuaTao.Text = "DIE (" + a2AB53A.Count + ")";
		}
		catch
		{
		}
	}

	private void BE3D52BE(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = DC3E8A8C.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			grKhongCheckDuoc.Text = string.Format(Language.GetValue("Không check được ({0})"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void E70D8003(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool CEB10D07)
	{
		if (CEB10D07 && B13EE594 != null)
		{
			B13EE594.Dispose();
		}
		base.Dispose(CEB10D07);
	}

	private void B785828B()
	{
		B13EE594 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fTienIchCheckLiveUid));
		B71BF386 = new BunifuCards();
		B395632A = new Panel();
		CE81D70E = new NumericUpDown();
		label2 = new Label();
		DF3136B7 = new Label();
		grKhongCheckDuoc = new GroupBox();
		DC3E8A8C = new RichTextBox();
		grChuaTao = new GroupBox();
		txtDie = new RichTextBox();
		grDaTao = new GroupBox();
		txtLive = new RichTextBox();
		groupBox1 = new GroupBox();
		B23EDE1A = new RichTextBox();
		btnAdd = new Button();
		bunifuCards2 = new BunifuCards();
		D595F413 = new Panel();
		AEB3789B = new Button();
		pictureBox1 = new PictureBox();
		lblTitle = new BunifuCustomLabel();
		D5BC1B33 = new BunifuDragControl(B13EE594);
		toolTip_0 = new ToolTip(B13EE594);
		B395632A.SuspendLayout();
		((ISupportInitialize)CE81D70E).BeginInit();
		grKhongCheckDuoc.SuspendLayout();
		grChuaTao.SuspendLayout();
		grDaTao.SuspendLayout();
		groupBox1.SuspendLayout();
		bunifuCards2.SuspendLayout();
		D595F413.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		B71BF386.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B71BF386.BackColor = Color.White;
		B71BF386.BorderRadius = 5;
		B71BF386.BottomSahddow = true;
		B71BF386.color = Color.SaddleBrown;
		B71BF386.LeftSahddow = false;
		B71BF386.Location = new Point(0, 0);
		B71BF386.Margin = new Padding(3, 4, 3, 4);
		B71BF386.Name = "bunifuCards1";
		B71BF386.RightSahddow = true;
		B71BF386.ShadowDepth = 20;
		B71BF386.Size = new Size(649, 47);
		B71BF386.TabIndex = 12;
		B395632A.BackColor = Color.White;
		B395632A.BorderStyle = BorderStyle.FixedSingle;
		B395632A.Controls.Add(CE81D70E);
		B395632A.Controls.Add(label2);
		B395632A.Controls.Add(DF3136B7);
		B395632A.Controls.Add(grKhongCheckDuoc);
		B395632A.Controls.Add(grChuaTao);
		B395632A.Controls.Add(grDaTao);
		B395632A.Controls.Add(groupBox1);
		B395632A.Controls.Add(btnAdd);
		B395632A.Controls.Add(bunifuCards2);
		B395632A.Dock = DockStyle.Fill;
		B395632A.Location = new Point(0, 0);
		B395632A.Margin = new Padding(3, 4, 3, 4);
		B395632A.Name = "panel1";
		B395632A.Size = new Size(978, 407);
		B395632A.TabIndex = 37;
		B395632A.Paint += E22BF89F;
		CE81D70E.Location = new Point(360, 60);
		CE81D70E.Maximum = new decimal(new int[4] { 999999999, 0, 0, 0 });
		CE81D70E.Name = "nudThread";
		CE81D70E.Size = new Size(69, 23);
		CE81D70E.TabIndex = 54;
		CE81D70E.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		label2.AutoSize = true;
		label2.Location = new Point(294, 62);
		label2.Name = "label2";
		label2.Size = new Size(59, 16);
		label2.TabIndex = 53;
		label2.Text = "Threads:";
		DF3136B7.AutoSize = true;
		DF3136B7.ForeColor = Color.DarkGreen;
		DF3136B7.Location = new Point(617, 62);
		DF3136B7.Name = "lblStatus";
		DF3136B7.Size = new Size(70, 16);
		DF3136B7.TabIndex = 52;
		DF3136B7.Text = "Checking...";
		DF3136B7.Visible = false;
		grKhongCheckDuoc.Controls.Add(DC3E8A8C);
		grKhongCheckDuoc.ForeColor = Color.Red;
		grKhongCheckDuoc.Location = new Point(748, 91);
		grKhongCheckDuoc.Name = "grKhongCheckDuoc";
		grKhongCheckDuoc.Size = new Size(221, 307);
		grKhongCheckDuoc.TabIndex = 51;
		grKhongCheckDuoc.TabStop = false;
		grKhongCheckDuoc.Text = "Can't check (0)";
		DC3E8A8C.Dock = DockStyle.Fill;
		DC3E8A8C.Location = new Point(3, 19);
		DC3E8A8C.Name = "txtKhongCheckDuoc";
		DC3E8A8C.Size = new Size(215, 285);
		DC3E8A8C.TabIndex = 50;
		DC3E8A8C.Text = "";
		DC3E8A8C.WordWrap = false;
		DC3E8A8C.TextChanged += BE3D52BE;
		grChuaTao.Controls.Add(txtDie);
		grChuaTao.ForeColor = Color.DarkRed;
		grChuaTao.Location = new Point(521, 91);
		grChuaTao.Name = "grChuaTao";
		grChuaTao.Size = new Size(221, 307);
		grChuaTao.TabIndex = 51;
		grChuaTao.TabStop = false;
		grChuaTao.Text = "DIE (0)";
		txtDie.Dock = DockStyle.Fill;
		txtDie.Location = new Point(3, 19);
		txtDie.Name = "txtDie";
		txtDie.Size = new Size(215, 285);
		txtDie.TabIndex = 50;
		txtDie.Text = "";
		txtDie.WordWrap = false;
		txtDie.TextChanged += AD199A25;
		grDaTao.Controls.Add(txtLive);
		grDaTao.ForeColor = Color.DarkGreen;
		grDaTao.Location = new Point(294, 91);
		grDaTao.Name = "grDaTao";
		grDaTao.Size = new Size(221, 307);
		grDaTao.TabIndex = 51;
		grDaTao.TabStop = false;
		grDaTao.Text = "LIVE (0)";
		txtLive.Dock = DockStyle.Fill;
		txtLive.Location = new Point(3, 19);
		txtLive.Name = "txtLive";
		txtLive.Size = new Size(215, 285);
		txtLive.TabIndex = 50;
		txtLive.Text = "";
		txtLive.WordWrap = false;
		txtLive.TextChanged += D8AA2CBA;
		groupBox1.Controls.Add(B23EDE1A);
		groupBox1.Location = new Point(6, 40);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(282, 358);
		groupBox1.TabIndex = 51;
		groupBox1.TabStop = false;
		groupBox1.Text = "Nhập Uid (0)";
		B23EDE1A.Location = new Point(9, 19);
		B23EDE1A.Name = "txtInput";
		B23EDE1A.Size = new Size(267, 336);
		B23EDE1A.TabIndex = 50;
		B23EDE1A.Text = "";
		B23EDE1A.WordWrap = false;
		B23EDE1A.TextChanged += B23EDE1A_TextChanged;
		btnAdd.BackColor = Color.Green;
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(476, 52);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(135, 36);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Check";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		bunifuCards2.BackColor = Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = Color.SaddleBrown;
		bunifuCards2.Controls.Add(D595F413);
		bunifuCards2.Dock = DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new Size(976, 37);
		bunifuCards2.TabIndex = 43;
		D595F413.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		D595F413.BackColor = Color.White;
		D595F413.Controls.Add(AEB3789B);
		D595F413.Controls.Add(pictureBox1);
		D595F413.Controls.Add(lblTitle);
		D595F413.Cursor = Cursors.SizeAll;
		D595F413.Location = new Point(0, 3);
		D595F413.Name = "pnlHeader";
		D595F413.Size = new Size(976, 31);
		D595F413.TabIndex = 9;
		AEB3789B.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		AEB3789B.Cursor = Cursors.Hand;
		AEB3789B.FlatAppearance.BorderSize = 0;
		AEB3789B.FlatStyle = FlatStyle.Flat;
		AEB3789B.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		AEB3789B.ForeColor = Color.White;
		AEB3789B.Image = Resources.C400940B;
		AEB3789B.Location = new Point(945, 1);
		AEB3789B.Name = "button2";
		AEB3789B.Size = new Size(30, 30);
		AEB3789B.TabIndex = 77;
		AEB3789B.TextImageRelation = TextImageRelation.ImageBeforeText;
		AEB3789B.UseVisualStyleBackColor = true;
		AEB3789B.Click += AEB3789B_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		lblTitle.BackColor = Color.Transparent;
		lblTitle.Cursor = Cursors.SizeAll;
		lblTitle.Dock = DockStyle.Fill;
		lblTitle.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		lblTitle.ForeColor = Color.Black;
		lblTitle.Location = new Point(0, 0);
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new Size(976, 31);
		lblTitle.TabIndex = 12;
		lblTitle.Text = "Check Live Uid";
		lblTitle.TextAlign = ContentAlignment.MiddleCenter;
		D5BC1B33.Fixed = true;
		D5BC1B33.Horizontal = true;
		D5BC1B33.TargetControl = lblTitle;
		D5BC1B33.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(978, 407);
		base.Controls.Add(B395632A);
		base.Controls.Add(B71BF386);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fTienIchCheckLiveUid";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += E83C2235;
		B395632A.ResumeLayout(performLayout: false);
		B395632A.PerformLayout();
		((ISupportInitialize)CE81D70E).EndInit();
		grKhongCheckDuoc.ResumeLayout(performLayout: false);
		grChuaTao.ResumeLayout(performLayout: false);
		grDaTao.ResumeLayout(performLayout: false);
		groupBox1.ResumeLayout(performLayout: false);
		bunifuCards2.ResumeLayout(performLayout: false);
		D595F413.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void AE8B9819()
	{
		DF3136B7.Visible = true;
	}

	[CompilerGenerated]
	private void method_2()
	{
		DF3136B7.Visible = false;
	}
}
