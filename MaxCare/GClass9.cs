using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GClass9 : CheckBox
{
	private Color B280C606 = Color.MediumSlateBlue;

	private Color color_0 = Color.WhiteSmoke;

	private Color color_1 = Color.Gray;

	private Color color_2 = Color.Gainsboro;

	private bool bool_0 = true;

	private IContainer B1B2A72B = null;

	public Color Color_0
	{
		get
		{
			return B280C606;
		}
		set
		{
			B280C606 = value;
			Invalidate();
		}
	}

	public Color Color_1
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			Invalidate();
		}
	}

	public Color Color_2
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			Invalidate();
		}
	}

	public Color Color_3
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
			Invalidate();
		}
	}

	[Browsable(false)]
	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
		}
	}

	[DefaultValue(true)]
	public bool F02D1894
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			Invalidate();
		}
	}

	public GClass9()
	{
		MinimumSize = new Size(45, 22);
	}

	private GraphicsPath method_0()
	{
		int num = base.Height - 1;
		Rectangle rect = new Rectangle(0, 0, num, num);
		Rectangle rect2 = new Rectangle(base.Width - num - 2, 0, num, num);
		GraphicsPath graphicsPath = new GraphicsPath();
		graphicsPath.StartFigure();
		graphicsPath.AddArc(rect, 90f, 180f);
		graphicsPath.AddArc(rect2, 270f, 180f);
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	protected override void OnPaint(PaintEventArgs AF167C1B)
	{
		int num = base.Height - 5;
		AF167C1B.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		AF167C1B.Graphics.Clear(base.Parent.BackColor);
		if (base.Checked)
		{
			if (bool_0)
			{
				AF167C1B.Graphics.FillPath(new SolidBrush(B280C606), method_0());
			}
			else
			{
				AF167C1B.Graphics.DrawPath(new Pen(B280C606, 2f), method_0());
			}
			AF167C1B.Graphics.FillEllipse(new SolidBrush(color_0), new Rectangle(base.Width - base.Height + 1, 2, num, num));
		}
		else
		{
			if (bool_0)
			{
				AF167C1B.Graphics.FillPath(new SolidBrush(color_1), method_0());
			}
			else
			{
				AF167C1B.Graphics.DrawPath(new Pen(color_1, 2f), method_0());
			}
			AF167C1B.Graphics.FillEllipse(new SolidBrush(color_2), new Rectangle(2, 2, num, num));
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && B1B2A72B != null)
		{
			B1B2A72B.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void method_1()
	{
		B1B2A72B = new Container();
	}
}
