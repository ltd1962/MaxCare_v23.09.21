using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fConfirmPassword : Form
{
	public string D23EFABA = "";

	private IContainer CA15C136 = null;

	private BunifuCards CC068505;

	private Panel BB87A781;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button DAA5D087;

	private Button btnCancel;

	private Button B495D9BC;

	private Label CA360AB7;

	private BunifuDragControl DDA2DF03;

	private TextBox B2008138;

	public fConfirmPassword()
	{
		InitializeComponent();
		method_0();
	}

	private void DAA5D087_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(CA360AB7);
		Language.smethod_0(B495D9BC);
		Language.smethod_0(btnCancel);
	}

	private void FEA8919A(object sender, EventArgs e)
	{
		D23EFABA = B2008138.Text.Trim();
		if (D23EFABA == "")
		{
			MessageBoxHelper.Show("Mật khẩu không được để trống!", 3);
		}
		else
		{
			Close();
		}
	}

	private void B98706B3(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && CA15C136 != null)
		{
			CA15C136.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.CA15C136 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConfirmPassword));
		this.CC068505 = new Bunifu.Framework.UI.BunifuCards();
		this.BB87A781 = new System.Windows.Forms.Panel();
		this.DAA5D087 = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.B495D9BC = new System.Windows.Forms.Button();
		this.CA360AB7 = new System.Windows.Forms.Label();
		this.DDA2DF03 = new Bunifu.Framework.UI.BunifuDragControl(this.CA15C136);
		this.B2008138 = new System.Windows.Forms.TextBox();
		this.CC068505.SuspendLayout();
		this.BB87A781.SuspendLayout();
		base.SuspendLayout();
		this.CC068505.BackColor = System.Drawing.Color.White;
		this.CC068505.BorderRadius = 0;
		this.CC068505.BottomSahddow = true;
		this.CC068505.color = System.Drawing.Color.SaddleBrown;
		this.CC068505.Controls.Add(this.BB87A781);
		this.CC068505.Dock = System.Windows.Forms.DockStyle.Top;
		this.CC068505.LeftSahddow = false;
		this.CC068505.Location = new System.Drawing.Point(0, 0);
		this.CC068505.Name = "bunifuCards1";
		this.CC068505.RightSahddow = true;
		this.CC068505.ShadowDepth = 20;
		this.CC068505.Size = new System.Drawing.Size(353, 38);
		this.CC068505.TabIndex = 0;
		this.BB87A781.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.BB87A781.BackColor = System.Drawing.Color.White;
		this.BB87A781.Controls.Add(this.DAA5D087);
		this.BB87A781.Controls.Add(this.bunifuCustomLabel1);
		this.BB87A781.Location = new System.Drawing.Point(0, 5);
		this.BB87A781.Name = "pnlHeader";
		this.BB87A781.Size = new System.Drawing.Size(353, 32);
		this.BB87A781.TabIndex = 9;
		this.DAA5D087.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DAA5D087.Dock = System.Windows.Forms.DockStyle.Right;
		this.DAA5D087.FlatAppearance.BorderSize = 0;
		this.DAA5D087.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DAA5D087.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DAA5D087.ForeColor = System.Drawing.Color.White;
		this.DAA5D087.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.DAA5D087.Location = new System.Drawing.Point(321, 0);
		this.DAA5D087.Name = "btnMinimize";
		this.DAA5D087.Size = new System.Drawing.Size(32, 32);
		this.DAA5D087.TabIndex = 9;
		this.DAA5D087.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.DAA5D087.UseVisualStyleBackColor = true;
		this.DAA5D087.Click += new System.EventHandler(DAA5D087_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(353, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Vui lòng nhập mật khẩu!";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(183, 104);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(B98706B3);
		this.B495D9BC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.B495D9BC.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.B495D9BC.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B495D9BC.FlatAppearance.BorderSize = 0;
		this.B495D9BC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B495D9BC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B495D9BC.ForeColor = System.Drawing.Color.White;
		this.B495D9BC.Location = new System.Drawing.Point(75, 104);
		this.B495D9BC.Name = "btnAdd";
		this.B495D9BC.Size = new System.Drawing.Size(92, 29);
		this.B495D9BC.TabIndex = 3;
		this.B495D9BC.Text = "Xa\u0301c nhâ\u0323n";
		this.B495D9BC.UseVisualStyleBackColor = false;
		this.B495D9BC.Click += new System.EventHandler(FEA8919A);
		this.CA360AB7.AutoSize = true;
		this.CA360AB7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.CA360AB7.Location = new System.Drawing.Point(20, 66);
		this.CA360AB7.Name = "label1";
		this.CA360AB7.Size = new System.Drawing.Size(98, 16);
		this.CA360AB7.TabIndex = 20;
		this.CA360AB7.Text = "Nhập mật khẩu:";
		this.DDA2DF03.Fixed = true;
		this.DDA2DF03.Horizontal = true;
		this.DDA2DF03.TargetControl = this.bunifuCustomLabel1;
		this.DDA2DF03.Vertical = true;
		this.B2008138.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B2008138.Location = new System.Drawing.Point(120, 63);
		this.B2008138.Name = "txtPassword";
		this.B2008138.Size = new System.Drawing.Size(208, 23);
		this.B2008138.TabIndex = 21;
		this.B2008138.UseSystemPasswordChar = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(353, 145);
		base.Controls.Add(this.B2008138);
		base.Controls.Add(this.CA360AB7);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.B495D9BC);
		base.Controls.Add(this.CC068505);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fConfirmPassword";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "`";
		this.CC068505.ResumeLayout(false);
		this.BB87A781.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
