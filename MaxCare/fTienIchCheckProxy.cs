using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckProxy : Form
{
	[CompilerGenerated]
	private sealed class Class94
	{
		public int F023F223;

		public int int_0;

		public fTienIchCheckProxy fTienIchCheckProxy_0;
	}

	[CompilerGenerated]
	private sealed class Class95
	{
		public string string_0;

		public Class94 class94_0;

		internal void method_0()
		{
			if (class94_0.fTienIchCheckProxy_0.C33E560A(string_0, class94_0.F023F223))
			{
				class94_0.fTienIchCheckProxy_0.EFB67280(class94_0.fTienIchCheckProxy_0.B5113D99, string_0);
			}
			else
			{
				class94_0.fTienIchCheckProxy_0.EFB67280(class94_0.fTienIchCheckProxy_0.txtChuaTao, string_0);
			}
			Interlocked.Decrement(ref class94_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class96
	{
		public RichTextBox richTextBox_0;

		public string string_0;

		internal void method_0()
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
		}
	}

	private IContainer icontainer_0 = null;

	private BunifuCards BC24B59D;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip FC825111;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private Button D39CF30D;

	private BunifuCustomLabel lblTitle;

	private Button btnAdd;

	private RichTextBox C02B6DB3;

	private GroupBox grDaTao;

	private RichTextBox B5113D99;

	private GroupBox groupBox1;

	private GroupBox grChuaTao;

	private RichTextBox txtChuaTao;

	private Label lblStatus;

	private ComboBox D609B807;

	private Label label3;

	public fTienIchCheckProxy()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(groupBox1);
		Language.smethod_0(label3);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			int F023F223 = D609B807.SelectedIndex;
			List<string> list = new List<string>();
			list = C02B6DB3.Lines.ToList();
			int int_0 = 0;
			int num = 50;
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Visible = true;
			});
			int num2 = 0;
			while (num2 < list.Count)
			{
				if (int_0 < num)
				{
					Interlocked.Increment(ref int_0);
					string string_0 = list[num2++];
					new Thread((ThreadStart)delegate
					{
						if (C33E560A(string_0, F023F223))
						{
							EFB67280(B5113D99, string_0);
						}
						else
						{
							EFB67280(txtChuaTao, string_0);
						}
						Interlocked.Decrement(ref int_0);
					}).Start();
				}
				else
				{
					Application.DoEvents();
					Common.Sleep(1.0);
				}
			}
			while (int_0 > 0)
			{
				Common.Sleep(1.0);
			}
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Visible = false;
			});
			MessageBoxHelper.Show("Đã check xong!");
		}
		catch (Exception)
		{
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void EFB67280(RichTextBox C68F3684, string D21ED9A1)
	{
		C68F3684.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			RichTextBox richTextBox = C68F3684;
			richTextBox.Text = richTextBox.Text + D21ED9A1 + "\r\n";
		});
	}

	private bool C33E560A(string D380EAB8, int int_0)
	{
		try
		{
			if (Common.CheckIP(D380EAB8, int_0) != "")
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private void EBA5F507(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = C02B6DB3.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			groupBox1.Text = string.Format(Language.GetValue("Nhập Proxy ({0})"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void B5113D99_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = B5113D99.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			grDaTao.Text = "LIVE (" + a2AB53A.Count + ")";
		}
		catch
		{
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void fTienIchCheckProxy_Load(object sender, EventArgs e)
	{
		D609B807.SelectedIndex = 0;
	}

	private void txtChuaTao_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtChuaTao.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			grChuaTao.Text = "DIE (" + a2AB53A.Count + ")";
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
		this.BC24B59D = new Bunifu.Framework.UI.BunifuCards();
		this.panel1 = new System.Windows.Forms.Panel();
		this.lblStatus = new System.Windows.Forms.Label();
		this.grChuaTao = new System.Windows.Forms.GroupBox();
		this.txtChuaTao = new System.Windows.Forms.RichTextBox();
		this.grDaTao = new System.Windows.Forms.GroupBox();
		this.B5113D99 = new System.Windows.Forms.RichTextBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.D609B807 = new System.Windows.Forms.ComboBox();
		this.label3 = new System.Windows.Forms.Label();
		this.C02B6DB3 = new System.Windows.Forms.RichTextBox();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.D39CF30D = new System.Windows.Forms.Button();
		this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.FC825111 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.panel1.SuspendLayout();
		this.grChuaTao.SuspendLayout();
		this.grDaTao.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.bunifuCards2.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.BC24B59D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.BC24B59D.BackColor = System.Drawing.Color.White;
		this.BC24B59D.BorderRadius = 5;
		this.BC24B59D.BottomSahddow = true;
		this.BC24B59D.color = System.Drawing.Color.SaddleBrown;
		this.BC24B59D.LeftSahddow = false;
		this.BC24B59D.Location = new System.Drawing.Point(0, 0);
		this.BC24B59D.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.BC24B59D.Name = "bunifuCards1";
		this.BC24B59D.RightSahddow = true;
		this.BC24B59D.ShadowDepth = 20;
		this.BC24B59D.Size = new System.Drawing.Size(421, 47);
		this.BC24B59D.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.lblStatus);
		this.panel1.Controls.Add(this.grChuaTao);
		this.panel1.Controls.Add(this.grDaTao);
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(750, 404);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.lblStatus.AutoSize = true;
		this.lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
		this.lblStatus.Location = new System.Drawing.Point(435, 59);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(71, 16);
		this.lblStatus.TabIndex = 52;
		this.lblStatus.Text = "Checking...";
		this.lblStatus.Visible = false;
		this.grChuaTao.Controls.Add(this.txtChuaTao);
		this.grChuaTao.ForeColor = System.Drawing.Color.DarkRed;
		this.grChuaTao.Location = new System.Drawing.Point(521, 91);
		this.grChuaTao.Name = "grChuaTao";
		this.grChuaTao.Size = new System.Drawing.Size(221, 307);
		this.grChuaTao.TabIndex = 51;
		this.grChuaTao.TabStop = false;
		this.grChuaTao.Text = "DIE (0)";
		this.txtChuaTao.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtChuaTao.Location = new System.Drawing.Point(3, 19);
		this.txtChuaTao.Name = "txtChuaTao";
		this.txtChuaTao.Size = new System.Drawing.Size(215, 285);
		this.txtChuaTao.TabIndex = 50;
		this.txtChuaTao.Text = "";
		this.txtChuaTao.WordWrap = false;
		this.txtChuaTao.TextChanged += new System.EventHandler(txtChuaTao_TextChanged);
		this.grDaTao.Controls.Add(this.B5113D99);
		this.grDaTao.ForeColor = System.Drawing.Color.DarkGreen;
		this.grDaTao.Location = new System.Drawing.Point(294, 91);
		this.grDaTao.Name = "grDaTao";
		this.grDaTao.Size = new System.Drawing.Size(221, 307);
		this.grDaTao.TabIndex = 51;
		this.grDaTao.TabStop = false;
		this.grDaTao.Text = "LIVE (0)";
		this.B5113D99.Dock = System.Windows.Forms.DockStyle.Fill;
		this.B5113D99.Location = new System.Drawing.Point(3, 19);
		this.B5113D99.Name = "txtDaTao";
		this.B5113D99.Size = new System.Drawing.Size(215, 285);
		this.B5113D99.TabIndex = 50;
		this.B5113D99.Text = "";
		this.B5113D99.WordWrap = false;
		this.B5113D99.TextChanged += new System.EventHandler(B5113D99_TextChanged);
		this.groupBox1.Controls.Add(this.D609B807);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.C02B6DB3);
		this.groupBox1.Location = new System.Drawing.Point(6, 40);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(282, 358);
		this.groupBox1.TabIndex = 51;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Nhập Proxy (0)";
		this.D609B807.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D609B807.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.D609B807.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D609B807.FormattingEnabled = true;
		this.D609B807.Items.AddRange(new object[2] { "HTTP/HTTPS", "Sock5" });
		this.D609B807.Location = new System.Drawing.Point(83, 324);
		this.D609B807.Name = "cbbTypeProxy";
		this.D609B807.Size = new System.Drawing.Size(193, 24);
		this.D609B807.TabIndex = 126;
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(6, 327);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(71, 16);
		this.label3.TabIndex = 125;
		this.label3.Text = "Loa\u0323i Proxy:";
		this.C02B6DB3.Location = new System.Drawing.Point(9, 19);
		this.C02B6DB3.Name = "txtInput";
		this.C02B6DB3.Size = new System.Drawing.Size(267, 299);
		this.C02B6DB3.TabIndex = 50;
		this.C02B6DB3.Text = "";
		this.C02B6DB3.WordWrap = false;
		this.C02B6DB3.TextChanged += new System.EventHandler(EBA5F507);
		this.btnAdd.BackColor = System.Drawing.Color.Green;
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(294, 49);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(135, 36);
		this.btnAdd.TabIndex = 45;
		this.btnAdd.Text = "Check";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuCards2.BackColor = System.Drawing.Color.White;
		this.bunifuCards2.BorderRadius = 0;
		this.bunifuCards2.BottomSahddow = true;
		this.bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards2.Controls.Add(this.pnlHeader);
		this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards2.LeftSahddow = false;
		this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards2.Name = "bunifuCards2";
		this.bunifuCards2.RightSahddow = true;
		this.bunifuCards2.ShadowDepth = 20;
		this.bunifuCards2.Size = new System.Drawing.Size(748, 37);
		this.bunifuCards2.TabIndex = 43;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button2);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.D39CF30D);
		this.pnlHeader.Controls.Add(this.lblTitle);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(748, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Resources.C400940B;
		this.button2.Location = new System.Drawing.Point(717, 1);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(30, 30);
		this.button2.TabIndex = 77;
		this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.D39CF30D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D39CF30D.FlatAppearance.BorderSize = 0;
		this.D39CF30D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D39CF30D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D39CF30D.ForeColor = System.Drawing.Color.White;
		this.D39CF30D.Location = new System.Drawing.Point(899, 1);
		this.D39CF30D.Name = "btnMinimize";
		this.D39CF30D.Size = new System.Drawing.Size(30, 30);
		this.D39CF30D.TabIndex = 9;
		this.D39CF30D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.D39CF30D.UseVisualStyleBackColor = true;
		this.lblTitle.BackColor = System.Drawing.Color.Transparent;
		this.lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTitle.ForeColor = System.Drawing.Color.Black;
		this.lblTitle.Location = new System.Drawing.Point(0, 0);
		this.lblTitle.Name = "lblTitle";
		this.lblTitle.Size = new System.Drawing.Size(748, 31);
		this.lblTitle.TabIndex = 12;
		this.lblTitle.Text = "Check Proxy";
		this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.lblTitle;
		this.bunifuDragControl_0.Vertical = true;
		this.FC825111.AutomaticDelay = 0;
		this.FC825111.AutoPopDelay = 10000;
		this.FC825111.InitialDelay = 200;
		this.FC825111.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(750, 404);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.BC24B59D);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchCheckProxy";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fTienIchCheckProxy_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.grChuaTao.ResumeLayout(false);
		this.grDaTao.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_1()
	{
		lblStatus.Visible = true;
	}

	[CompilerGenerated]
	private void method_2()
	{
		lblStatus.Visible = false;
	}
}
