using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fUpdateContent : Form
{
	public const int int_0 = 161;

	public const int int_1 = 2;

	private GClass0 gclass0_0 = null;

	private GClass0 gclass0_1 = null;

	private string string_0 = "";

	private string string_1 = "";

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button button2;

	private Button btnMinimize;

	private BunifuThinButton2 bunifuThinButton22;

	private BunifuThinButton2 bunifuThinButton21;

	private Label label1;

	private Label label2;

	private Label lblNewest;

	private Label lblCurrent;

	private Panel panel1;

	private RichTextBox txtContentUpdate;

	public fUpdateContent()
	{
		InitializeComponent();
		base.TopMost = true;
	}

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr intptr_0, int int_2, int int_3, int int_4);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	private void bunifuCustomLabel1_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			ReleaseCapture();
			SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void fUpdateContent_Load(object sender, EventArgs e)
	{
		gclass0_0 = new GClass0(Application.StartupPath + "\\update\\update.ini");
		string_0 = gclass0_0.method_1("Version", Class3.string_1);
		lblNewest.Text = string_0;
		gclass0_1 = new GClass0(Application.StartupPath + "\\update.ini");
		string_1 = gclass0_1.method_1("Version", Class3.string_1);
		lblCurrent.Text = string_1;
		try
		{
			string string_ = gclass0_0.method_1("Content", Class3.string_1);
			string_ = smethod_0(string_);
			txtContentUpdate.Text = string_.Replace("\n", "\r\n");
		}
		catch (Exception)
		{
		}
	}

	public static string smethod_0(string string_2)
	{
		byte[] bytes = Convert.FromBase64String(string_2);
		return Encoding.UTF8.GetString(bytes);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void bunifuThinButton22_Click(object sender, EventArgs e)
	{
		try
		{
			Directory.Delete(Application.StartupPath + "\\update", recursive: true);
		}
		catch
		{
		}
		Application.Exit();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void bunifuThinButton21_Click(object sender, EventArgs e)
	{
		DialogResult dialogResult = MessageBox.Show("Do you want to update?", "MIN Software", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
		if (dialogResult == DialogResult.Yes)
		{
			method_0(Class3.string_1);
			frm_progress frm_progress2 = new frm_progress();
			Hide();
			frm_progress2.ShowDialog();
			if (frm_progress2.bool_0)
			{
				gclass0_1.method_2("Version", string_0, Class3.string_1);
				MessageBox.Show("Update Success!", "MIN Software", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
		try
		{
			Directory.Delete(Application.StartupPath + "\\update", recursive: true);
		}
		catch
		{
		}
		Application.Exit();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.MediumSeaGreen, ButtonBorderStyle.Solid);
	}

	public void method_0(string string_2)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_2);
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch
		{
		}
	}

	private static string smethod_1(string string_2, string string_3)
	{
		string text = "";
		try
		{
			WebClient webClient = new WebClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			webClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
			text = webClient.UploadString(string_2, string_3);
			byte[] bytes = Encoding.Default.GetBytes(text);
			text = Encoding.UTF8.GetString(bytes);
			if (string.IsNullOrEmpty(text))
			{
				text = "";
			}
		}
		catch
		{
		}
		return text;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUpdateContent));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.button2 = new System.Windows.Forms.Button();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.lblNewest = new System.Windows.Forms.Label();
		this.lblCurrent = new System.Windows.Forms.Label();
		this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
		this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
		this.panel1 = new System.Windows.Forms.Panel();
		this.txtContentUpdate = new System.Windows.Forms.RichTextBox();
		this.bunifuCards1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuCards1.AutoSize = true;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.MediumSeaGreen;
		this.bunifuCards1.Controls.Add(this.button2);
		this.bunifuCards1.Controls.Add(this.btnMinimize);
		this.bunifuCards1.Controls.Add(this.pictureBox1);
		this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
		this.bunifuCards1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 1);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = false;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(404, 40);
		this.bunifuCards1.TabIndex = 0;
		this.bunifuCards1.MouseMove += new System.Windows.Forms.MouseEventHandler(bunifuCustomLabel1_MouseMove);
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
		this.button2.Location = new System.Drawing.Point(341, 5);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(30, 30);
		this.button2.TabIndex = 19;
		this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(371, 5);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(30, 30);
		this.btnMinimize.TabIndex = 18;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(6, 7);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(bunifuCustomLabel1_MouseMove);
		this.bunifuCustomLabel1.AutoSize = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(42, 14);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(191, 16);
		this.bunifuCustomLabel1.TabIndex = 13;
		this.bunifuCustomLabel1.Text = "Auto Update - MIN Software";
		this.bunifuCustomLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(bunifuCustomLabel1_MouseMove);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(10, 47);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(82, 16);
		this.label1.TabIndex = 18;
		this.label1.Text = "New version:";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(10, 70);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(100, 16);
		this.label2.TabIndex = 19;
		this.label2.Text = "Current version:";
		this.lblNewest.AutoSize = true;
		this.lblNewest.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblNewest.Location = new System.Drawing.Point(116, 49);
		this.lblNewest.Name = "lblNewest";
		this.lblNewest.Size = new System.Drawing.Size(39, 16);
		this.lblNewest.TabIndex = 20;
		this.lblNewest.Text = "3.0.1";
		this.lblCurrent.AutoSize = true;
		this.lblCurrent.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCurrent.Location = new System.Drawing.Point(116, 72);
		this.lblCurrent.Name = "lblCurrent";
		this.lblCurrent.Size = new System.Drawing.Size(39, 16);
		this.lblCurrent.TabIndex = 21;
		this.lblCurrent.Text = "2.1.0";
		this.bunifuThinButton22.ActiveBorderThickness = 1;
		this.bunifuThinButton22.ActiveCornerRadius = 10;
		this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Red;
		this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
		this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Red;
		this.bunifuThinButton22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.bunifuThinButton22.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
		this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
		this.bunifuThinButton22.BackgroundImage = (System.Drawing.Image)resources.GetObject("bunifuThinButton22.BackgroundImage");
		this.bunifuThinButton22.ButtonText = "Cancel";
		this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
		this.bunifuThinButton22.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuThinButton22.ForeColor = System.Drawing.Color.Red;
		this.bunifuThinButton22.IdleBorderThickness = 1;
		this.bunifuThinButton22.IdleCornerRadius = 10;
		this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
		this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Red;
		this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Red;
		this.bunifuThinButton22.Location = new System.Drawing.Point(208, 303);
		this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.bunifuThinButton22.Name = "bunifuThinButton22";
		this.bunifuThinButton22.Size = new System.Drawing.Size(98, 40);
		this.bunifuThinButton22.TabIndex = 16;
		this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuThinButton22.Click += new System.EventHandler(bunifuThinButton22_Click);
		this.bunifuThinButton21.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.bunifuThinButton21.ActiveBorderThickness = 1;
		this.bunifuThinButton21.ActiveCornerRadius = 10;
		this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
		this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
		this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
		this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.bunifuThinButton21.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
		this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
		this.bunifuThinButton21.BackgroundImage = (System.Drawing.Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
		this.bunifuThinButton21.ButtonText = "Update";
		this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
		this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
		this.bunifuThinButton21.IdleBorderThickness = 1;
		this.bunifuThinButton21.IdleCornerRadius = 10;
		this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
		this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
		this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
		this.bunifuThinButton21.Location = new System.Drawing.Point(87, 303);
		this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4);
		this.bunifuThinButton21.Name = "bunifuThinButton21";
		this.bunifuThinButton21.Size = new System.Drawing.Size(98, 40);
		this.bunifuThinButton21.TabIndex = 15;
		this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuThinButton21.Click += new System.EventHandler(bunifuThinButton21_Click);
		this.panel1.Controls.Add(this.lblCurrent);
		this.panel1.Controls.Add(this.lblNewest);
		this.panel1.Controls.Add(this.txtContentUpdate);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(405, 348);
		this.panel1.TabIndex = 22;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.txtContentUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtContentUpdate.Font = new System.Drawing.Font("Tahoma", 11.25f);
		this.txtContentUpdate.Location = new System.Drawing.Point(13, 91);
		this.txtContentUpdate.Name = "txtContentUpdate";
		this.txtContentUpdate.ReadOnly = true;
		this.txtContentUpdate.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
		this.txtContentUpdate.Size = new System.Drawing.Size(380, 205);
		this.txtContentUpdate.TabIndex = 1;
		this.txtContentUpdate.Text = "";
		this.txtContentUpdate.WordWrap = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(405, 348);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.bunifuThinButton22);
		base.Controls.Add(this.bunifuThinButton21);
		base.Controls.Add(this.panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "fUpdateContent";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Thông Tin Cập Nhật";
		base.Load += new System.EventHandler(fUpdateContent_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.bunifuCards1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
