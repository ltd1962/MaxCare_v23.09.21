using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhCheckPass : Form
{
	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private Button DA17E938;

	private Button F4002E8C;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCards bunifuCards1;

	private Button DC307C04;

	private PictureBox F20C3684;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel panel2;

	private RichTextBox txtPass;

	private Label lblTitle;

	public fCauHinhCheckPass()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		bool_0 = false;
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(F4002E8C);
		Language.smethod_0(DA17E938);
	}

	private void DFA58594(object sender, EventArgs e)
	{
		Close();
	}

	private void DA884A1F(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configGeneral").GetJson("txtCheckPass", txtPass.Text.Trim());
		SettingsTool.Save("configGeneral");
		bool_0 = true;
		Close();
	}

	private void A581128D(object sender, EventArgs e)
	{
		Close();
	}

	private void CE3F538B(object sender, EventArgs e)
	{
		txtPass.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtCheckPass");
		ADAAA9A6(null, null);
	}

	private void ADAAA9A6(object sender, EventArgs e)
	{
	}

	private void DD987522(object sender, EventArgs e)
	{
		Close();
	}

	private void C510BE3A(object sender, EventArgs e)
	{
		Common.F9202C12(txtPass, lblTitle);
	}

	protected override void Dispose(bool C484AC80)
	{
		if (C484AC80 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C484AC80);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		this.DA17E938 = new System.Windows.Forms.Button();
		this.F4002E8C = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.DC307C04 = new System.Windows.Forms.Button();
		this.F20C3684 = new System.Windows.Forms.PictureBox();
		this.panel2 = new System.Windows.Forms.Panel();
		this.txtPass = new System.Windows.Forms.RichTextBox();
		this.lblTitle = new System.Windows.Forms.Label();
		this.bunifuCards1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.F20C3684).BeginInit();
		this.panel2.SuspendLayout();
		base.SuspendLayout();
		this.DA17E938.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.DA17E938.BackColor = System.Drawing.Color.Maroon;
		this.DA17E938.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DA17E938.FlatAppearance.BorderSize = 0;
		this.DA17E938.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DA17E938.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DA17E938.ForeColor = System.Drawing.Color.White;
		this.DA17E938.Location = new System.Drawing.Point(172, 251);
		this.DA17E938.Name = "btnCancel";
		this.DA17E938.Size = new System.Drawing.Size(92, 29);
		this.DA17E938.TabIndex = 4;
		this.DA17E938.Text = "Đo\u0301ng";
		this.DA17E938.UseVisualStyleBackColor = false;
		this.DA17E938.Click += new System.EventHandler(A581128D);
		this.F4002E8C.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.F4002E8C.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.F4002E8C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F4002E8C.FlatAppearance.BorderSize = 0;
		this.F4002E8C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F4002E8C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F4002E8C.ForeColor = System.Drawing.Color.White;
		this.F4002E8C.Location = new System.Drawing.Point(68, 251);
		this.F4002E8C.Name = "btnAdd";
		this.F4002E8C.Size = new System.Drawing.Size(92, 29);
		this.F4002E8C.TabIndex = 3;
		this.F4002E8C.Text = "Lưu";
		this.F4002E8C.UseVisualStyleBackColor = false;
		this.F4002E8C.Click += new System.EventHandler(DA884A1F);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(330, 38);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Check Pass";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.DC307C04);
		this.bunifuCards1.Controls.Add(this.F20C3684);
		this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(330, 38);
		this.bunifuCards1.TabIndex = 29;
		this.DC307C04.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.DC307C04.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DC307C04.FlatAppearance.BorderSize = 0;
		this.DC307C04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DC307C04.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DC307C04.ForeColor = System.Drawing.Color.White;
		this.DC307C04.Image = Resources.A13F2207;
		this.DC307C04.Location = new System.Drawing.Point(298, 5);
		this.DC307C04.Name = "btnClose";
		this.DC307C04.Size = new System.Drawing.Size(30, 30);
		this.DC307C04.TabIndex = 77;
		this.DC307C04.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.DC307C04.UseVisualStyleBackColor = true;
		this.DC307C04.Click += new System.EventHandler(DD987522);
		this.F20C3684.Cursor = System.Windows.Forms.Cursors.Default;
		this.F20C3684.Image = Resources.Bitmap_4;
		this.F20C3684.Location = new System.Drawing.Point(2, 6);
		this.F20C3684.Name = "pictureBox1";
		this.F20C3684.Size = new System.Drawing.Size(34, 27);
		this.F20C3684.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.F20C3684.TabIndex = 76;
		this.F20C3684.TabStop = false;
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.txtPass);
		this.panel2.Controls.Add(this.lblTitle);
		this.panel2.Controls.Add(this.bunifuCards1);
		this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel2.Location = new System.Drawing.Point(0, 0);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(332, 292);
		this.panel2.TabIndex = 30;
		this.txtPass.Location = new System.Drawing.Point(34, 69);
		this.txtPass.Name = "txtPass";
		this.txtPass.Size = new System.Drawing.Size(267, 170);
		this.txtPass.TabIndex = 31;
		this.txtPass.Text = "";
		this.txtPass.WordWrap = false;
		this.txtPass.TextChanged += new System.EventHandler(C510BE3A);
		this.lblTitle.AutoSize = true;
		this.lblTitle.Location = new System.Drawing.Point(31, 50);
		this.lblTitle.Name = "lblTitle";
		this.lblTitle.Size = new System.Drawing.Size(122, 16);
		this.lblTitle.TabIndex = 30;
		this.lblTitle.Text = "Danh sách pass (0):";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(332, 292);
		base.Controls.Add(this.DA17E938);
		base.Controls.Add(this.F4002E8C);
		base.Controls.Add(this.panel2);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhCheckPass";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(CE3F538B);
		this.bunifuCards1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.F20C3684).EndInit();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		base.ResumeLayout(false);
	}
}
