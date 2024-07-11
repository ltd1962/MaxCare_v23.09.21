using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

using Newtonsoft.Json.Linq;

public class fHDBaiVietNewsfeedv2 : Form
{
	private JObject jobject_0;

	private string C4A5D833;

	private string string_0;

	private string string_1;

	private int C3245E96;

	public static bool F91967B1;

	private IContainer icontainer_0 = null;

	private BunifuDragControl C125AFBE;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudTimeTo;

	private NumericUpDown DF2BD585;

	private NumericUpDown nudTimeFrom;

	private TextBox FB35E830;

	private Label CC9D6130;

	private Label D6384799;

	private Label label6;

	private Label label4;

	private Label label5;

	private Label AF3553B4;

	private Label label1;

	private Button D582B8BE;

	private Button btnAdd;

	private BunifuCards B0B54DB0;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plComment;

	private Label label8;

	private Label B50506A9;

	private CheckBox ckbComment;

	private CheckBox C8BF4A32;

	private TextBox E8B7CF94;

	private CheckBox ckbShareWall;

	public fHDBaiVietNewsfeedv2(string A606BCBC, int AA81E626 = 0, string string_2 = "")
	{
		A9B33AAF();
		F91967B1 = false;
		C4A5D833 = A606BCBC;
		string_1 = string_2;
		C3245E96 = AA81E626;
		if (InteractSQL.B484648C("", "HDBaiVietNewsfeedv2").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDBaiVietNewsfeedv2', 'Bài viết Newsfeed v2');");
		}
		string json = "";
		switch (AA81E626)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDBaiVietNewsfeedv2");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			FB35E830.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			FB35E830.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void BD2CAFAE()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(AF3553B4);
		Language.smethod_0(D6384799);
		Language.smethod_0(label4);
		Language.smethod_0(label5);
		Language.smethod_0(CC9D6130);
		Language.smethod_0(label6);
		Language.smethod_0(ckbShareWall);
		Language.smethod_0(ckbComment);
		Language.smethod_0(B50506A9);
		Language.smethod_0(label8);
		Language.smethod_0(btnAdd);
		Language.smethod_0(D582B8BE);
	}

	private void D6B3492C_Load(object sender, EventArgs e)
	{
		try
		{
			nudTimeFrom.Value = Convert.ToInt32(jobject_0["nudTimeFrom"]);
			nudTimeTo.Value = Convert.ToInt32(jobject_0["nudTimeTo"]);
			DF2BD585.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			C8BF4A32.Checked = Convert.ToBoolean(jobject_0["ckbInteract"]);
			ckbShareWall.Checked = Convert.ToBoolean(jobject_0["ckbShareWall"]);
			ckbComment.Checked = Convert.ToBoolean(jobject_0["ckbComment"]);
			E8B7CF94.Text = jobject_0["txtComment"].ToString();
		}
		catch
		{
		}
		E79F8C1D();
	}

