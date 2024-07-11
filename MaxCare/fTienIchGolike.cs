using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fTienIchGolike : Form
{
	[CompilerGenerated]
	private sealed class DB8B7BAC
	{
		public string EF02193A;

		public string string_0;

		public fTienIchGolike D40E181A;

		internal void method_0()
		{
			Class103 CS_0024_003C_003E8__locals0 = new Class103
			{
				CE341F27 = this,
				A513BC90 = ""
			};
			try
			{
				string a0988CA = CheckInfoAccountv2.GetName(EF02193A);
				CS_0024_003C_003E8__locals0.A513BC90 = Common.smethod_6(GetJobs(Common.B2B3DBBA(string_0), Common.B2B3DBBA(EF02193A), Common.B2B3DBBA(a0988CA), Common.B2B3DBBA(""), Common.B2B3DBBA(""), Common.B2B3DBBA("1")));
				JObject jObject = JObject.Parse(CS_0024_003C_003E8__locals0.A513BC90);
				if (!Convert.ToBoolean(jObject["success"]))
				{
					CS_0024_003C_003E8__locals0.A513BC90 = jObject["message"].ToString();
				}
			}
			catch
			{
			}
			D40E181A.txtKetQua.Invoke((MethodInvoker)delegate
			{
				CS_0024_003C_003E8__locals0.CE341F27.D40E181A.txtKetQua.Text = CS_0024_003C_003E8__locals0.A513BC90;
			});
		}
	}

	[CompilerGenerated]
	private sealed class Class103
	{
		public string A513BC90;

		public DB8B7BAC CE341F27;

		internal void method_0()
		{
			CE341F27.D40E181A.txtKetQua.Text = A513BC90;
		}
	}

	[CompilerGenerated]
	private sealed class Class104
	{
		public string D68C42B2;

		public fTienIchGolike B42BDE20;

		internal void method_0()
		{
			try
			{
				Class105 CS_0024_003C_003E8__locals0 = new Class105
				{
					class104_0 = this,
					C38FC7B1 = GClass17.smethod_0(D68C42B2)
				};
				B42BDE20.txtKetQua.Invoke((MethodInvoker)delegate
				{
					CS_0024_003C_003E8__locals0.class104_0.B42BDE20.txtKetQua.Text = CS_0024_003C_003E8__locals0.C38FC7B1;
				});
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class105
	{
		public string C38FC7B1;

		public Class104 class104_0;

		internal void F42DE815()
		{
			class104_0.B42BDE20.txtKetQua.Text = C38FC7B1;
		}
	}

	public static List<string> list_0;

	public static List<string> C039A397;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel B732670A;

	private BunifuCustomLabel C23EB0AC;

	private Button btnMinimize;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox EA8C3E2A;

	private RichTextBox txtKetQua;

	private Label label1;

	private Button btnCheck;

	private Label label2;

	private TextBox txtApiKey;

	private Label C1815AA1;

	private TextBox txtUid;

	private Button button1;

	public fTienIchGolike()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetJobs(byte[] byte_0, byte[] E3196719, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4);

	private void AE84B20E(object sender, EventArgs e)
	{
		if (txtApiKey.Text.Trim() == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập API Key!", 3);
			txtApiKey.Focus();
			return;
		}
		if (txtUid.Text.Trim() == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập Uid!", 3);
			txtUid.Focus();
			return;
		}
		string string_0 = txtApiKey.Text.Trim();
		string EF02193A = txtUid.Text.Trim();
		List<string> a2AB53A = txtKetQua.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		txtKetQua.Text = "Checking...";
		Thread thread = new Thread((ThreadStart)delegate
		{
			string A513BC90 = "";
			try
			{
				string a0988CA = CheckInfoAccountv2.GetName(EF02193A);
				A513BC90 = Common.smethod_6(GetJobs(Common.B2B3DBBA(string_0), Common.B2B3DBBA(EF02193A), Common.B2B3DBBA(a0988CA), Common.B2B3DBBA(""), Common.B2B3DBBA(""), Common.B2B3DBBA("1")));
				JObject jObject = JObject.Parse(A513BC90);
				if (!Convert.ToBoolean(jObject["success"]))
				{
					A513BC90 = jObject["message"].ToString();
				}
			}
			catch
			{
			}
			txtKetQua.Invoke((MethodInvoker)delegate
			{
				txtKetQua.Text = A513BC90;
			});
		});
		thread.IsBackground = true;
		thread.Start();
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetInfo(byte[] byte_0);

	private void F220D51B(object sender, EventArgs e)
	{
		string D68C42B2 = txtApiKey.Text.Trim();
		if (D68C42B2 == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập API Key!", 3);
			txtApiKey.Focus();
			return;
		}
		txtKetQua.Text = "Checking...";
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string C38FC7B1 = GClass17.smethod_0(D68C42B2);
				txtKetQua.Invoke((MethodInvoker)delegate
				{
					txtKetQua.Text = C38FC7B1;
				});
			}
			catch
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	protected override void Dispose(bool D2032786)
	{
		if (D2032786 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D2032786);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.B732670A = new System.Windows.Forms.Panel();
		this.EA8C3E2A = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.C23EB0AC = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.txtKetQua = new System.Windows.Forms.RichTextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCheck = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.txtApiKey = new System.Windows.Forms.TextBox();
		this.C1815AA1 = new System.Windows.Forms.Label();
		this.txtUid = new System.Windows.Forms.TextBox();
		this.button1 = new System.Windows.Forms.Button();
		this.bunifuCards1.SuspendLayout();
		this.B732670A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.EA8C3E2A).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.B732670A);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(500, 34);
		this.bunifuCards1.TabIndex = 0;
		this.B732670A.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.B732670A.BackColor = System.Drawing.Color.White;
		this.B732670A.Controls.Add(this.EA8C3E2A);
		this.B732670A.Controls.Add(this.btnMinimize);
		this.B732670A.Controls.Add(this.C23EB0AC);
		this.B732670A.Location = new System.Drawing.Point(0, 3);
		this.B732670A.Name = "pnlHeader";
		this.B732670A.Size = new System.Drawing.Size(500, 28);
		this.B732670A.TabIndex = 9;
		this.EA8C3E2A.Cursor = System.Windows.Forms.Cursors.Default;
		this.EA8C3E2A.Image = Resources.Bitmap_4;
		this.EA8C3E2A.Location = new System.Drawing.Point(3, 2);
		this.EA8C3E2A.Name = "pictureBox1";
		this.EA8C3E2A.Size = new System.Drawing.Size(34, 27);
		this.EA8C3E2A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.EA8C3E2A.TabIndex = 17;
		this.EA8C3E2A.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = Resources.C400940B;
		this.btnMinimize.Location = new System.Drawing.Point(468, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 28);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.C23EB0AC.BackColor = System.Drawing.Color.Transparent;
		this.C23EB0AC.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.C23EB0AC.Dock = System.Windows.Forms.DockStyle.Fill;
		this.C23EB0AC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C23EB0AC.ForeColor = System.Drawing.Color.Black;
		this.C23EB0AC.Location = new System.Drawing.Point(0, 0);
		this.C23EB0AC.Name = "bunifuCustomLabel1";
		this.C23EB0AC.Size = new System.Drawing.Size(500, 28);
		this.C23EB0AC.TabIndex = 1;
		this.C23EB0AC.Text = "Check Golike";
		this.C23EB0AC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.C23EB0AC;
		this.bunifuDragControl_0.Vertical = true;
		this.txtKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtKetQua.Font = new System.Drawing.Font("Tahoma", 9.75f);
		this.txtKetQua.Location = new System.Drawing.Point(36, 186);
		this.txtKetQua.Name = "txtKetQua";
		this.txtKetQua.Size = new System.Drawing.Size(432, 136);
		this.txtKetQua.TabIndex = 146;
		this.txtKetQua.Text = "";
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label1.Location = new System.Drawing.Point(33, 167);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(55, 16);
		this.label1.TabIndex = 145;
		this.label1.Text = "Kết quả:";
		this.btnCheck.BackColor = System.Drawing.Color.Green;
		this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCheck.FlatAppearance.BorderSize = 0;
		this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCheck.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCheck.ForeColor = System.Drawing.Color.White;
		this.btnCheck.Location = new System.Drawing.Point(224, 120);
		this.btnCheck.Name = "btnCheck";
		this.btnCheck.Size = new System.Drawing.Size(82, 33);
		this.btnCheck.TabIndex = 147;
		this.btnCheck.Text = "Get Job";
		this.btnCheck.UseVisualStyleBackColor = false;
		this.btnCheck.Click += new System.EventHandler(AE84B20E);
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label2.Location = new System.Drawing.Point(33, 55);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(55, 16);
		this.label2.TabIndex = 145;
		this.label2.Text = "API Key:";
		this.txtApiKey.Font = new System.Drawing.Font("Tahoma", 9.75f);
		this.txtApiKey.Location = new System.Drawing.Point(90, 52);
		this.txtApiKey.Name = "txtApiKey";
		this.txtApiKey.Size = new System.Drawing.Size(309, 23);
		this.txtApiKey.TabIndex = 148;
		this.C1815AA1.AutoSize = true;
		this.C1815AA1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.C1815AA1.Location = new System.Drawing.Point(33, 84);
		this.C1815AA1.Name = "label3";
		this.C1815AA1.Size = new System.Drawing.Size(30, 16);
		this.C1815AA1.TabIndex = 145;
		this.C1815AA1.Text = "Uid:";
		this.txtUid.Font = new System.Drawing.Font("Tahoma", 9.75f);
		this.txtUid.Location = new System.Drawing.Point(90, 81);
		this.txtUid.Name = "txtUid";
		this.txtUid.Size = new System.Drawing.Size(378, 23);
		this.txtUid.TabIndex = 148;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Location = new System.Drawing.Point(405, 51);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(63, 25);
		this.button1.TabIndex = 149;
		this.button1.Text = "Check";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(F220D51B);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(500, 343);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.txtUid);
		base.Controls.Add(this.txtApiKey);
		base.Controls.Add(this.btnCheck);
		base.Controls.Add(this.C1815AA1);
		base.Controls.Add(this.txtKetQua);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fTienIchGolike";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		this.bunifuCards1.ResumeLayout(false);
		this.B732670A.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.EA8C3E2A).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
