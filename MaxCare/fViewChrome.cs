using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

public class fViewChrome : Form
{
	[CompilerGenerated]
	private sealed class Class87
	{
		public IntPtr intptr_0;

		public fViewChrome fViewChrome_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int A2029F87;

		internal void method_0()
		{
            User32Helper.SetParent(intptr_0, (from Control F5116B02 in fViewChrome_0.panelListDevice.Controls
				where F5116B02.Tag.Equals(int_0)
				select F5116B02).FirstOrDefault().Handle);
            User32Helper.MoveWindow(intptr_0, int_1, int_2, int_3, A2029F87, B0AC9610: true);
		}

		internal bool DA046785(Control F5116B02)
		{
			return F5116B02.Tag.Equals(int_0);
		}
	}

	[CompilerGenerated]
	private sealed class E4187A21
	{
		public fViewChrome fViewChrome_0;

		public Control C9B20AB4;

		internal void D8020B2B()
		{
			fViewChrome_0.panelListDevice.Controls.Remove(C9B20AB4);
		}
	}

	[CompilerGenerated]
	private sealed class Class88
	{
		public fViewChrome fViewChrome_0;

		public Panel panel_0;

		internal void method_0()
		{
			fViewChrome_0.panelListDevice.Controls.Add(panel_0);
		}
	}

	[CompilerGenerated]
	private sealed class D2B6FB04
	{
		public fViewChrome FC8FA182;

		public int BEA130B1;

		internal void C68D4DA0()
		{
			FC8FA182.Text = FC8FA182.Text.Replace(Regex.Match(FC8FA182.Text, "\\((.*?)\\)").Value, "(" + BEA130B1 + ")");
		}
	}

	private fMain CF112401 = null;

	public static fViewChrome DFADBD37;

	private IContainer C7B88B1E = null;

	private FlowLayoutPanel panelListDevice;

	public fViewChrome()
	{
		InitializeComponent();
		DFADBD37 = this;
		Language.SetLanguage(this);
	}

	public fViewChrome(fMain c120353C_0)
	{
		InitializeComponent();
		DFADBD37 = this;
		CF112401 = c120353C_0;
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(this);
	}

	public void method_1(IntPtr intptr_0, int DCB6F632, int E1263B11, int int_0, int int_1 = -10, int int_2 = -30)
	{
		Invoke((MethodInvoker)delegate
		{
            User32Helper.SetParent(intptr_0, (from Control F5116B02 in panelListDevice.Controls
				where F5116B02.Tag.Equals(DCB6F632)
				select F5116B02).FirstOrDefault().Handle);
            User32Helper.MoveWindow(intptr_0, int_1, int_2, E1263B11, int_0, B0AC9610: true);
		});
		method_5();
	}

	public void method_2(int BD8D2817)
	{
		Control C9B20AB4 = panelListDevice.Controls["dv" + BD8D2817];
		panelListDevice.Invoke((MethodInvoker)delegate
		{
			panelListDevice.Controls.Remove(C9B20AB4);
		});
		method_5();
	}

	public void method_3(int int_0, int int_1, int int_2)
	{
		Panel panel_0 = new Panel();
		panel_0.Name = "dv" + int_0;
		panel_0.Tag = int_0;
		panel_0.Size = new Size(int_1, int_2);
		panel_0.BackColor = Color.White;
		panel_0.BorderStyle = BorderStyle.FixedSingle;
		Invoke((MethodInvoker)delegate
		{
			panelListDevice.Controls.Add(panel_0);
		});
		for (int i = 0; i < 10; i++)
		{
			if (panelListDevice.Controls["dv" + int_0] != null)
			{
				break;
			}
			Thread.Sleep(1000);
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		method_2(Convert.ToInt32((sender as PictureBox).Name.Replace("pic", "")));
	}

	public void method_5()
	{
		int BEA130B1 = panelListDevice.Controls.Count;
		Invoke((MethodInvoker)delegate
		{
			Text = Text.Replace(Regex.Match(Text, "\\((.*?)\\)").Value, "(" + BEA130B1 + ")");
		});
		if (CF112401 != null)
		{
			CF112401.method_163(BEA130B1);
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && C7B88B1E != null)
		{
			C7B88B1E.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fViewChrome));
		this.panelListDevice = new System.Windows.Forms.FlowLayoutPanel();
		base.SuspendLayout();
		this.panelListDevice.AutoScroll = true;
		this.panelListDevice.BackColor = System.Drawing.Color.White;
		this.panelListDevice.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panelListDevice.Location = new System.Drawing.Point(0, 0);
		this.panelListDevice.Name = "panelListDevice";
		this.panelListDevice.Padding = new System.Windows.Forms.Padding(10);
		this.panelListDevice.Size = new System.Drawing.Size(933, 554);
		this.panelListDevice.TabIndex = 1;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(933, 554);
		base.Controls.Add(this.panelListDevice);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fViewChrome";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "MaxCare - Form View Chrome (0)";
		base.ResumeLayout(false);
	}
}