	private void A3219DBA(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (C3245E96 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") != DialogResult.Yes)
			{
				return;
			}
			string text = FB35E830.Text.Trim();
			if (text == "")
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
				return;
			}
			if (ckbComment.Checked)
			{
				List<string> a2AB53A = E8B7CF94.Lines.ToList();
				a2AB53A = Common.RemoveEmptyItems(a2AB53A);
				if (a2AB53A.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
					return;
				}
			}
			JSON_Settings gClass = new JSON_Settings();
			gClass.GetJson("nudTimeFrom", nudTimeFrom.Value);
			gClass.GetJson("nudTimeTo", nudTimeTo.Value);
			gClass.GetJson("nudDelayFrom", DF2BD585.Value);
			gClass.GetJson("nudDelayTo", nudDelayTo.Value);
			gClass.GetJson("ckbInteract", C8BF4A32.Checked);
			gClass.GetJson("ckbShareWall", ckbShareWall.Checked);
			gClass.GetJson("ckbComment", ckbComment.Checked);
			gClass.GetJson("txtComment", E8B7CF94.Text.Trim());
			string string_ = gClass.D9A09B34();
			if (InteractSQL.smethod_11(C4A5D833, text, string_0, string_))
			{
				F91967B1 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
		else
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") != DialogResult.Yes)
			{
				return;
			}
			string text2 = FB35E830.Text.Trim();
			if (text2 == "")
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
				return;
			}
			if (ckbComment.Checked)
			{
				List<string> a2AB53A2 = E8B7CF94.Lines.ToList();
				a2AB53A2 = Common.RemoveEmptyItems(a2AB53A2);
				if (a2AB53A2.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
					return;
				}
			}
			JSON_Settings gClass2 = new JSON_Settings();
			gClass2.GetJson("nudTimeFrom", nudTimeFrom.Value);
			gClass2.GetJson("nudTimeTo", nudTimeTo.Value);
			gClass2.GetJson("nudDelayFrom", DF2BD585.Value);
			gClass2.GetJson("nudDelayTo", nudDelayTo.Value);
			gClass2.GetJson("ckbInteract", C8BF4A32.Checked);
			gClass2.GetJson("ckbShareWall", ckbShareWall.Checked);
			gClass2.GetJson("ckbComment", ckbComment.Checked);
			gClass2.GetJson("txtComment", E8B7CF94.Text.Trim());
			string text3 = gClass2.D9A09B34();
			if (InteractSQL.smethod_13(string_1, text2, text3))
			{
				F91967B1 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void A1AA9D89(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void E8B7CF94_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = E8B7CF94.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			B50506A9.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void E79F8C1D()
	{
		C82821AE(null, null);
		DDAB3023(null, null);
	}

	private void C82821AE(object sender, EventArgs e)
	{
	}

	private void DDAB3023(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void A9B33AAF()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDBaiVietNewsfeedv2));
		C125AFBE = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		plComment = new Panel();
		E8B7CF94 = new TextBox();
		label8 = new Label();
		B50506A9 = new Label();
		ckbComment = new CheckBox();
		ckbShareWall = new CheckBox();
		C8BF4A32 = new CheckBox();
		nudDelayTo = new NumericUpDown();
		nudTimeTo = new NumericUpDown();
		DF2BD585 = new NumericUpDown();
		nudTimeFrom = new NumericUpDown();
		FB35E830 = new TextBox();
		CC9D6130 = new Label();
		D6384799 = new Label();
		label6 = new Label();
		label4 = new Label();
		label5 = new Label();
		AF3553B4 = new Label();
		label1 = new Label();
		D582B8BE = new Button();
		btnAdd = new Button();
		B0B54DB0 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plComment.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudTimeTo).BeginInit();
		((ISupportInitialize)DF2BD585).BeginInit();
		((ISupportInitialize)nudTimeFrom).BeginInit();
		B0B54DB0.SuspendLayout();
		SuspendLayout();
		C125AFBE.Fixed = true;
		C125AFBE.Horizontal = true;
		C125AFBE.TargetControl = bunifuCustomLabel1;
		C125AFBE.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Bài viết Newsfeed v2";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(328, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += A3219DBA;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(ckbShareWall);
		panel1.Controls.Add(C8BF4A32);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudTimeTo);
		panel1.Controls.Add(DF2BD585);
		panel1.Controls.Add(nudTimeFrom);
		panel1.Controls.Add(FB35E830);
		panel1.Controls.Add(CC9D6130);
		panel1.Controls.Add(D6384799);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(AF3553B4);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(D582B8BE);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(B0B54DB0);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 436);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		plComment.BorderStyle = BorderStyle.FixedSingle;
		plComment.Controls.Add(E8B7CF94);
		plComment.Controls.Add(label8);
		plComment.Controls.Add(B50506A9);
		plComment.Location = new Point(48, 218);
		plComment.Name = "plComment";
		plComment.Size = new Size(278, 164);
		plComment.TabIndex = 8;
		E8B7CF94.Location = new Point(7, 27);
		E8B7CF94.Multiline = true;
		E8B7CF94.Name = "txtComment";
		E8B7CF94.ScrollBars = ScrollBars.Both;
		E8B7CF94.Size = new Size(261, 111);
		E8B7CF94.TabIndex = 1;
		E8B7CF94.WordWrap = false;
		E8B7CF94.TextChanged += E8B7CF94_TextChanged;
		label8.AutoSize = true;
		label8.Location = new Point(4, 141);
		label8.Name = "label8";
		label8.Size = new Size(265, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		B50506A9.AutoSize = true;
		B50506A9.Location = new Point(3, 5);
		B50506A9.Name = "lblStatus";
		B50506A9.Size = new Size(139, 16);
		B50506A9.TabIndex = 0;
		B50506A9.Text = "Nội dung bình luận (0):";
		ckbComment.AutoSize = true;
		ckbComment.Cursor = Cursors.Hand;
		ckbComment.Location = new Point(30, 193);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new Size(130, 20);
		ckbComment.TabIndex = 7;
		ckbComment.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += DDAB3023;
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = Cursors.Hand;
		ckbShareWall.Location = new Point(30, 167);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new Size(122, 20);
		ckbShareWall.TabIndex = 6;
		ckbShareWall.Text = "Chia sẻ về tường";
		ckbShareWall.UseVisualStyleBackColor = true;
		C8BF4A32.AutoSize = true;
		C8BF4A32.Cursor = Cursors.Hand;
		C8BF4A32.Location = new Point(30, 141);
		C8BF4A32.Name = "ckbInteract";
		C8BF4A32.Size = new Size(48, 20);
		C8BF4A32.TabIndex = 5;
		C8BF4A32.Text = "Like";
		C8BF4A32.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new Point(231, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudTimeTo.Location = new Point(231, 80);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new Size(56, 23);
		nudTimeTo.TabIndex = 2;
		DF2BD585.Location = new Point(134, 111);
		DF2BD585.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DF2BD585.Name = "nudDelayFrom";
		DF2BD585.Size = new Size(56, 23);
		DF2BD585.TabIndex = 3;
		nudTimeFrom.Location = new Point(134, 80);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new Size(56, 23);
		nudTimeFrom.TabIndex = 1;
		FB35E830.Location = new Point(134, 49);
		FB35E830.Name = "txtTenHanhDong";
		FB35E830.Size = new Size(194, 23);
		FB35E830.TabIndex = 0;
		CC9D6130.AutoSize = true;
		CC9D6130.Location = new Point(196, 113);
		CC9D6130.Name = "label7";
		CC9D6130.Size = new Size(28, 16);
		CC9D6130.TabIndex = 38;
		CC9D6130.Text = "đê\u0301n";
		D6384799.AutoSize = true;
		D6384799.Location = new Point(196, 82);
		D6384799.Name = "label3";
		D6384799.Size = new Size(28, 16);
		D6384799.TabIndex = 37;
		D6384799.Text = "đê\u0301n";
		label6.AutoSize = true;
		label6.Location = new Point(292, 113);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new Point(292, 82);
		label4.Name = "label4";
		label4.Size = new Size(30, 16);
		label4.TabIndex = 35;
		label4.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new Point(27, 113);
		label5.Name = "label5";
		label5.Size = new Size(110, 16);
		label5.TabIndex = 34;
		label5.Text = "Khoa\u0309ng ca\u0301ch lươ\u0301t:";
		AF3553B4.AutoSize = true;
		AF3553B4.Location = new Point(27, 82);
		AF3553B4.Name = "label2";
		AF3553B4.Size = new Size(91, 16);
		AF3553B4.TabIndex = 32;
		AF3553B4.Text = "Thơ\u0300i gian lươ\u0301t:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		D582B8BE.BackColor = Color.Maroon;
		D582B8BE.Cursor = Cursors.Hand;
		D582B8BE.FlatAppearance.BorderSize = 0;
		D582B8BE.FlatStyle = FlatStyle.Flat;
		D582B8BE.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		D582B8BE.ForeColor = Color.White;
		D582B8BE.Location = new Point(189, 393);
		D582B8BE.Name = "btnCancel";
		D582B8BE.Size = new Size(92, 29);
		D582B8BE.TabIndex = 10;
		D582B8BE.Text = "Đóng";
		D582B8BE.UseVisualStyleBackColor = false;
		D582B8BE.Click += A1AA9D89;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(82, 393);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		B0B54DB0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B0B54DB0.BackColor = Color.White;
		B0B54DB0.BorderRadius = 0;
		B0B54DB0.BottomSahddow = true;
		B0B54DB0.color = Color.DarkViolet;
		B0B54DB0.Controls.Add(pnlHeader);
		B0B54DB0.LeftSahddow = false;
		B0B54DB0.Location = new Point(1, 0);
		B0B54DB0.Name = "bunifuCards1";
		B0B54DB0.RightSahddow = true;
		B0B54DB0.ShadowDepth = 20;
		B0B54DB0.Size = new Size(359, 37);
		B0B54DB0.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 436);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietNewsfeedv2";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += D6B3492C_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		plComment.ResumeLayout(performLayout: false);
		plComment.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudTimeTo).EndInit();
		((ISupportInitialize)DF2BD585).EndInit();
		((ISupportInitialize)nudTimeFrom).EndInit();
		B0B54DB0.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
