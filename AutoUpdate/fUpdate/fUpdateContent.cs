using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using update;
using WindowsFormsControlLibrary1;

namespace fUpdate;

public class fUpdateContent : Form
{
	public const int WM_NCLBUTTONDOWN = 161;

	public const int HT_CAPTION = 2;

	private IniFile ini_server = null;

	private IniFile ini_local = null;

	private string new_version = "";

	private string old_version = "";

	private IContainer components = null;

	private BunifuCards bunifuCards1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button button2;

	private Button btnMinimize;

	private BunifuCustomTextbox txtContentUpdate;

	private BunifuThinButton2 bunifuThinButton22;

	private BunifuThinButton2 bunifuThinButton21;

	private Label label1;

	private Label label2;

	private Label lblNewest;

	private Label lblCurrent;

	private Panel panel1;

	public fUpdateContent()
	{
		InitializeComponent();
	}

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	private void panel2_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			ReleaseCapture();
			SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void fUpdateContent_Load(object sender, EventArgs e)
	{
		ini_server = new IniFile("./update/update.ini");
		new_version = ini_server.Read("Version", Tool.softname);
		lblNewest.Text = new_version;
		ini_local = new IniFile("update.ini");
		old_version = ini_local.Read("Version", Tool.softname);
		lblCurrent.Text = old_version;
		try
		{
			string base64EncodedData = ini_server.Read("Content", Tool.softname);
			base64EncodedData = Base64Decode(base64EncodedData);
			txtContentUpdate.Text = base64EncodedData.Replace("\n", "\r\n");
		}
		catch
		{
		}
	}

	public static string Base64Decode(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void bunifuThinButton22_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void bunifuThinButton21_Click(object sender, EventArgs e)
	{
		DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật?", "LTDSoftware", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
		if (dialogResult == DialogResult.Yes)
		{
			frm_progress frm_progress2 = new frm_progress();
			Hide();
			frm_progress2.ShowDialog();
			File.Delete("./update/update.ini");
			ini_local.Write("Version", new_version, Tool.softname);
            //ini_local.Write("Content", lblNewest, fUpdate.softname);
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.MediumSeaGreen, ButtonBorderStyle.Solid);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
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
            this.txtContentUpdate = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNewest = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
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
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(539, 49);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(455, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 37);
            this.button2.TabIndex = 19;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(495, 6);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 37);
            this.btnMinimize.TabIndex = 18;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(61, 17);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(182, 21);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Cập Nhật Phần Mềm";
            this.bunifuCustomLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // txtContentUpdate
            // 
            this.txtContentUpdate.BackColor = System.Drawing.Color.White;
            this.txtContentUpdate.BorderColor = System.Drawing.Color.Black;
            this.txtContentUpdate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtContentUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtContentUpdate.Location = new System.Drawing.Point(17, 112);
            this.txtContentUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtContentUpdate.Multiline = true;
            this.txtContentUpdate.Name = "txtContentUpdate";
            this.txtContentUpdate.ReadOnly = true;
            this.txtContentUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContentUpdate.Size = new System.Drawing.Size(505, 206);
            this.txtContentUpdate.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Phiên bản mới nhất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Phiên bản hiện tại:";
            // 
            // lblNewest
            // 
            this.lblNewest.AutoSize = true;
            this.lblNewest.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewest.Location = new System.Drawing.Point(177, 58);
            this.lblNewest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewest.Name = "lblNewest";
            this.lblNewest.Size = new System.Drawing.Size(53, 21);
            this.lblNewest.TabIndex = 20;
            this.lblNewest.Text = "3.0.1";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(177, 86);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(53, 21);
            this.lblCurrent.TabIndex = 21;
            this.lblCurrent.Text = "2.1.0";
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 10;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Hủy";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 10;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Red;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.Location = new System.Drawing.Point(277, 320);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(131, 49);
            this.bunifuThinButton22.TabIndex = 16;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 10;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Cập Nhật";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 10;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(116, 320);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(131, 49);
            this.bunifuThinButton21.TabIndex = 15;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 375);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // fUpdateContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 375);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblNewest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContentUpdate);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fUpdateContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Cập Nhật";
            this.Load += new System.EventHandler(this.fUpdateContent_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

	}
}
