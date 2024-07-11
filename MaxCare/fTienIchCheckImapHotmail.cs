using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckImapHotmail : Form
{
	[CompilerGenerated]
	private sealed class F68C2220
	{
		public int int_0;

		public fTienIchCheckImapHotmail fTienIchCheckImapHotmail_0;
	}

	[CompilerGenerated]
	private sealed class Class97
	{
		public string string_0;

		public F68C2220 f68C2220_0;

		internal void method_0()
		{
			if (f68C2220_0.fTienIchCheckImapHotmail_0.F019AB1A(string_0))
			{
				f68C2220_0.fTienIchCheckImapHotmail_0.D4297A01(f68C2220_0.fTienIchCheckImapHotmail_0.txtDaTao, string_0);
			}
			else
			{
				f68C2220_0.fTienIchCheckImapHotmail_0.D4297A01(f68C2220_0.fTienIchCheckImapHotmail_0.BB37FF36, string_0);
			}
			Interlocked.Decrement(ref f68C2220_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class98
	{
		public RichTextBox richTextBox_0;

		public string F587341D;

		internal void method_0()
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + F587341D + "\r\n";
		}
	}

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl EB005089;

	private ToolTip ADB0058E;

	private BunifuCards bunifuCards2;

	private Panel DF2E0DB9;

	private Button A98BD5B2;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel C68B96BC;

	private Button AC1BDAB6;

	private RichTextBox txtInput;

	private GroupBox grDaTao;

	private RichTextBox txtDaTao;

	private GroupBox groupBox1;

	private Button DD2E1E38;

	private TextBox B734719E;

	private RadioButton C217763A;

	private RadioButton D12B9A9E;

	private GroupBox A1920417;

	private RichTextBox BB37FF36;

	private Label D8A0A13F;

	public fTienIchCheckImapHotmail()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(D12B9A9E);
		Language.smethod_0(DD2E1E38);
		Language.smethod_0(C217763A);
	}

	private void A98BD5B2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AC1BDAB6_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			string text = B734719E.Text.Trim();
			if (D12B9A9E.Checked)
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
			if (D12B9A9E.Checked)
			{
				list = File.ReadAllLines(text).ToList();
			}
			else if (C217763A.Checked)
			{
				list = txtInput.Lines.ToList();
			}
			int int_0 = 0;
			int num = 50;
			D8A0A13F.Invoke((MethodInvoker)delegate
			{
				D8A0A13F.Visible = true;
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
						if (F019AB1A(string_0))
						{
							D4297A01(txtDaTao, string_0);
						}
						else
						{
							D4297A01(BB37FF36, string_0);
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
			D8A0A13F.Invoke((MethodInvoker)delegate
			{
				D8A0A13F.Visible = false;
			});
			MessageBoxHelper.Show("Đã check xong!");
		}
		catch (Exception)
		{
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void D4297A01(RichTextBox B01231A3, string string_0)
	{
		B01231A3.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			RichTextBox richTextBox = B01231A3;
			richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
		});
	}

	private bool F019AB1A(string E60D3499)
	{
		try
		{
			string[] array = E60D3499.Split('|');
			string text = array[0];
			string text2 = array[1];
			if (text == "" || text2 == "")
			{
				return false;
			}
			return Imap.CheckConnectImap(text, text2);
		}
		catch
		{
		}
		return false;
	}

	private void AB1A5999(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtInput.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			C217763A.Text = string.Format(Language.GetValue("Tự nhập ({0})"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void D12B9A9E_CheckedChanged(object sender, EventArgs e)
	{
		B734719E.Enabled = D12B9A9E.Checked;
		DD2E1E38.Enabled = D12B9A9E.Checked;
	}

	private void C217763A_CheckedChanged(object sender, EventArgs e)
	{
		txtInput.Enabled = C217763A.Checked;
	}

	private void F62288A5(object sender, EventArgs e)
	{
		B734719E.Text = Common.SelectFile();
	}

	private void D589A996(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtDaTao.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			grDaTao.Text = string.Format(Language.GetValue("Live ({0})"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void fTienIchCheckImapHotmail_Load(object sender, EventArgs e)
	{
		D12B9A9E_CheckedChanged(null, null);
		C217763A_CheckedChanged(null, null);
	}

	private void BB37FF36_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = BB37FF36.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			A1920417.Text = string.Format(Language.GetValue("Die ({0})"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool B339BC39)
	{
		if (B339BC39 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B339BC39);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.panel1 = new System.Windows.Forms.Panel();
		this.D8A0A13F = new System.Windows.Forms.Label();
		this.A1920417 = new System.Windows.Forms.GroupBox();
		this.BB37FF36 = new System.Windows.Forms.RichTextBox();
		this.grDaTao = new System.Windows.Forms.GroupBox();
		this.txtDaTao = new System.Windows.Forms.RichTextBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.DD2E1E38 = new System.Windows.Forms.Button();
		this.txtInput = new System.Windows.Forms.RichTextBox();
		this.B734719E = new System.Windows.Forms.TextBox();
		this.C217763A = new System.Windows.Forms.RadioButton();
		this.D12B9A9E = new System.Windows.Forms.RadioButton();
		this.AC1BDAB6 = new System.Windows.Forms.Button();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.DF2E0DB9 = new System.Windows.Forms.Panel();
		this.A98BD5B2 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.C68B96BC = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.EB005089 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.ADB0058E = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.panel1.SuspendLayout();
		this.A1920417.SuspendLayout();
		this.grDaTao.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.bunifuCards2.SuspendLayout();
		this.DF2E0DB9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 5;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(466, 47);
		this.bunifuCards1.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.D8A0A13F);
		this.panel1.Controls.Add(this.A1920417);
		this.panel1.Controls.Add(this.grDaTao);
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.AC1BDAB6);
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(795, 404);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.D8A0A13F.AutoSize = true;
		this.D8A0A13F.ForeColor = System.Drawing.Color.DarkGreen;
		this.D8A0A13F.Location = new System.Drawing.Point(480, 59);
		this.D8A0A13F.Name = "lblStatus";
		this.D8A0A13F.Size = new System.Drawing.Size(70, 16);
		this.D8A0A13F.TabIndex = 52;
		this.D8A0A13F.Text = "Checking...";
		this.D8A0A13F.Visible = false;
		this.A1920417.Controls.Add(this.BB37FF36);
		this.A1920417.ForeColor = System.Drawing.Color.DarkRed;
		this.A1920417.Location = new System.Drawing.Point(566, 91);
		this.A1920417.Name = "grChuaTao";
		this.A1920417.Size = new System.Drawing.Size(221, 307);
		this.A1920417.TabIndex = 51;
		this.A1920417.TabStop = false;
		this.A1920417.Text = "Die (0)";
		this.BB37FF36.Dock = System.Windows.Forms.DockStyle.Fill;
		this.BB37FF36.Location = new System.Drawing.Point(3, 19);
		this.BB37FF36.Name = "txtChuaTao";
		this.BB37FF36.Size = new System.Drawing.Size(215, 285);
		this.BB37FF36.TabIndex = 50;
		this.BB37FF36.Text = "";
		this.BB37FF36.WordWrap = false;
		this.BB37FF36.TextChanged += new System.EventHandler(BB37FF36_TextChanged);
		this.grDaTao.Controls.Add(this.txtDaTao);
		this.grDaTao.ForeColor = System.Drawing.Color.DarkGreen;
		this.grDaTao.Location = new System.Drawing.Point(339, 91);
		this.grDaTao.Name = "grDaTao";
		this.grDaTao.Size = new System.Drawing.Size(221, 307);
		this.grDaTao.TabIndex = 51;
		this.grDaTao.TabStop = false;
		this.grDaTao.Text = "Live (0)";
		this.txtDaTao.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtDaTao.Location = new System.Drawing.Point(3, 19);
		this.txtDaTao.Name = "txtDaTao";
		this.txtDaTao.Size = new System.Drawing.Size(215, 285);
		this.txtDaTao.TabIndex = 50;
		this.txtDaTao.Text = "";
		this.txtDaTao.WordWrap = false;
		this.txtDaTao.TextChanged += new System.EventHandler(D589A996);
		this.groupBox1.Controls.Add(this.DD2E1E38);
		this.groupBox1.Controls.Add(this.txtInput);
		this.groupBox1.Controls.Add(this.B734719E);
		this.groupBox1.Controls.Add(this.C217763A);
		this.groupBox1.Controls.Add(this.D12B9A9E);
		this.groupBox1.Location = new System.Drawing.Point(6, 40);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(316, 358);
		this.groupBox1.TabIndex = 51;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Input: Email|Pass mail";
		this.DD2E1E38.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DD2E1E38.Location = new System.Drawing.Point(243, 22);
		this.DD2E1E38.Name = "btnNhapTuFile";
		this.DD2E1E38.Size = new System.Drawing.Size(64, 24);
		this.DD2E1E38.TabIndex = 2;
		this.DD2E1E38.Text = "Chọn";
		this.DD2E1E38.Click += new System.EventHandler(F62288A5);
		this.txtInput.Location = new System.Drawing.Point(30, 75);
		this.txtInput.Name = "txtInput";
		this.txtInput.Size = new System.Drawing.Size(277, 277);
		this.txtInput.TabIndex = 50;
		this.txtInput.Text = "";
		this.txtInput.WordWrap = false;
		this.txtInput.TextChanged += new System.EventHandler(AB1A5999);
		this.B734719E.Location = new System.Drawing.Point(110, 22);
		this.B734719E.Name = "txtNhapTuFile";
		this.B734719E.Size = new System.Drawing.Size(127, 23);
		this.B734719E.TabIndex = 1;
		this.C217763A.AutoSize = true;
		this.C217763A.Checked = true;
		this.C217763A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C217763A.Location = new System.Drawing.Point(9, 49);
		this.C217763A.Name = "rbTuNhap";
		this.C217763A.Size = new System.Drawing.Size(94, 20);
		this.C217763A.TabIndex = 0;
		this.C217763A.TabStop = true;
		this.C217763A.Text = "Tự nhập (0)";
		this.C217763A.UseVisualStyleBackColor = true;
		this.C217763A.CheckedChanged += new System.EventHandler(C217763A_CheckedChanged);
		this.D12B9A9E.AutoSize = true;
		this.D12B9A9E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D12B9A9E.Location = new System.Drawing.Point(9, 23);
		this.D12B9A9E.Name = "rbNhapTuFile";
		this.D12B9A9E.Size = new System.Drawing.Size(94, 20);
		this.D12B9A9E.TabIndex = 0;
		this.D12B9A9E.Text = "Nhập từ File";
		this.D12B9A9E.UseVisualStyleBackColor = true;
		this.D12B9A9E.CheckedChanged += new System.EventHandler(D12B9A9E_CheckedChanged);
		this.AC1BDAB6.BackColor = System.Drawing.Color.Green;
		this.AC1BDAB6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AC1BDAB6.FlatAppearance.BorderSize = 0;
		this.AC1BDAB6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.AC1BDAB6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AC1BDAB6.ForeColor = System.Drawing.Color.White;
		this.AC1BDAB6.Location = new System.Drawing.Point(339, 49);
		this.AC1BDAB6.Name = "btnAdd";
		this.AC1BDAB6.Size = new System.Drawing.Size(135, 36);
		this.AC1BDAB6.TabIndex = 45;
		this.AC1BDAB6.Text = "Check";
		this.AC1BDAB6.UseVisualStyleBackColor = false;
		this.AC1BDAB6.Click += new System.EventHandler(AC1BDAB6_Click);
		this.bunifuCards2.BackColor = System.Drawing.Color.White;
		this.bunifuCards2.BorderRadius = 0;
		this.bunifuCards2.BottomSahddow = true;
		this.bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards2.Controls.Add(this.DF2E0DB9);
		this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards2.LeftSahddow = false;
		this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards2.Name = "bunifuCards2";
		this.bunifuCards2.RightSahddow = true;
		this.bunifuCards2.ShadowDepth = 20;
		this.bunifuCards2.Size = new System.Drawing.Size(793, 37);
		this.bunifuCards2.TabIndex = 43;
		this.DF2E0DB9.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.DF2E0DB9.BackColor = System.Drawing.Color.White;
		this.DF2E0DB9.Controls.Add(this.A98BD5B2);
		this.DF2E0DB9.Controls.Add(this.pictureBox1);
		this.DF2E0DB9.Controls.Add(this.btnMinimize);
		this.DF2E0DB9.Controls.Add(this.C68B96BC);
		this.DF2E0DB9.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.DF2E0DB9.Location = new System.Drawing.Point(0, 3);
		this.DF2E0DB9.Name = "pnlHeader";
		this.DF2E0DB9.Size = new System.Drawing.Size(793, 31);
		this.DF2E0DB9.TabIndex = 9;
		this.A98BD5B2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.A98BD5B2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A98BD5B2.FlatAppearance.BorderSize = 0;
		this.A98BD5B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A98BD5B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A98BD5B2.ForeColor = System.Drawing.Color.White;
		this.A98BD5B2.Image = Resources.C400940B;
		this.A98BD5B2.Location = new System.Drawing.Point(762, 1);
		this.A98BD5B2.Name = "button2";
		this.A98BD5B2.Size = new System.Drawing.Size(30, 30);
		this.A98BD5B2.TabIndex = 77;
		this.A98BD5B2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.A98BD5B2.UseVisualStyleBackColor = true;
		this.A98BD5B2.Click += new System.EventHandler(A98BD5B2_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Location = new System.Drawing.Point(899, 1);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(30, 30);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.C68B96BC.BackColor = System.Drawing.Color.Transparent;
		this.C68B96BC.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.C68B96BC.Dock = System.Windows.Forms.DockStyle.Fill;
		this.C68B96BC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C68B96BC.ForeColor = System.Drawing.Color.Black;
		this.C68B96BC.Location = new System.Drawing.Point(0, 0);
		this.C68B96BC.Name = "lblTitle";
		this.C68B96BC.Size = new System.Drawing.Size(793, 31);
		this.C68B96BC.TabIndex = 12;
		this.C68B96BC.Text = "Check có thể kết nối Email bằng Imap không?";
		this.C68B96BC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.EB005089.Fixed = true;
		this.EB005089.Horizontal = true;
		this.EB005089.TargetControl = this.C68B96BC;
		this.EB005089.Vertical = true;
		this.ADB0058E.AutomaticDelay = 0;
		this.ADB0058E.AutoPopDelay = 10000;
		this.ADB0058E.InitialDelay = 200;
		this.ADB0058E.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(795, 404);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchCheckImapHotmail";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fTienIchCheckImapHotmail_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.A1920417.ResumeLayout(false);
		this.grDaTao.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.bunifuCards2.ResumeLayout(false);
		this.DF2E0DB9.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_1()
	{
		D8A0A13F.Visible = true;
	}

	[CompilerGenerated]
	private void A33F7531()
	{
		D8A0A13F.Visible = false;
	}
}
