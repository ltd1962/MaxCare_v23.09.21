using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhDebug : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel B60BE125;

	private Button btnMinimize;

	private Button A90B6490;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private CheckBox ckbUseScriptFile;

	private TextBox FBA44D02;

	private Panel plFilePath;

	private Label label21;

	private CheckBox ckbModeDev;

	public fCauHinhDebug()
	{
		BAB5C926();
		Language.SetLanguage(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configDebug").GetJson("ckbModeDev", ckbModeDev.Checked);
		SettingsTool.GetSettings("configDebug").GetJson("ckbUseScriptFile", ckbUseScriptFile.Checked);
		SettingsTool.GetSettings("configDebug").GetJson("txtFilePath", FBA44D02.Text);
		SettingsTool.Save("configDebug");
		if (MessageBoxHelper.ShowMessages("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
		{
			Close();
		}
	}

	private void A90B6490_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A69D23B1(object sender, EventArgs e)
	{
	}

	private void D81B558D(object sender, EventArgs e)
	{
		ckbModeDev.Checked = SettingsTool.GetSettings("configDebug").GetValueBool("ckbModeDev");
		ckbUseScriptFile.Checked = SettingsTool.GetSettings("configDebug").GetValueBool("ckbUseScriptFile");
		FBA44D02.Text = SettingsTool.GetSettings("configDebug").GetValue("txtFilePath");
		ckbUseScriptFile_CheckedChanged(null, null);
	}

	private void ckbUseScriptFile_CheckedChanged(object sender, EventArgs e)
	{
		plFilePath.Enabled = ckbUseScriptFile.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void BAB5C926()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fCauHinhDebug));
		bunifuCards1 = new BunifuCards();
		pnlHeader = new Panel();
		pictureBox1 = new PictureBox();
		btnMinimize = new Button();
		B60BE125 = new BunifuCustomLabel();
		A90B6490 = new Button();
		btnAdd = new Button();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		ckbUseScriptFile = new CheckBox();
		FBA44D02 = new TextBox();
		plFilePath = new Panel();
		label21 = new Label();
		ckbModeDev = new CheckBox();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		plFilePath.SuspendLayout();
		SuspendLayout();
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(445, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(B60BE125);
		pnlHeader.Location = new Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(445, 32);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.Dock = DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		btnMinimize.Location = new Point(413, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += btnMinimize_Click;
		B60BE125.BackColor = Color.Transparent;
		B60BE125.Cursor = Cursors.SizeAll;
		B60BE125.Dock = DockStyle.Fill;
		B60BE125.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B60BE125.ForeColor = Color.Black;
		B60BE125.Location = new Point(0, 0);
		B60BE125.Name = "bunifuCustomLabel1";
		B60BE125.Size = new Size(445, 32);
		B60BE125.TabIndex = 1;
		B60BE125.Text = "Câ\u0301u hi\u0300nh Debug";
		B60BE125.TextAlign = ContentAlignment.MiddleCenter;
		A90B6490.Anchor = AnchorStyles.Bottom;
		A90B6490.BackColor = Color.Maroon;
		A90B6490.Cursor = Cursors.Hand;
		A90B6490.FlatAppearance.BorderSize = 0;
		A90B6490.FlatStyle = FlatStyle.Flat;
		A90B6490.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A90B6490.ForeColor = Color.White;
		A90B6490.Location = new Point(230, 188);
		A90B6490.Name = "btnCancel";
		A90B6490.Size = new Size(92, 29);
		A90B6490.TabIndex = 4;
		A90B6490.Text = "Đo\u0301ng";
		A90B6490.UseVisualStyleBackColor = false;
		A90B6490.Click += A90B6490_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(126, 188);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = B60BE125;
		bunifuDragControl_0.Vertical = true;
		ckbUseScriptFile.AutoSize = true;
		ckbUseScriptFile.Cursor = Cursors.Hand;
		ckbUseScriptFile.Location = new Point(50, 84);
		ckbUseScriptFile.Name = "ckbUseScriptFile";
		ckbUseScriptFile.Size = new Size(130, 20);
		ckbUseScriptFile.TabIndex = 5;
		ckbUseScriptFile.Text = "Sử dụng file script";
		ckbUseScriptFile.UseVisualStyleBackColor = true;
		ckbUseScriptFile.CheckedChanged += ckbUseScriptFile_CheckedChanged;
		FBA44D02.Location = new Point(67, 1);
		FBA44D02.Name = "txtFilePath";
		FBA44D02.Size = new Size(240, 23);
		FBA44D02.TabIndex = 6;
		plFilePath.BorderStyle = BorderStyle.FixedSingle;
		plFilePath.Controls.Add(label21);
		plFilePath.Controls.Add(FBA44D02);
		plFilePath.Location = new Point(70, 106);
		plFilePath.Name = "plFilePath";
		plFilePath.Size = new Size(310, 27);
		plFilePath.TabIndex = 8;
		label21.AutoSize = true;
		label21.Location = new Point(3, 3);
		label21.Name = "label21";
		label21.Size = new Size(61, 16);
		label21.TabIndex = 49;
		label21.Text = "File path:";
		ckbModeDev.AutoSize = true;
		ckbModeDev.Cursor = Cursors.Hand;
		ckbModeDev.Location = new Point(50, 58);
		ckbModeDev.Name = "ckbModeDev";
		ckbModeDev.Size = new Size(110, 20);
		ckbModeDev.TabIndex = 5;
		ckbModeDev.Text = "Bật chế độ dev";
		ckbModeDev.UseVisualStyleBackColor = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(445, 230);
		base.Controls.Add(plFilePath);
		base.Controls.Add(ckbModeDev);
		base.Controls.Add(ckbUseScriptFile);
		base.Controls.Add(A90B6490);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fCauHinhDebug";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += D81B558D;
		bunifuCards1.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		plFilePath.ResumeLayout(performLayout: false);
		plFilePath.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
