using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ucTuongTacReel : UserControl
{
	private JSON_Settings gclass8_0;

	private IContainer icontainer_0 = null;

	private Button btnSave;

	private Button btnCancel;

	private Panel plComment;

	private RichTextBox txtComment;

	private Label CA3DA423;

	private CheckBox ckbComment;

	private CheckBox DF36BF3E;

	private CheckBox AF2CFA16;

	private NumericUpDown nudTimeTo;

	private NumericUpDown B71AB585;

	private Label label13;

	private Label B405D037;

	private Label F202B23D;

	private Label label3;

	private Label CE30B605;

	private ComboBox cbbTuyChonNoiDung;

	private Button F613EC82;

	public ucTuongTacReel(JSON_Settings BC3E83B9)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		gclass8_0 = BC3E83B9;
	}

	private void AB107625(object sender, EventArgs e)
	{
		Hide();
	}

	private void F017A288(object sender, EventArgs e)
	{
		method_1();
		Hide();
	}

	private void method_0()
	{
		List<string> e6A5AC = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		Common.F714B10E(cbbTuyChonNoiDung, e6A5AC);
	}

	private void AFAE70A4()
	{
		try
		{
			method_0();
			B71AB585.Value = gclass8_0.GetValueInt("nudTimeFrom", 15);
			nudTimeTo.Value = gclass8_0.GetValueInt("nudTimeTo", 30);
			AF2CFA16.Checked = gclass8_0.GetValueBool("ckbInteract");
			ckbComment.Checked = gclass8_0.GetValueBool("ckbComment");
			DF36BF3E.Checked = gclass8_0.GetValueBool("ckbShareWall");
			txtComment.Text = gclass8_0.GetValue("txtComment");
			cbbTuyChonNoiDung.SelectedIndex = gclass8_0.GetValueInt("typeNganCachCommentReel");
			ckbComment_CheckedChanged(null, null);
		}
		catch
		{
		}
	}

	private void method_1()
	{
		gclass8_0.GetJson("nudTimeFrom", B71AB585.Value);
		gclass8_0.GetJson("nudTimeTo", nudTimeTo.Value);
		gclass8_0.GetJson("ckbInteract", AF2CFA16.Checked);
		gclass8_0.GetJson("ckbShareWall", DF36BF3E.Checked);
		gclass8_0.GetJson("ckbComment", ckbComment.Checked);
		gclass8_0.GetJson("txtComment", txtComment.Text.Trim());
		gclass8_0.GetJson("typeNganCachCommentReel", cbbTuyChonNoiDung.SelectedIndex);
	}

	private void ucTuongTacReel_Load(object sender, EventArgs e)
	{
		AFAE70A4();
	}

	private void ucTuongTacReel_VisibleChanged(object sender, EventArgs e)
	{
		if (base.Visible)
		{
			AFAE70A4();
		}
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtComment, CA3DA423, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void method_2(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtComment.Focus();
	}

	private void FD09980D(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void F613EC82_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDung.SelectedIndex == 0)
		{
			MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			Common.ShowForm(new fHelpNhapComment());
		}
		txtComment.Focus();
	}

	private void cbbTuyChonNoiDung_SelectedIndexChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtComment, CA3DA423, cbbTuyChonNoiDung.SelectedIndex);
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
		this.btnSave = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.plComment = new System.Windows.Forms.Panel();
		this.label3 = new System.Windows.Forms.Label();
		this.CE30B605 = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.CA3DA423 = new System.Windows.Forms.Label();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.DF36BF3E = new System.Windows.Forms.CheckBox();
		this.AF2CFA16 = new System.Windows.Forms.CheckBox();
		this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
		this.B71AB585 = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.B405D037 = new System.Windows.Forms.Label();
		this.F202B23D = new System.Windows.Forms.Label();
		this.cbbTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		this.F613EC82 = new System.Windows.Forms.Button();
		this.plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.B71AB585).BeginInit();
		base.SuspendLayout();
		this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnSave.FlatAppearance.BorderSize = 0;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSave.ForeColor = System.Drawing.Color.White;
		this.btnSave.Location = new System.Drawing.Point(71, 383);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(92, 29);
		this.btnSave.TabIndex = 180;
		this.btnSave.Text = "Lưu";
		this.btnSave.UseVisualStyleBackColor = false;
		this.btnSave.Click += new System.EventHandler(F017A288);
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(181, 383);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 181;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(AB107625);
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.cbbTuyChonNoiDung);
		this.plComment.Controls.Add(this.F613EC82);
		this.plComment.Controls.Add(this.label3);
		this.plComment.Controls.Add(this.CE30B605);
		this.plComment.Controls.Add(this.txtComment);
		this.plComment.Controls.Add(this.CA3DA423);
		this.plComment.Location = new System.Drawing.Point(37, 98);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(278, 268);
		this.plComment.TabIndex = 187;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(2, 240);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(64, 16);
		this.label3.TabIndex = 181;
		this.label3.Text = "Tùy chọn:";
		this.CE30B605.AutoSize = true;
		this.CE30B605.Location = new System.Drawing.Point(3, 218);
		this.CE30B605.Name = "label11";
		this.CE30B605.Size = new System.Drawing.Size(133, 16);
		this.CE30B605.TabIndex = 180;
		this.CE30B605.Text = "Spin nội dung {a|b|c}";
		this.txtComment.Location = new System.Drawing.Point(6, 24);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(264, 191);
		this.txtComment.TabIndex = 45;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.CA3DA423.AutoSize = true;
		this.CA3DA423.Location = new System.Drawing.Point(3, 5);
		this.CA3DA423.Name = "lblComment";
		this.CA3DA423.Size = new System.Drawing.Size(139, 16);
		this.CA3DA423.TabIndex = 0;
		this.CA3DA423.Text = "Nội dung bình luận (0):";
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(19, 72);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(81, 20);
		this.ckbComment.TabIndex = 186;
		this.ckbComment.Text = "Comment";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		this.DF36BF3E.AutoSize = true;
		this.DF36BF3E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DF36BF3E.Location = new System.Drawing.Point(121, 46);
		this.DF36BF3E.Name = "ckbShareWall";
		this.DF36BF3E.Size = new System.Drawing.Size(89, 20);
		this.DF36BF3E.TabIndex = 185;
		this.DF36BF3E.Text = "Share Wall";
		this.DF36BF3E.UseVisualStyleBackColor = true;
		this.AF2CFA16.AutoSize = true;
		this.AF2CFA16.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AF2CFA16.Location = new System.Drawing.Point(19, 46);
		this.AF2CFA16.Name = "ckbInteract";
		this.AF2CFA16.Size = new System.Drawing.Size(48, 20);
		this.AF2CFA16.TabIndex = 184;
		this.AF2CFA16.Text = "Like";
		this.AF2CFA16.UseVisualStyleBackColor = true;
		this.nudTimeTo.Location = new System.Drawing.Point(218, 17);
		this.nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeTo.Name = "nudTimeTo";
		this.nudTimeTo.Size = new System.Drawing.Size(56, 23);
		this.nudTimeTo.TabIndex = 183;
		this.B71AB585.Location = new System.Drawing.Point(121, 17);
		this.B71AB585.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.B71AB585.Name = "nudTimeFrom";
		this.B71AB585.Size = new System.Drawing.Size(56, 23);
		this.B71AB585.TabIndex = 182;
		this.label13.Location = new System.Drawing.Point(183, 19);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(29, 16);
		this.label13.TabIndex = 190;
		this.label13.Text = "đê\u0301n";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.B405D037.AutoSize = true;
		this.B405D037.Location = new System.Drawing.Point(279, 19);
		this.B405D037.Name = "label14";
		this.B405D037.Size = new System.Drawing.Size(30, 16);
		this.B405D037.TabIndex = 189;
		this.B405D037.Text = "giây";
		this.F202B23D.AutoSize = true;
		this.F202B23D.Location = new System.Drawing.Point(16, 19);
		this.F202B23D.Name = "label21";
		this.F202B23D.Size = new System.Drawing.Size(93, 16);
		this.F202B23D.TabIndex = 188;
		this.F202B23D.Text = "Thơ\u0300i gian xem:";
		this.cbbTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTuyChonNoiDung.FormattingEnabled = true;
		this.cbbTuyChonNoiDung.Location = new System.Drawing.Point(68, 237);
		this.cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		this.cbbTuyChonNoiDung.Size = new System.Drawing.Size(170, 24);
		this.cbbTuyChonNoiDung.TabIndex = 184;
		this.cbbTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(cbbTuyChonNoiDung_SelectedIndexChanged);
		this.F613EC82.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F613EC82.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F613EC82.Location = new System.Drawing.Point(244, 236);
		this.F613EC82.Name = "btnHuongDanNhapNoiDung";
		this.F613EC82.Size = new System.Drawing.Size(26, 26);
		this.F613EC82.TabIndex = 183;
		this.F613EC82.Text = "?";
		this.F613EC82.UseVisualStyleBackColor = true;
		this.F613EC82.Click += new System.EventHandler(F613EC82_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.White;
		base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		base.Controls.Add(this.plComment);
		base.Controls.Add(this.ckbComment);
		base.Controls.Add(this.DF36BF3E);
		base.Controls.Add(this.AF2CFA16);
		base.Controls.Add(this.nudTimeTo);
		base.Controls.Add(this.B71AB585);
		base.Controls.Add(this.label13);
		base.Controls.Add(this.B405D037);
		base.Controls.Add(this.F202B23D);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.btnCancel);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Name = "ucTuongTacReel";
		base.Size = new System.Drawing.Size(340, 425);
		base.Load += new System.EventHandler(ucTuongTacReel_Load);
		base.VisibleChanged += new System.EventHandler(ucTuongTacReel_VisibleChanged);
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.B71AB585).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
