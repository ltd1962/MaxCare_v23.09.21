using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public class fShowProgressBar : Form
{
	[CompilerGenerated]
	private sealed class Class89
	{
		public int int_0;

		public int int_1;

		public fShowProgressBar C4219B82;

		internal void method_0()
		{
			C4219B82.lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), int_0, int_1);
		}
	}

	[CompilerGenerated]
	private sealed class BD88E51F
	{
		public double double_0;

		public Class89 class89_0;

		internal void D2278597()
		{
			class89_0.C4219B82.lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), class89_0.int_0, class89_0.int_1);
			class89_0.C4219B82.F239E4A2.Value = int.Parse(Math.Truncate(double_0).ToString());
		}
	}

	private List<string> list_0 = new List<string>();

	private IContainer icontainer_0 = null;

	private Label lblproccess;

	private ProgressBar F239E4A2;

	public fShowProgressBar(List<string> list_1)
	{
		BF3ABF3E();
		Language.SetLanguage(this);
		list_0 = list_1;
	}

	private void EC8B0AB1()
	{
		Language.smethod_0(lblproccess);
	}

	private void D8AB2520(object sender, EventArgs e)
	{
		try
		{
			new Thread((ThreadStart)delegate
			{
				string text = "";
				string text2 = "";
				int int_0 = 0;
				int int_1 = list_0.Count;
				BeginInvoke((MethodInvoker)delegate
				{
					lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), int_0, int_1);
				});
				for (int i = 0; i < list_0.Count; i++)
				{
					text = list_0[i].Split('|')[0];
					text2 = list_0[i].Split('|')[1];
					if (FileHelper.smethod_2(text, text2, DA22B515: true))
					{
						int num = int_0;
						int_0 = num + 1;
					}
					double double_0 = (double)int_0 * 1.0 / (double)int_1 * 100.0;
					BeginInvoke((MethodInvoker)delegate
					{
						lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), int_0, int_1);
						F239E4A2.Value = int.Parse(Math.Truncate(double_0).ToString());
					});
				}
				BeginInvoke((MethodInvoker)delegate
				{
					Close();
				});
			}).Start();
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show("Error: " + ex.Message, 2);
			Close();
		}
	}

	protected override void Dispose(bool AF2944A3)
	{
		if (AF2944A3 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(AF2944A3);
	}

	private void BF3ABF3E()
	{
		lblproccess = new Label();
		F239E4A2 = new ProgressBar();
		SuspendLayout();
		lblproccess.AutoSize = true;
		lblproccess.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblproccess.Location = new Point(34, 22);
		lblproccess.Name = "lblproccess";
		lblproccess.Size = new Size(189, 16);
		lblproccess.TabIndex = 1;
		lblproccess.Text = "Đang copy, vui lo\u0300ng chơ\u0300 (0/0)...";
		F239E4A2.Location = new Point(37, 52);
		F239E4A2.Name = "progressBar1";
		F239E4A2.Size = new Size(219, 23);
		F239E4A2.TabIndex = 2;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		BackColor = Color.FromArgb(224, 224, 224);
		base.ClientSize = new Size(294, 104);
		base.Controls.Add(F239E4A2);
		base.Controls.Add(lblproccess);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fShowProgressBar";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "frm_progress";
		base.Load += D8AB2520;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void method_0()
	{
		string text = "";
		string text2 = "";
		int int_0 = 0;
		int int_1 = list_0.Count;
		BeginInvoke((MethodInvoker)delegate
		{
			lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), int_0, int_1);
		});
		for (int i = 0; i < list_0.Count; i++)
		{
			text = list_0[i].Split('|')[0];
			text2 = list_0[i].Split('|')[1];
			if (FileHelper.smethod_2(text, text2, DA22B515: true))
			{
				int num = int_0;
				int_0 = num + 1;
			}
			double double_0 = (double)int_0 * 1.0 / (double)int_1 * 100.0;
			BeginInvoke((MethodInvoker)delegate
			{
				lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), int_0, int_1);
				F239E4A2.Value = int.Parse(Math.Truncate(double_0).ToString());
			});
		}
		BeginInvoke((MethodInvoker)delegate
		{
			Close();
		});
	}

	[CompilerGenerated]
	private void method_1()
	{
		Close();
	}
}
