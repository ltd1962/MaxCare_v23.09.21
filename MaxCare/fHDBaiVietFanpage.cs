using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDBaiVietFanpage : Form
{
	private JObject A7A49881;

	private string CB1783B6;

	private string string_0;

	private string string_1;

	private int BE9C1239;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl B8AD41B3;

	private BunifuDragControl DF841933;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudSoLuongBaiVietTo;

	private NumericUpDown E89378BC;

	private NumericUpDown nudSoLuongBaiVietFrom;

	private TextBox F09ECC3E;

	private Label label7;

	private Label label3;

	private Label B42F9227;

	private Label label4;

	private Label label5;

	private Label label1;

	private Button C4011B1A;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel E8A759A8;

	private Button EA3EB2A7;

	private PictureBox pictureBox1;

	private BunifuCustomLabel D3AC1006;

	private CheckBox ckbComment;

	private CheckBox ckbInteract;

	private CheckBox ckbShareWall;

	private Label label49;

	private NumericUpDown AAA21F1A;

	private Label label68;

	private Label label19;

	private NumericUpDown E5107008;

	private Label label66;

	private Label label2;

	private Label lblStatusUid;

	private RichTextBox txtUid;

	private CheckBox ckbLikePage;

	private Panel panel2;

	private Label label9;

	private NumericUpDown nudViewFrom;

	private Label label10;

	private Label label11;

	private NumericUpDown nudViewTo;

	private CheckBox BD2F6021;

	private Panel plComment;

	private Panel plCommentText;

	private LinkLabel F314E389;

	private Button button3;

	private Button button4;

	private Button button2;

	private RichTextBox txtComment;

	private Button btnDown;

	private Button AF29BF2C;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label8;

	private Label label12;

	private Label lblStatus;

	private Panel plAnh;

	private TextBox txtAnh;

	private Label label16;

	private CheckBox ckbSendAnh;

	private CheckBox FE25EA9D;

	public fHDBaiVietFanpage(string F5112E89, int C0294B82 = 0, string BE3293A6 = "")
	{
		BD93B7A8();
		bool_0 = false;
		CB1783B6 = F5112E89;
		string_1 = BE3293A6;
		BE9C1239 = C0294B82;
		string json = "";
		switch (C0294B82)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDBaiVietFanpage");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			F09ECC3E.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(BE3293A6);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			F09ECC3E.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		A7A49881 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(D3AC1006);
		Language.smethod_0(label1);
		Language.smethod_0(label49);
		Language.smethod_0(label66);
		Language.smethod_0(label68);
		Language.smethod_0(label19);
		Language.smethod_0(label3);
		Language.smethod_0(label4);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(B42F9227);
		Language.smethod_0(lblStatusUid);
		Language.smethod_0(label2);
		Language.smethod_0(BD2F6021);
		Language.smethod_0(label9);
		Language.smethod_0(label11);
		Language.smethod_0(label10);
		Language.smethod_0(ckbInteract);
		Language.smethod_0(ckbShareWall);
		Language.smethod_0(ckbComment);
		Language.smethod_0(lblStatus);
		Language.smethod_0(button3);
		Language.smethod_0(label12);
		Language.smethod_0(ckbLikePage);
		Language.smethod_0(btnAdd);
		Language.smethod_0(C4011B1A);
	}

	private void F6873C1C(object sender, EventArgs e)
	{
		try
		{
			AAA21F1A.Value = Convert.ToInt32(A7A49881["nudSoLuongPageFrom"]);
			E5107008.Value = Convert.ToInt32(A7A49881["nudSoLuongPageTo"]);
			nudSoLuongBaiVietFrom.Value = Convert.ToInt32(A7A49881["nudSoLuongBaiVietFrom"]);
			nudSoLuongBaiVietTo.Value = Convert.ToInt32(A7A49881["nudSoLuongBaiVietTo"]);
			E89378BC.Value = Convert.ToInt32(A7A49881["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(A7A49881["nudDelayTo"]);
			txtUid.Text = A7A49881["txtUid"].ToString();
			ckbInteract.Checked = Convert.ToBoolean(A7A49881["ckbInteract"]);
			ckbShareWall.Checked = Convert.ToBoolean(A7A49881["ckbShareWall"]);
			ckbComment.Checked = Convert.ToBoolean(A7A49881["ckbComment"]);
			FE25EA9D.Checked = Convert.ToBoolean(A7A49881["ckbCommentText"]);
			txtComment.Text = A7A49881["txtComment"].ToString();
			ckbSendAnh.Checked = Convert.ToBoolean(A7A49881["ckbSendAnh"]);
			txtAnh.Text = A7A49881["txtAnh"].ToString();
			if (Convert.ToInt32(A7A49881["typeNganCach"]) == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			ckbLikePage.Checked = Convert.ToBoolean(A7A49881["ckbLikePage"]);
			BD2F6021.Checked = Convert.ToBoolean(A7A49881["ckbAutoPlayVideo"]);
			nudViewFrom.Value = Convert.ToInt32(A7A49881["nudViewFrom"]);
			nudViewTo.Value = Convert.ToInt32(A7A49881["nudViewTo"]);
		}
		catch
		{
		}
		CF9B5DA7();
	}

	private void EA3EB2A7_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (BE9C1239 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") != DialogResult.Yes)
			{
				return;
			}
			string text = F09ECC3E.Text.Trim();
			if (text == "")
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
				return;
			}
			List<string> a2AB53A = txtUid.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Id page!", 3);
				return;
			}
			if (ckbComment.Checked)
			{
				a2AB53A = txtComment.Lines.ToList();
				a2AB53A = Common.RemoveEmptyItems(a2AB53A);
				if (a2AB53A.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
					return;
				}
			}
			JSON_Settings gClass = new JSON_Settings();
			gClass.GetJson("nudSoLuongPageFrom", AAA21F1A.Value);
			gClass.GetJson("nudSoLuongPageTo", E5107008.Value);
			gClass.GetJson("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
			gClass.GetJson("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
			gClass.GetJson("nudDelayFrom", E89378BC.Value);
			gClass.GetJson("nudDelayTo", nudDelayTo.Value);
			gClass.GetJson("txtUid", txtUid.Text.Trim());
			gClass.GetJson("ckbInteract", ckbInteract.Checked);
			gClass.GetJson("ckbShareWall", ckbShareWall.Checked);
			gClass.GetJson("ckbComment", ckbComment.Checked);
			gClass.GetJson("ckbCommentText", FE25EA9D.Checked);
			gClass.GetJson("txtComment", txtComment.Text.Trim());
			gClass.GetJson("ckbSendAnh", ckbSendAnh.Checked);
			gClass.GetJson("txtAnh", txtAnh.Text.Trim());
			int num = 0;
			if (rbNganCachKyTu.Checked)
			{
				num = 1;
			}
			gClass.GetJson("typeNganCach", num);
			gClass.GetJson("ckbLikePage", ckbLikePage.Checked);
			gClass.GetJson("ckbAutoPlayVideo", BD2F6021.Checked);
			gClass.GetJson("nudViewFrom", nudViewFrom.Value);
			gClass.GetJson("nudViewTo", nudViewTo.Value);
			string string_ = gClass.D9A09B34();
			if (InteractSQL.smethod_11(CB1783B6, text, string_0, string_))
			{
				bool_0 = true;
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
			string text2 = F09ECC3E.Text.Trim();
			if (text2 == "")
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
				return;
			}
			List<string> a2AB53A2 = txtUid.Lines.ToList();
			a2AB53A2 = Common.RemoveEmptyItems(a2AB53A2);
			if (a2AB53A2.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Id page!", 3);
				return;
			}
			if (ckbComment.Checked)
			{
				a2AB53A2 = txtComment.Lines.ToList();
				a2AB53A2 = Common.RemoveEmptyItems(a2AB53A2);
				if (a2AB53A2.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
					return;
				}
			}
			JSON_Settings gClass2 = new JSON_Settings();
			gClass2.GetJson("nudSoLuongPageFrom", AAA21F1A.Value);
			gClass2.GetJson("nudSoLuongPageTo", E5107008.Value);
			gClass2.GetJson("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
			gClass2.GetJson("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
			gClass2.GetJson("nudDelayFrom", E89378BC.Value);
			gClass2.GetJson("nudDelayTo", nudDelayTo.Value);
			gClass2.GetJson("txtUid", txtUid.Text.Trim());
			gClass2.GetJson("ckbInteract", ckbInteract.Checked);
			gClass2.GetJson("ckbShareWall", ckbShareWall.Checked);
			gClass2.GetJson("ckbComment", ckbComment.Checked);
			gClass2.GetJson("ckbCommentText", FE25EA9D.Checked);
			gClass2.GetJson("txtComment", txtComment.Text.Trim());
			gClass2.GetJson("ckbSendAnh", ckbSendAnh.Checked);
			gClass2.GetJson("txtAnh", txtAnh.Text.Trim());
			int num2 = 0;
			if (rbNganCachKyTu.Checked)
			{
				num2 = 1;
			}
			gClass2.GetJson("typeNganCach", num2);
			gClass2.GetJson("ckbLikePage", ckbLikePage.Checked);
			gClass2.GetJson("ckbAutoPlayVideo", BD2F6021.Checked);
			gClass2.GetJson("nudViewFrom", nudViewFrom.Value);
			gClass2.GetJson("nudViewTo", nudViewTo.Value);
			string text3 = gClass2.D9A09B34();
			if (InteractSQL.smethod_13(string_1, text2, text3))
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

	private void C4011B1A_Click(object sender, EventArgs e)
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

	private void CD23BAB4(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void CF9B5DA7()
	{
		method_2(null, null);
		ckbComment_CheckedChanged(null, null);
		BD2F6021_CheckedChanged(null, null);
		FE25EA9D_CheckedChanged(null, null);
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void BD1EBB0E(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtUid.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatusUid.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid page cần tương ta\u0301c ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void BD2F6021_CheckedChanged(object sender, EventArgs e)
	{
		panel2.Enabled = BD2F6021.Checked;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 210;
	}

	private void AF29BF2C_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 164;
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			AF29BF2C.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_4(object sender, EventArgs e)
	{
		method_1();
	}

	private void BC3C6511(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên page!");
	}

	private void method_5(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		txtComment.Focus();
	}

	private void A6B33B84(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void method_6(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void FE25EA9D_CheckedChanged(object sender, EventArgs e)
	{
		plCommentText.Enabled = FE25EA9D.Checked;
	}

	private void B6A63FA7(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbSendAnh.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void BD93B7A8()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDBaiVietFanpage));
		B8AD41B3 = new BunifuDragControl(icontainer_0);
		D3AC1006 = new BunifuCustomLabel();
		DF841933 = new BunifuDragControl(icontainer_0);
		E8A759A8 = new Panel();
		EA3EB2A7 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		plComment = new Panel();
		plCommentText = new Panel();
		F314E389 = new LinkLabel();
		button3 = new Button();
		button4 = new Button();
		button2 = new Button();
		txtComment = new RichTextBox();
		btnDown = new Button();
		AF29BF2C = new Button();
		rbNganCachKyTu = new RadioButton();
		rbNganCachMoiDong = new RadioButton();
		label8 = new Label();
		label12 = new Label();
		lblStatus = new Label();
		plAnh = new Panel();
		txtAnh = new TextBox();
		label16 = new Label();
		ckbSendAnh = new CheckBox();
		FE25EA9D = new CheckBox();
		txtUid = new RichTextBox();
		label2 = new Label();
		lblStatusUid = new Label();
		label49 = new Label();
		AAA21F1A = new NumericUpDown();
		label68 = new Label();
		label19 = new Label();
		E5107008 = new NumericUpDown();
		label66 = new Label();
		panel2 = new Panel();
		label9 = new Label();
		nudViewFrom = new NumericUpDown();
		label10 = new Label();
		label11 = new Label();
		nudViewTo = new NumericUpDown();
		ckbComment = new CheckBox();
		ckbShareWall = new CheckBox();
		ckbLikePage = new CheckBox();
		BD2F6021 = new CheckBox();
		ckbInteract = new CheckBox();
		nudDelayTo = new NumericUpDown();
		nudSoLuongBaiVietTo = new NumericUpDown();
		E89378BC = new NumericUpDown();
		nudSoLuongBaiVietFrom = new NumericUpDown();
		F09ECC3E = new TextBox();
		label7 = new Label();
		label3 = new Label();
		B42F9227 = new Label();
		label4 = new Label();
		label5 = new Label();
		label1 = new Label();
		C4011B1A = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		E8A759A8.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plComment.SuspendLayout();
		plCommentText.SuspendLayout();
		plAnh.SuspendLayout();
		((ISupportInitialize)AAA21F1A).BeginInit();
		((ISupportInitialize)E5107008).BeginInit();
		panel2.SuspendLayout();
		((ISupportInitialize)nudViewFrom).BeginInit();
		((ISupportInitialize)nudViewTo).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudSoLuongBaiVietTo).BeginInit();
		((ISupportInitialize)E89378BC).BeginInit();
		((ISupportInitialize)nudSoLuongBaiVietFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		B8AD41B3.Fixed = true;
		B8AD41B3.Horizontal = true;
		B8AD41B3.TargetControl = D3AC1006;
		B8AD41B3.Vertical = true;
		D3AC1006.BackColor = Color.Transparent;
		D3AC1006.Cursor = Cursors.SizeAll;
		D3AC1006.Dock = DockStyle.Fill;
		D3AC1006.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		D3AC1006.ForeColor = Color.Black;
		D3AC1006.Location = new Point(0, 0);
		D3AC1006.Name = "bunifuCustomLabel1";
		D3AC1006.Size = new Size(680, 31);
		D3AC1006.TabIndex = 12;
		D3AC1006.Text = "Cấu hình Bài viết Fanpage";
		D3AC1006.TextAlign = ContentAlignment.MiddleCenter;
		DF841933.Fixed = true;
		DF841933.Horizontal = true;
		DF841933.TargetControl = E8A759A8;
		DF841933.Vertical = true;
		E8A759A8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		E8A759A8.BackColor = Color.White;
		E8A759A8.Controls.Add(EA3EB2A7);
		E8A759A8.Controls.Add(pictureBox1);
		E8A759A8.Controls.Add(D3AC1006);
		E8A759A8.Cursor = Cursors.SizeAll;
		E8A759A8.Location = new Point(0, 3);
		E8A759A8.Name = "pnlHeader";
		E8A759A8.Size = new Size(680, 31);
		E8A759A8.TabIndex = 9;
		EA3EB2A7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		EA3EB2A7.Cursor = Cursors.Hand;
		EA3EB2A7.FlatAppearance.BorderSize = 0;
		EA3EB2A7.FlatStyle = FlatStyle.Flat;
		EA3EB2A7.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		EA3EB2A7.ForeColor = Color.White;
		EA3EB2A7.Image = (Image)componentResourceManager.GetObject("button1.Image");
		EA3EB2A7.Location = new Point(649, 1);
		EA3EB2A7.Name = "button1";
		EA3EB2A7.Size = new Size(30, 30);
		EA3EB2A7.TabIndex = 77;
		EA3EB2A7.TextImageRelation = TextImageRelation.ImageBeforeText;
		EA3EB2A7.UseVisualStyleBackColor = true;
		EA3EB2A7.Click += EA3EB2A7_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += pictureBox1_Click;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(lblStatusUid);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(AAA21F1A);
		panel1.Controls.Add(label68);
		panel1.Controls.Add(label19);
		panel1.Controls.Add(E5107008);
		panel1.Controls.Add(label66);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(ckbShareWall);
		panel1.Controls.Add(ckbLikePage);
		panel1.Controls.Add(BD2F6021);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudSoLuongBaiVietTo);
		panel1.Controls.Add(E89378BC);
		panel1.Controls.Add(nudSoLuongBaiVietFrom);
		panel1.Controls.Add(F09ECC3E);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(B42F9227);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(C4011B1A);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(683, 533);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		plComment.BorderStyle = BorderStyle.FixedSingle;
		plComment.Controls.Add(plCommentText);
		plComment.Controls.Add(plAnh);
		plComment.Controls.Add(ckbSendAnh);
		plComment.Controls.Add(FE25EA9D);
		plComment.Location = new Point(364, 186);
		plComment.Name = "plComment";
		plComment.Size = new Size(306, 262);
		plComment.TabIndex = 118;
		plCommentText.BorderStyle = BorderStyle.FixedSingle;
		plCommentText.Controls.Add(F314E389);
		plCommentText.Controls.Add(button3);
		plCommentText.Controls.Add(button4);
		plCommentText.Controls.Add(button2);
		plCommentText.Controls.Add(txtComment);
		plCommentText.Controls.Add(btnDown);
		plCommentText.Controls.Add(AF29BF2C);
		plCommentText.Controls.Add(rbNganCachKyTu);
		plCommentText.Controls.Add(rbNganCachMoiDong);
		plCommentText.Controls.Add(label8);
		plCommentText.Controls.Add(label12);
		plCommentText.Controls.Add(lblStatus);
		plCommentText.Location = new Point(24, 29);
		plCommentText.Name = "plCommentText";
		plCommentText.Size = new Size(278, 164);
		plCommentText.TabIndex = 8;
		F314E389.AutoSize = true;
		F314E389.Cursor = Cursors.Hand;
		F314E389.Location = new Point(163, 142);
		F314E389.Name = "linkLabel1";
		F314E389.Size = new Size(81, 16);
		F314E389.TabIndex = 176;
		F314E389.TabStop = true;
		F314E389.Text = "Random icon";
		button3.Cursor = Cursors.Help;
		button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button3.Location = new Point(227, 185);
		button3.Name = "button3";
		button3.Size = new Size(21, 23);
		button3.TabIndex = 127;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button4.Cursor = Cursors.Help;
		button4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button4.Location = new Point(227, 162);
		button4.Name = "button4";
		button4.Size = new Size(21, 23);
		button4.TabIndex = 128;
		button4.Text = "?";
		button4.UseVisualStyleBackColor = true;
		button2.Cursor = Cursors.Help;
		button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button2.Location = new Point(247, 139);
		button2.Name = "button2";
		button2.Size = new Size(23, 23);
		button2.TabIndex = 126;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		txtComment.Location = new Point(7, 27);
		txtComment.Name = "txtComment";
		txtComment.Size = new Size(263, 111);
		txtComment.TabIndex = 114;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += CD23BAB4;
		btnDown.BackgroundImage = Resources.Bitmap_83;
		btnDown.Cursor = Cursors.Hand;
		btnDown.FlatAppearance.BorderColor = Color.Silver;
		btnDown.FlatStyle = FlatStyle.Flat;
		btnDown.Location = new Point(221, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new Size(25, 25);
		btnDown.TabIndex = 112;
		btnDown.Click += btnDown_Click;
		AF29BF2C.BackgroundImage = Resources.E536C319;
		AF29BF2C.Cursor = Cursors.Hand;
		AF29BF2C.FlatAppearance.BorderColor = Color.Silver;
		AF29BF2C.FlatStyle = FlatStyle.Flat;
		AF29BF2C.Location = new Point(252, -1);
		AF29BF2C.Name = "btnUp";
		AF29BF2C.Size = new Size(25, 25);
		AF29BF2C.TabIndex = 113;
		AF29BF2C.Click += AF29BF2C_Click;
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = Cursors.Hand;
		rbNganCachKyTu.Location = new Point(68, 182);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new Size(159, 20);
		rbNganCachKyTu.TabIndex = 111;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = Cursors.Hand;
		rbNganCachMoiDong.Location = new Point(68, 161);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new Size(155, 20);
		rbNganCachMoiDong.TabIndex = 110;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		label8.AutoSize = true;
		label8.Location = new Point(3, 161);
		label8.Name = "label8";
		label8.Size = new Size(64, 16);
		label8.TabIndex = 109;
		label8.Text = "Tùy chọn:";
		label12.AutoSize = true;
		label12.Location = new Point(3, 142);
		label12.Name = "label12";
		label12.Size = new Size(143, 16);
		label12.TabIndex = 107;
		label12.Text = "(Spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new Point(4, 4);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(139, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		plAnh.BorderStyle = BorderStyle.FixedSingle;
		plAnh.Controls.Add(txtAnh);
		plAnh.Controls.Add(label16);
		plAnh.Enabled = false;
		plAnh.Location = new Point(21, 223);
		plAnh.Name = "plAnh";
		plAnh.Size = new Size(281, 31);
		plAnh.TabIndex = 169;
		txtAnh.Location = new Point(136, 3);
		txtAnh.Name = "txtAnh";
		txtAnh.Size = new Size(140, 23);
		txtAnh.TabIndex = 155;
		label16.AutoSize = true;
		label16.Location = new Point(3, 6);
		label16.Name = "label16";
		label16.Size = new Size(137, 16);
		label16.TabIndex = 39;
		label16.Text = "Đường dẫn folder ảnh:";
		ckbSendAnh.AutoSize = true;
		ckbSendAnh.Cursor = Cursors.Hand;
		ckbSendAnh.Location = new Point(4, 199);
		ckbSendAnh.Name = "ckbSendAnh";
		ckbSendAnh.Size = new Size(103, 20);
		ckbSendAnh.TabIndex = 10;
		ckbSendAnh.Text = "Bình luận ảnh";
		ckbSendAnh.UseVisualStyleBackColor = true;
		ckbSendAnh.CheckedChanged += B6A63FA7;
		FE25EA9D.AutoSize = true;
		FE25EA9D.Cursor = Cursors.Hand;
		FE25EA9D.Location = new Point(4, 4);
		FE25EA9D.Name = "ckbCommentText";
		FE25EA9D.Size = new Size(127, 20);
		FE25EA9D.TabIndex = 9;
		FE25EA9D.Text = "Bình luận văn bản";
		FE25EA9D.UseVisualStyleBackColor = true;
		FE25EA9D.CheckedChanged += FE25EA9D_CheckedChanged;
		txtUid.BorderStyle = BorderStyle.FixedSingle;
		txtUid.Location = new Point(31, 186);
		txtUid.Name = "txtUid";
		txtUid.Size = new Size(299, 262);
		txtUid.TabIndex = 117;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += BD1EBB0E;
		label2.AutoSize = true;
		label2.Location = new Point(28, 451);
		label2.Name = "label2";
		label2.Size = new Size(102, 16);
		label2.TabIndex = 115;
		label2.Text = "(Mỗi Uid 1 dòng)";
		lblStatusUid.AutoSize = true;
		lblStatusUid.Location = new Point(27, 166);
		lblStatusUid.Name = "lblStatusUid";
		lblStatusUid.Size = new Size(228, 16);
		lblStatusUid.TabIndex = 116;
		lblStatusUid.Text = "Danh sa\u0301ch Uid page cần tương ta\u0301c (0):";
		label49.AutoSize = true;
		label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label49.Location = new Point(27, 81);
		label49.Name = "label49";
		label49.Size = new Size(95, 16);
		label49.TabIndex = 92;
		label49.Text = "Sô\u0301 lươ\u0323ng page:";
		AAA21F1A.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		AAA21F1A.Location = new Point(135, 79);
		AAA21F1A.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		AAA21F1A.Name = "nudSoLuongPageFrom";
		AAA21F1A.Size = new Size(56, 23);
		AAA21F1A.TabIndex = 1;
		AAA21F1A.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label68.AutoSize = true;
		label68.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label68.Location = new Point(290, 81);
		label68.Name = "label68";
		label68.Size = new Size(35, 16);
		label68.TabIndex = 99;
		label68.Text = "page";
		label19.AutoSize = true;
		label19.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label19.Location = new Point(27, 112);
		label19.Name = "label19";
		label19.Size = new Size(105, 16);
		label19.TabIndex = 101;
		label19.Text = "Sô\u0301 ba\u0300i viết/page:";
		E5107008.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		E5107008.Location = new Point(232, 79);
		E5107008.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		E5107008.Name = "nudSoLuongPageTo";
		E5107008.Size = new Size(56, 23);
		E5107008.TabIndex = 2;
		E5107008.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label66.Location = new Point(197, 81);
		label66.Name = "label66";
		label66.Size = new Size(29, 16);
		label66.TabIndex = 105;
		label66.Text = "đê\u0301n";
		label66.TextAlign = ContentAlignment.MiddleCenter;
		panel2.BorderStyle = BorderStyle.FixedSingle;
		panel2.Controls.Add(label9);
		panel2.Controls.Add(nudViewFrom);
		panel2.Controls.Add(label10);
		panel2.Controls.Add(label11);
		panel2.Controls.Add(nudViewTo);
		panel2.Location = new Point(369, 76);
		panel2.Name = "panel2";
		panel2.Size = new Size(281, 29);
		panel2.TabIndex = 10;
		label9.AutoSize = true;
		label9.Location = new Point(4, 5);
		label9.Name = "label9";
		label9.Size = new Size(93, 16);
		label9.TabIndex = 0;
		label9.Text = "Thơ\u0300i gian xem:";
		nudViewFrom.Location = new Point(101, 2);
		nudViewFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudViewFrom.Name = "nudViewFrom";
		nudViewFrom.Size = new Size(48, 23);
		nudViewFrom.TabIndex = 5;
		label10.AutoSize = true;
		label10.Location = new Point(241, 5);
		label10.Name = "label10";
		label10.Size = new Size(30, 16);
		label10.TabIndex = 36;
		label10.Text = "giây";
		label11.Location = new Point(155, 4);
		label11.Name = "label11";
		label11.Size = new Size(29, 16);
		label11.TabIndex = 38;
		label11.Text = "đê\u0301n";
		label11.TextAlign = ContentAlignment.MiddleCenter;
		nudViewTo.Location = new Point(190, 2);
		nudViewTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudViewTo.Name = "nudViewTo";
		nudViewTo.Size = new Size(48, 23);
		nudViewTo.TabIndex = 6;
		ckbComment.AutoSize = true;
		ckbComment.Cursor = Cursors.Hand;
		ckbComment.Location = new Point(351, 163);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new Size(175, 20);
		ckbComment.TabIndex = 9;
		ckbComment.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n ba\u0300i viê\u0301t";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += ckbComment_CheckedChanged;
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = Cursors.Hand;
		ckbShareWall.Location = new Point(351, 137);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new Size(167, 20);
		ckbShareWall.TabIndex = 8;
		ckbShareWall.Text = "Chia sẻ ba\u0300i viê\u0301t về tường";
		ckbShareWall.UseVisualStyleBackColor = true;
		ckbLikePage.AutoSize = true;
		ckbLikePage.Cursor = Cursors.Hand;
		ckbLikePage.Location = new Point(351, 454);
		ckbLikePage.Name = "ckbLikePage";
		ckbLikePage.Size = new Size(234, 20);
		ckbLikePage.TabIndex = 7;
		ckbLikePage.Text = "Like Fanpage sau khi tương ta\u0301c xong";
		ckbLikePage.UseVisualStyleBackColor = true;
		BD2F6021.AutoSize = true;
		BD2F6021.Cursor = Cursors.Hand;
		BD2F6021.Location = new Point(351, 50);
		BD2F6021.Name = "ckbAutoPlayVideo";
		BD2F6021.Size = new Size(285, 20);
		BD2F6021.TabIndex = 7;
		BD2F6021.Text = "Tư\u0323 đô\u0323ng xem Video (Nê\u0301u ba\u0300i viê\u0301t chư\u0301a video)";
		BD2F6021.UseVisualStyleBackColor = true;
		BD2F6021.CheckedChanged += BD2F6021_CheckedChanged;
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = Cursors.Hand;
		ckbInteract.Location = new Point(351, 111);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new Size(93, 20);
		ckbInteract.TabIndex = 7;
		ckbInteract.Text = "Like ba\u0300i viê\u0301t";
		ckbInteract.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new Point(232, 140);
		nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 6;
		nudSoLuongBaiVietTo.Location = new Point(232, 110);
		nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		nudSoLuongBaiVietTo.Size = new Size(56, 23);
		nudSoLuongBaiVietTo.TabIndex = 4;
		E89378BC.Location = new Point(135, 140);
		E89378BC.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		E89378BC.Name = "nudDelayFrom";
		E89378BC.Size = new Size(56, 23);
		E89378BC.TabIndex = 5;
		nudSoLuongBaiVietFrom.Location = new Point(135, 110);
		nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		nudSoLuongBaiVietFrom.Size = new Size(56, 23);
		nudSoLuongBaiVietFrom.TabIndex = 3;
		F09ECC3E.Location = new Point(135, 49);
		F09ECC3E.Name = "txtTenHanhDong";
		F09ECC3E.Size = new Size(195, 23);
		F09ECC3E.TabIndex = 0;
		label7.Location = new Point(197, 142);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label3.Location = new Point(197, 112);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		B42F9227.AutoSize = true;
		B42F9227.Location = new Point(290, 142);
		B42F9227.Name = "label6";
		B42F9227.Size = new Size(30, 16);
		B42F9227.TabIndex = 36;
		B42F9227.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new Point(290, 112);
		label4.Name = "label4";
		label4.Size = new Size(24, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0300i";
		label5.AutoSize = true;
		label5.Location = new Point(27, 142);
		label5.Name = "label5";
		label5.Size = new Size(89, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		C4011B1A.Anchor = AnchorStyles.Bottom;
		C4011B1A.BackColor = Color.Maroon;
		C4011B1A.Cursor = Cursors.Hand;
		C4011B1A.FlatAppearance.BorderSize = 0;
		C4011B1A.FlatStyle = FlatStyle.Flat;
		C4011B1A.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C4011B1A.ForeColor = Color.White;
		C4011B1A.Location = new Point(351, 489);
		C4011B1A.Name = "btnCancel";
		C4011B1A.Size = new Size(92, 29);
		C4011B1A.TabIndex = 12;
		C4011B1A.Text = "Đóng";
		C4011B1A.UseVisualStyleBackColor = false;
		C4011B1A.Click += C4011B1A_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(244, 489);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 11;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(E8A759A8);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(680, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(683, 533);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietFanpage";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += F6873C1C;
		E8A759A8.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		plComment.ResumeLayout(performLayout: false);
		plComment.PerformLayout();
		plCommentText.ResumeLayout(performLayout: false);
		plCommentText.PerformLayout();
		plAnh.ResumeLayout(performLayout: false);
		plAnh.PerformLayout();
		((ISupportInitialize)AAA21F1A).EndInit();
		((ISupportInitialize)E5107008).EndInit();
		panel2.ResumeLayout(performLayout: false);
		panel2.PerformLayout();
		((ISupportInitialize)nudViewFrom).EndInit();
		((ISupportInitialize)nudViewTo).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudSoLuongBaiVietTo).EndInit();
		((ISupportInitialize)E89378BC).EndInit();
		((ISupportInitialize)nudSoLuongBaiVietFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
