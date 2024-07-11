using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

public class fAutoChrome : Form
{
	[CompilerGenerated]
	private sealed class Class67
	{
		public fAutoChrome ac82D5AF_0;

		public string string_0;

		public MethodInvoker methodInvoker_0;

		internal void AE877104()
		{
			try
			{
				C8A91290 CS_0024_003C_003E8__locals0 = new C8A91290
				{
					DD267333 = this
				};
				ac82D5AF_0.txtResult.Invoke((MethodInvoker)delegate
				{
					ac82D5AF_0.txtResult.Text = "Running...";
				});
				CS_0024_003C_003E8__locals0.string_0 = new Chrome
				{
					Int32_3 = ac82D5AF_0.int_0,
					String_7 = ac82D5AF_0.string_0
				}.RunCode(string_0);
				ac82D5AF_0.txtResult.Invoke((MethodInvoker)delegate
				{
					CS_0024_003C_003E8__locals0.DD267333.ac82D5AF_0.txtResult.Text = CS_0024_003C_003E8__locals0.string_0;
				});
			}
			catch (Exception)
			{
			}
		}

		internal void CD93AB9A()
		{
			ac82D5AF_0.txtResult.Text = "Running...";
		}
	}

	[CompilerGenerated]
	private sealed class C8A91290
	{
		public string string_0;

		public Class67 DD267333;

		internal void method_0()
		{
			DD267333.ac82D5AF_0.txtResult.Text = string_0;
		}
	}

	private int int_0;

	private string string_0;

	private IContainer E61D3C0D = null;

	private RichTextBox C31F6CAB;

	private Button C6A198B6;

	private RichTextBox txtResult;

	private PictureBox AE9CC19C;

	private Button D012481F;

	public fAutoChrome(int A20DA336, string string_1)
	{
		InitializeComponent();
		int_0 = A20DA336;
		string_0 = string_1;
	}

	private void A52AB62F(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configGeneral").GetJson("txtCode", C31F6CAB.Text);
		SettingsTool.GetSettings("configGeneral").method_7();
		string string_0 = C31F6CAB.SelectedText.Trim();
		if (string_0 == "")
		{
			string_0 = C31F6CAB.Text.Trim();
		}
		if (File.Exists(string_0))
		{
			string_0 = File.ReadAllText(string_0).Trim();
			if (string_0.Contains("#region"))
			{
				string_0 = Regex.Match(string_0, "\\/\\/\\#region(.*?)\\/\\/\\#endregion", RegexOptions.Singleline).Groups[1].Value.Trim();
			}
		}
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		txtResult.Text = "";
		Application.DoEvents();
		new Thread((ThreadStart)delegate
		{
			try
			{
				txtResult.Invoke((MethodInvoker)delegate
				{
					txtResult.Text = "Running...";
				});
				string string_ = new Chrome
				{
					Int32_3 = int_0,
					String_7 = this.string_0
				}.RunCode(string_0);
				txtResult.Invoke((MethodInvoker)delegate
				{
					txtResult.Text = string_;
				});
			}
			catch (Exception)
			{
			}
		}).Start();
	}

	private void C43588A9(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.F5)
		{
			A52AB62F(null, null);
		}
	}

	private void E58F773A(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.F5)
		{
			A52AB62F(null, null);
		}
	}

	private void AC17DBA4(object sender, EventArgs e)
	{
		C31F6CAB.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtCode");
	}

	private void D012481F_Click(object sender, EventArgs e)
	{
		new Thread((ThreadStart)delegate
		{
			string text = new Chrome
			{
				Int32_3 = int_0,
				String_7 = string_0
			}.RunCode("ScreenshotToBase64()");
			if (!(text == ""))
			{
				byte[] buffer = Convert.FromBase64String(text);
				using MemoryStream stream = new MemoryStream(buffer);
				AE9CC19C.Image = Image.FromStream(stream);
			}
		}).Start();
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && E61D3C0D != null)
		{
			E61D3C0D.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fAutoChrome));
		C31F6CAB = new RichTextBox();
		C6A198B6 = new Button();
		txtResult = new RichTextBox();
		AE9CC19C = new PictureBox();
		D012481F = new Button();
		((ISupportInitialize)AE9CC19C).BeginInit();
		SuspendLayout();
		C31F6CAB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		C31F6CAB.Location = new Point(13, 13);
		C31F6CAB.Name = "txtCode";
		C31F6CAB.Size = new Size(398, 27);
		C31F6CAB.TabIndex = 0;
		C31F6CAB.Text = "";
		C31F6CAB.WordWrap = false;
		C31F6CAB.KeyDown += C43588A9;
		C6A198B6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		C6A198B6.Location = new Point(263, 46);
		C6A198B6.Name = "btnRun";
		C6A198B6.Size = new Size(148, 35);
		C6A198B6.TabIndex = 1;
		C6A198B6.Text = "Run (F5)";
		C6A198B6.UseVisualStyleBackColor = true;
		C6A198B6.Click += A52AB62F;
		txtResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		txtResult.Location = new Point(263, 87);
		txtResult.Name = "txtResult";
		txtResult.Size = new Size(148, 260);
		txtResult.TabIndex = 0;
		txtResult.Text = "";
		txtResult.WordWrap = false;
		AE9CC19C.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		AE9CC19C.BorderStyle = BorderStyle.FixedSingle;
		AE9CC19C.Location = new Point(13, 46);
		AE9CC19C.Name = "pictureBox1";
		AE9CC19C.Size = new Size(244, 260);
		AE9CC19C.SizeMode = PictureBoxSizeMode.Zoom;
		AE9CC19C.TabIndex = 2;
		AE9CC19C.TabStop = false;
		D012481F.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		D012481F.Location = new Point(12, 312);
		D012481F.Name = "button1";
		D012481F.Size = new Size(245, 35);
		D012481F.TabIndex = 1;
		D012481F.Text = "Capture";
		D012481F.UseVisualStyleBackColor = true;
		D012481F.Click += D012481F_Click;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.White;
		base.ClientSize = new Size(424, 357);
		base.Controls.Add(AE9CC19C);
		base.Controls.Add(D012481F);
		base.Controls.Add(C6A198B6);
		base.Controls.Add(txtResult);
		base.Controls.Add(C31F6CAB);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Margin = new Padding(4);
		base.Name = "fAutoChrome";
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Auto Chrome";
		base.Load += AC17DBA4;
		base.KeyDown += E58F773A;
		((ISupportInitialize)AE9CC19C).EndInit();
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void method_0()
	{
		string text = new Chrome
		{
			Int32_3 = int_0,
			String_7 = string_0
		}.RunCode("ScreenshotToBase64()");
		if (!(text == ""))
		{
			byte[] buffer = Convert.FromBase64String(text);
			using MemoryStream stream = new MemoryStream(buffer);
			AE9CC19C.Image = Image.FromStream(stream);
		}
	}
}
