using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDThamGiaNhomTuKhoa : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int F18EA122;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl B1B72FAB;

	private BunifuDragControl FDAEB700;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox A58884BA;

	private Label D0A45336;

	private Label E1819CA7;

	private Label A518B014;

	private Label label1;

	private Button FFBC4FB2;

	private Button DE37E19E;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button C81D3485;

	private PictureBox pictureBox1;

	private BunifuCustomLabel D9895E3E;

	private Label lblTuKhoa;

	private NumericUpDown nudDelayTo;

	private NumericUpDown DF210B39;

	private Label DFBD9F11;

	private Label label6;

	private Label label5;

	private RichTextBox txtTuKhoa;

	private ToolTip A7B51B10;

	private Panel plTuongTac;

	private CheckBox DA8FC932;

	private Label lblCauTraLoi;

	private RichTextBox txtCauTraLoi;

	private Panel plGroupId;

	private RichTextBox txtGroupId;

	private Label F70CEBBB;

	private CheckBox ckbGroupId;

	public fHDThamGiaNhomTuKhoa(string string_3, int FA03E3BF = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		F18EA122 = FA03E3BF;
		string text = "";
		switch (FA03E3BF)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDThamGiaNhomTuKhoa");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A58884BA.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_4);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			DE37E19E.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			A58884BA.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void B096B18B_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 3);
			DF210B39.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			txtTuKhoa.Text = gclass8_0.GetValue("txtTuKhoa");
			DA8FC932.Checked = gclass8_0.GetValueBool("ckbTuDongTraLoiCauHoi");
			txtCauTraLoi.Text = gclass8_0.GetValue("txtCauTraLoi");
			ckbGroupId.Checked = gclass8_0.GetValueBool("ckbGroupId");
			txtGroupId.Text = gclass8_0.GetValue("txtGroupId");
		}
		catch
		{
		}
		C4841036();
	}

	private void C4841036()
	{
		DA8FC932_CheckedChanged(null, null);
		ckbGroupId_CheckedChanged(null, null);
	}

	private void F6A7C138(object sender, EventArgs e)
	{
		Close();
	}

	private void DE37E19E_Click(object sender, EventArgs e)
	{
		string text = A58884BA.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtTuKhoa.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách từ khóa!", 3);
			return;
		}
		if (DA8FC932.Checked)
		{
			a2AB53A = txtCauTraLoi.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách câu trả lời!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", DF210B39.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("txtTuKhoa", txtTuKhoa.Text.Trim());
		gClass.GetJson("ckbTuDongTraLoiCauHoi", DA8FC932.Checked);
		gClass.GetJson("txtCauTraLoi", txtCauTraLoi.Text.Trim());
		gClass.GetJson("ckbGroupId", ckbGroupId.Checked);
		gClass.GetJson("txtGroupId", txtGroupId.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (F18EA122 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(string_2, text, string_))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void FFBC4FB2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FE20429C(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void txtTuKhoa_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(sender as RichTextBox, lblTuKhoa);
	}

	private void DA8FC932_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTac.Enabled = DA8FC932.Checked;
	}

	private void C5009311(object sender, EventArgs e)
	{
		Common.F9202C12(sender as RichTextBox, lblCauTraLoi);
	}

	private void txtGroupId_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(sender as RichTextBox, F70CEBBB);
	}

	private void ckbGroupId_CheckedChanged(object sender, EventArgs e)
	{
		plGroupId.Enabled = ckbGroupId.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDThamGiaNhomTuKhoa));
		this.B1B72FAB = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.D9895E3E = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.FDAEB700 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.C81D3485 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plGroupId = new System.Windows.Forms.Panel();
		this.txtGroupId = new System.Windows.Forms.RichTextBox();
		this.F70CEBBB = new System.Windows.Forms.Label();
		this.plTuongTac = new System.Windows.Forms.Panel();
		this.txtCauTraLoi = new System.Windows.Forms.RichTextBox();
		this.lblCauTraLoi = new System.Windows.Forms.Label();
		this.ckbGroupId = new System.Windows.Forms.CheckBox();
		this.DA8FC932 = new System.Windows.Forms.CheckBox();
		this.txtTuKhoa = new System.Windows.Forms.RichTextBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.lblTuKhoa = new System.Windows.Forms.Label();
		this.DF210B39 = new System.Windows.Forms.NumericUpDown();
		this.DFBD9F11 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.A58884BA = new System.Windows.Forms.TextBox();
		this.D0A45336 = new System.Windows.Forms.Label();
		this.E1819CA7 = new System.Windows.Forms.Label();
		this.A518B014 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.FFBC4FB2 = new System.Windows.Forms.Button();
		this.DE37E19E = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.A7B51B10 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plGroupId.SuspendLayout();
		this.plTuongTac.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DF210B39).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.B1B72FAB.Fixed = true;
		this.B1B72FAB.Horizontal = true;
		this.B1B72FAB.TargetControl = this.D9895E3E;
		this.B1B72FAB.Vertical = true;
		this.D9895E3E.BackColor = System.Drawing.Color.Transparent;
		this.D9895E3E.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.D9895E3E.Dock = System.Windows.Forms.DockStyle.Fill;
		this.D9895E3E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D9895E3E.ForeColor = System.Drawing.Color.Black;
		this.D9895E3E.Location = new System.Drawing.Point(0, 0);
		this.D9895E3E.Name = "bunifuCustomLabel1";
		this.D9895E3E.Size = new System.Drawing.Size(674, 31);
		this.D9895E3E.TabIndex = 12;
		this.D9895E3E.Text = "Cấu hình Tham gia nhóm theo từ khóa";
		this.D9895E3E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.FDAEB700.Fixed = true;
		this.FDAEB700.Horizontal = true;
		this.FDAEB700.TargetControl = this.pnlHeader;
		this.FDAEB700.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.C81D3485);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.D9895E3E);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(674, 31);
		this.pnlHeader.TabIndex = 9;
		this.C81D3485.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.C81D3485.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C81D3485.FlatAppearance.BorderSize = 0;
		this.C81D3485.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C81D3485.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C81D3485.ForeColor = System.Drawing.Color.White;
		this.C81D3485.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.C81D3485.Location = new System.Drawing.Point(643, 1);
		this.C81D3485.Name = "button1";
		this.C81D3485.Size = new System.Drawing.Size(30, 30);
		this.C81D3485.TabIndex = 77;
		this.C81D3485.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.C81D3485.UseVisualStyleBackColor = true;
		this.C81D3485.Click += new System.EventHandler(F6A7C138);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.plGroupId);
		this.panel1.Controls.Add(this.plTuongTac);
		this.panel1.Controls.Add(this.ckbGroupId);
		this.panel1.Controls.Add(this.DA8FC932);
		this.panel1.Controls.Add(this.txtTuKhoa);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.lblTuKhoa);
		this.panel1.Controls.Add(this.DF210B39);
		this.panel1.Controls.Add(this.DFBD9F11);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.A58884BA);
		this.panel1.Controls.Add(this.D0A45336);
		this.panel1.Controls.Add(this.E1819CA7);
		this.panel1.Controls.Add(this.A518B014);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.FFBC4FB2);
		this.panel1.Controls.Add(this.DE37E19E);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(677, 532);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(FE20429C);
		this.plGroupId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plGroupId.Controls.Add(this.txtGroupId);
		this.plGroupId.Controls.Add(this.F70CEBBB);
		this.plGroupId.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plGroupId.Location = new System.Drawing.Point(365, 159);
		this.plGroupId.Name = "plGroupId";
		this.plGroupId.Size = new System.Drawing.Size(278, 306);
		this.plGroupId.TabIndex = 116;
		this.txtGroupId.Location = new System.Drawing.Point(6, 23);
		this.txtGroupId.Name = "txtGroupId";
		this.txtGroupId.Size = new System.Drawing.Size(266, 278);
		this.txtGroupId.TabIndex = 117;
		this.txtGroupId.Text = "";
		this.txtGroupId.WordWrap = false;
		this.txtGroupId.TextChanged += new System.EventHandler(txtGroupId_TextChanged);
		this.F70CEBBB.AutoSize = true;
		this.F70CEBBB.Location = new System.Drawing.Point(3, 4);
		this.F70CEBBB.Name = "lblGroupId";
		this.F70CEBBB.Size = new System.Drawing.Size(143, 16);
		this.F70CEBBB.TabIndex = 0;
		this.F70CEBBB.Text = "Danh sách Id nhóm (0):";
		this.plTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTac.Controls.Add(this.txtCauTraLoi);
		this.plTuongTac.Controls.Add(this.lblCauTraLoi);
		this.plTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTac.Location = new System.Drawing.Point(48, 324);
		this.plTuongTac.Name = "plTuongTac";
		this.plTuongTac.Size = new System.Drawing.Size(278, 141);
		this.plTuongTac.TabIndex = 116;
		this.txtCauTraLoi.Location = new System.Drawing.Point(6, 23);
		this.txtCauTraLoi.Name = "txtCauTraLoi";
		this.txtCauTraLoi.Size = new System.Drawing.Size(266, 113);
		this.txtCauTraLoi.TabIndex = 117;
		this.txtCauTraLoi.Text = "";
		this.txtCauTraLoi.WordWrap = false;
		this.txtCauTraLoi.TextChanged += new System.EventHandler(C5009311);
		this.lblCauTraLoi.AutoSize = true;
		this.lblCauTraLoi.Location = new System.Drawing.Point(3, 4);
		this.lblCauTraLoi.Name = "lblCauTraLoi";
		this.lblCauTraLoi.Size = new System.Drawing.Size(153, 16);
		this.lblCauTraLoi.TabIndex = 0;
		this.lblCauTraLoi.Text = "Danh sách câu trả lời (0):";
		this.ckbGroupId.AutoSize = true;
		this.ckbGroupId.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGroupId.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbGroupId.Location = new System.Drawing.Point(365, 138);
		this.ckbGroupId.Name = "ckbGroupId";
		this.ckbGroupId.Size = new System.Drawing.Size(260, 20);
		this.ckbGroupId.TabIndex = 115;
		this.ckbGroupId.Text = "Chỉ tham gia nhóm thuộc danh sách sau:";
		this.ckbGroupId.UseVisualStyleBackColor = true;
		this.ckbGroupId.CheckedChanged += new System.EventHandler(ckbGroupId_CheckedChanged);
		this.DA8FC932.AutoSize = true;
		this.DA8FC932.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DA8FC932.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.DA8FC932.Location = new System.Drawing.Point(30, 301);
		this.DA8FC932.Name = "ckbTuDongTraLoiCauHoi";
		this.DA8FC932.Size = new System.Drawing.Size(156, 20);
		this.DA8FC932.TabIndex = 115;
		this.DA8FC932.Text = "Tự động trả lời câu hỏi";
		this.DA8FC932.UseVisualStyleBackColor = true;
		this.DA8FC932.CheckedChanged += new System.EventHandler(DA8FC932_CheckedChanged);
		this.txtTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtTuKhoa.Location = new System.Drawing.Point(31, 159);
		this.txtTuKhoa.Name = "txtTuKhoa";
		this.txtTuKhoa.Size = new System.Drawing.Size(295, 136);
		this.txtTuKhoa.TabIndex = 114;
		this.txtTuKhoa.Text = "";
		this.txtTuKhoa.WordWrap = false;
		this.txtTuKhoa.TextChanged += new System.EventHandler(txtTuKhoa_TextChanged);
		this.nudDelayTo.Location = new System.Drawing.Point(229, 107);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.lblTuKhoa.AutoSize = true;
		this.lblTuKhoa.Location = new System.Drawing.Point(27, 139);
		this.lblTuKhoa.Name = "lblTuKhoa";
		this.lblTuKhoa.Size = new System.Drawing.Size(139, 16);
		this.lblTuKhoa.TabIndex = 0;
		this.lblTuKhoa.Text = "Danh sa\u0301ch từ khóa (0):";
		this.DF210B39.Location = new System.Drawing.Point(132, 107);
		this.DF210B39.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.DF210B39.Name = "nudDelayFrom";
		this.DF210B39.Size = new System.Drawing.Size(56, 23);
		this.DF210B39.TabIndex = 3;
		this.DFBD9F11.Location = new System.Drawing.Point(194, 109);
		this.DFBD9F11.Name = "label7";
		this.DFBD9F11.Size = new System.Drawing.Size(29, 16);
		this.DFBD9F11.TabIndex = 46;
		this.DFBD9F11.Text = "đê\u0301n";
		this.DFBD9F11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(287, 109);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 109);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.nudSoLuongTo.Location = new System.Drawing.Point(229, 78);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.A58884BA.Location = new System.Drawing.Point(132, 49);
		this.A58884BA.Name = "txtTenHanhDong";
		this.A58884BA.Size = new System.Drawing.Size(194, 23);
		this.A58884BA.TabIndex = 0;
		this.D0A45336.Location = new System.Drawing.Point(194, 80);
		this.D0A45336.Name = "label3";
		this.D0A45336.Size = new System.Drawing.Size(29, 16);
		this.D0A45336.TabIndex = 37;
		this.D0A45336.Text = "đê\u0301n";
		this.D0A45336.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E1819CA7.AutoSize = true;
		this.E1819CA7.Location = new System.Drawing.Point(287, 80);
		this.E1819CA7.Name = "label4";
		this.E1819CA7.Size = new System.Drawing.Size(39, 16);
		this.E1819CA7.TabIndex = 35;
		this.E1819CA7.Text = "nhóm";
		this.A518B014.AutoSize = true;
		this.A518B014.Location = new System.Drawing.Point(27, 80);
		this.A518B014.Name = "label2";
		this.A518B014.Size = new System.Drawing.Size(63, 16);
		this.A518B014.TabIndex = 32;
		this.A518B014.Text = "Sô\u0301 lươ\u0323ng:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.FFBC4FB2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.FFBC4FB2.BackColor = System.Drawing.Color.Maroon;
		this.FFBC4FB2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FFBC4FB2.FlatAppearance.BorderSize = 0;
		this.FFBC4FB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.FFBC4FB2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FFBC4FB2.ForeColor = System.Drawing.Color.White;
		this.FFBC4FB2.Location = new System.Drawing.Point(347, 486);
		this.FFBC4FB2.Name = "btnCancel";
		this.FFBC4FB2.Size = new System.Drawing.Size(92, 29);
		this.FFBC4FB2.TabIndex = 7;
		this.FFBC4FB2.Text = "Đóng";
		this.FFBC4FB2.UseVisualStyleBackColor = false;
		this.FFBC4FB2.Click += new System.EventHandler(FFBC4FB2_Click);
		this.DE37E19E.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.DE37E19E.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.DE37E19E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DE37E19E.FlatAppearance.BorderSize = 0;
		this.DE37E19E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DE37E19E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DE37E19E.ForeColor = System.Drawing.Color.White;
		this.DE37E19E.Location = new System.Drawing.Point(240, 486);
		this.DE37E19E.Name = "btnAdd";
		this.DE37E19E.Size = new System.Drawing.Size(92, 29);
		this.DE37E19E.TabIndex = 6;
		this.DE37E19E.Text = "Thêm";
		this.DE37E19E.UseVisualStyleBackColor = false;
		this.DE37E19E.Click += new System.EventHandler(DE37E19E_Click);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(674, 37);
		this.bunifuCards1.TabIndex = 28;
		this.A7B51B10.AutomaticDelay = 0;
		this.A7B51B10.AutoPopDelay = 0;
		this.A7B51B10.InitialDelay = 0;
		this.A7B51B10.ReshowDelay = 0;
		this.A7B51B10.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(677, 532);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDThamGiaNhomTuKhoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B096B18B_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plGroupId.ResumeLayout(false);
		this.plGroupId.PerformLayout();
		this.plTuongTac.ResumeLayout(false);
		this.plTuongTac.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DF210B39).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
