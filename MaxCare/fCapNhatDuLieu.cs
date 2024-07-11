using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCapNhatDuLieu : Form
{
	[CompilerGenerated]
	private sealed class Class74
	{
		public Label A8052F12;

		internal void E1A52F9A()
		{
			int num = Convert.ToInt32(A8052F12.Text);
			A8052F12.Text = (num + 1).ToString();
		}
	}

	[CompilerGenerated]
	private sealed class Class75
	{
		public fCapNhatDuLieu fCapNhatDuLieu_0;

		public string string_0;

		internal void method_0()
		{
			fCapNhatDuLieu_0.lblStatus.Text = string_0;
		}
	}

	public static bool bool_0;

	private List<ComboBox> FF8AFE22;

	private List<string> C9B69F8D = new List<string>();

	private List<string> list_0 = new List<string>();

	private List<string> list_1 = new List<string>();

	private IContainer DA3D5B23 = null;

	private Button btnAdd;

	private Button btnCancel;

	private Label label8;

	private ComboBox D1907FB8;

	private BunifuDragControl AD20AA31;

	private BunifuDragControl bunifuDragControl_0;

	private RichTextBox txbAccount;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel F33DFE94;

	private BunifuCards bunifuCards1;

	private ContextMenuStrip ctmsAcc;

	private ToolStripMenuItem C1A5E425;

	private ToolStripMenuItem B611003F;

	private ToolStripMenuItem CFAF5AA5;

	private ToolStripMenuItem A2A81E2E;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem CEA2251B;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem A9BE8DB9;

	private Label label3;

	private Label BA8F441D;

	private Label lblError;

	private Label lblTotal;

	private Label B682F490;

	private Label C18F7C34;

	private Label lblStatus;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private PictureBox pictureBox2;

	private Panel plDinhDangNhap;

	private Label E62C89B6;

	private ComboBox cbbDinhDang1;

	private ComboBox cbbDinhDang2;

	private ComboBox BD8B93A0;

	private ComboBox E0A9DCAD;

	private Label EB380899;

	private ComboBox CE0A4B11;

	private Label A0013691;

	private ComboBox E513122A;

	private Label label13;

	private ComboBox cbbDinhDang6;

	private Label label12;

	private ComboBox cbbDinhDang7;

	private Label E5216E34;

	private Label label9;

	private Label AD3B5BA9;

	private ComboBox cbbTypeProxy;

	private Label label2;

	private Label label5;

	private ComboBox cbbDinhDang9;

	private Label BB27FFA4;

	private ComboBox cbbDinhDang11;

	private Label label6;

	private ComboBox cbbDinhDang10;

	private Label label16;

	private ComboBox cbbDinhDang12;

	public fCapNhatDuLieu()
	{
		FC15CB17();
		D1907FB8.SelectedIndex = 0;
		FF8AFE22 = new List<ComboBox>
		{
			cbbDinhDang1, cbbDinhDang2, BD8B93A0, E0A9DCAD, CE0A4B11, cbbDinhDang6, cbbDinhDang7, E513122A, cbbDinhDang9, cbbDinhDang10,
			cbbDinhDang11, cbbDinhDang12
		};
		bool_0 = false;
		Language.SetLanguage(this);
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void EF8AA195(object sender, EventArgs e)
	{
		list_0 = new List<string>();
		list_1 = new List<string>();
		try
		{
			List<string> a2AB53A = txbAccount.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lòng nhâ\u0323p thông tin ta\u0300i khoa\u0309n!");
				txbAccount.Focus();
				return;
			}
			int selectedIndex = D1907FB8.SelectedIndex;
			if (selectedIndex == 7)
			{
				bool flag = false;
				for (int i = 0; i < FF8AFE22.Count; i++)
				{
					if (FF8AFE22[i].SelectedIndex > -1)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng ta\u0300i khoa\u0309n!");
					return;
				}
			}
			BA8F441D.Text = "0";
			lblError.Text = "0";
			C9B69F8D = new List<string>();
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			string text7 = "";
			string text8 = "";
			string text9 = "";
			string text10 = "";
			string text11 = "";
			string text12 = "";
			string text13 = "";
			string text14 = "";
			string text15 = "";
			for (int j = 0; j < a2AB53A.Count; j++)
			{
				text = "";
				text2 = "";
				text3 = "";
				text4 = "";
				text5 = "";
				text6 = "";
				text7 = "";
				text8 = "";
				text9 = "";
				text10 = "";
				text11 = "";
				text12 = "";
				text13 = "";
				text14 = "";
				text15 = "";
				try
				{
					string[] array = a2AB53A[j].Split('|');
					switch (selectedIndex)
					{
					case 0:
						text = array[0];
						text2 = array[1];
						break;
					case 1:
						text = array[0];
						text2 = array[1];
						text7 = array[2];
						break;
					case 2:
						text = array[0];
						text2 = array[1];
						text3 = array[2];
						text4 = array[3];
						break;
					case 3:
						text = array[0];
						text2 = array[1];
						text3 = array[2];
						text4 = array[3];
						text5 = array[4];
						text6 = array[5];
						break;
					case 4:
						text = array[0];
						text2 = array[1];
						text3 = array[2];
						text4 = array[3];
						text5 = array[4];
						text6 = array[5];
						text7 = array[6];
						break;
					case 5:
						text5 = array[0];
						text6 = array[1];
						break;
					case 6:
						text5 = array[0];
						text6 = array[1];
						text13 = array[2];
						break;
					case 7:
					{
						text = array[0];
						for (int k = 1; k < FF8AFE22.Count; k++)
						{
							switch (FF8AFE22[k - 1].SelectedIndex)
							{
							case 0:
								text = array[k];
								break;
							case 1:
								text2 = array[k];
								break;
							case 2:
								text3 = array[k];
								break;
							case 3:
								text4 = array[k];
								break;
							case 4:
								text5 = array[k];
								break;
							case 5:
								text6 = array[k];
								break;
							case 6:
								text7 = array[k];
								break;
							case 7:
								text8 = array[k];
								break;
							case 8:
								text9 = ((array[k] == "") ? "" : (array[k] + "*" + cbbTypeProxy.SelectedIndex));
								break;
							case 9:
								text10 = array[k];
								break;
							case 10:
								text11 = array[k];
								break;
							case 11:
								text12 = array[k];
								break;
							case 12:
								text13 = array[k];
								break;
							case 13:
								text14 = array[k];
								break;
							case 14:
								text15 = array[k];
								break;
							}
						}
						break;
					}
					}
					C9B69F8D.Add(text + "|" + text2 + "|" + text3 + "|" + text4 + "|" + text5 + "|" + text6 + "|" + text7 + "|" + text8 + "|" + text9 + "|" + text10 + "|" + text11 + "|" + text12 + "|" + text13 + "|" + text14 + "|" + text15);
					list_0.Add(a2AB53A[j]);
				}
				catch
				{
					method_0(lblError);
					list_1.Add(a2AB53A[j]);
				}
			}
			btnAdd.Invoke((MethodInvoker)delegate
			{
				btnAdd.Enabled = false;
			});
			AF272183(Language.GetValue("Đang cập nhật dữ liệu..."));
			if (selectedIndex == 5 || selectedIndex == 6)
			{
				for (int l = 0; l < C9B69F8D.Count; l++)
				{
					if (CommonSQL.smethod_17(C9B69F8D[l]))
					{
						method_0(BA8F441D);
					}
					else
					{
						method_0(lblError);
					}
				}
			}
			else
			{
				for (int m = 0; m < C9B69F8D.Count; m++)
				{
					if (CommonSQL.smethod_16(C9B69F8D[m]))
					{
						method_0(BA8F441D);
					}
					else
					{
						method_0(lblError);
					}
				}
			}
			btnAdd.Invoke((MethodInvoker)delegate
			{
				btnAdd.Enabled = true;
			});
			list_0.AddRange(list_1);
			txbAccount.Lines = list_0.ToArray();
			AF272183(Language.GetValue("Cập nhật dữ liệu xong!"));
			MessageBoxHelper.Show("Cập nhật dữ liệu xong!");
			bool_0 = true;
		}
		catch (Exception exception_)
		{
			MessageBoxHelper.Show("Đa\u0303 co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!");
			Common.ExportError2(exception_, "UpdateAccount");
		}
	}

	private void AF272183(string CA378F31)
	{
		Application.DoEvents();
		lblStatus.Invoke((MethodInvoker)delegate
		{
			lblStatus.Text = CA378F31;
		});
	}

	private void txbAccount_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txbAccount.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblTotal.Text = a2AB53A.Count.ToString();
		}
		catch
		{
		}
	}

	private void method_0(Label label_0)
	{
		Application.DoEvents();
		lock (label_0)
		{
			label_0.Invoke((MethodInvoker)delegate
			{
				int num = Convert.ToInt32(label_0.Text);
				label_0.Text = (num + 1).ToString();
			});
		}
	}

	private void D1907FB8_SelectedIndexChanged(object sender, EventArgs e)
	{
		plDinhDangNhap.Visible = D1907FB8.SelectedIndex == D1907FB8.Items.Count - 1;
	}

	private bool EC069EA2()
	{
		bool result = false;
		List<int> list = new List<int>();
		int num = 0;
		for (int i = 0; i <= 6; i++)
		{
			num = FF8AFE22[i].SelectedIndex;
			if (num != -1)
			{
				if (list.Contains(num))
				{
					result = true;
					break;
				}
				list.Add(num);
			}
		}
		return result;
	}

	private void DD9BA1B8(object sender, EventArgs e)
	{
		Close();
	}

	private void E99A6DBB(object sender, EventArgs e)
	{
		bool visible = false;
		for (int i = 0; i < FF8AFE22.Count; i++)
		{
			if (FF8AFE22[i].Text == "Proxy")
			{
				visible = true;
				break;
			}
		}
		label2.Visible = visible;
		cbbTypeProxy.Visible = visible;
	}

	private void A08F0AB0(object sender, EventArgs e)
	{
		foreach (ComboBox item in FF8AFE22)
		{
			Common.F714B10E(item, new List<string>
			{
				"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
				"Bạn bè", "Ngày tạo", "Mail khôi phục", "Ghi chú", "Tương tác cuối"
			});
			item.SelectedIndex = -1;
			item.DropDownWidth = 100;
		}
		cbbTypeProxy.SelectedIndex = 0;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && DA3D5B23 != null)
		{
			DA3D5B23.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void FC15CB17()
	{
		DA3D5B23 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fCapNhatDuLieu));
		btnAdd = new Button();
		btnCancel = new Button();
		label8 = new Label();
		D1907FB8 = new ComboBox();
		AD20AA31 = new BunifuDragControl(DA3D5B23);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(DA3D5B23);
		F33DFE94 = new Panel();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		btnMinimize = new Button();
		txbAccount = new RichTextBox();
		bunifuCards1 = new BunifuCards();
		ctmsAcc = new ContextMenuStrip(DA3D5B23);
		C1A5E425 = new ToolStripMenuItem();
		B611003F = new ToolStripMenuItem();
		CFAF5AA5 = new ToolStripMenuItem();
		A2A81E2E = new ToolStripMenuItem();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		CEA2251B = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		toolStripMenuItem_2 = new ToolStripMenuItem();
		A9BE8DB9 = new ToolStripMenuItem();
		label3 = new Label();
		BA8F441D = new Label();
		lblError = new Label();
		lblTotal = new Label();
		B682F490 = new Label();
		C18F7C34 = new Label();
		lblStatus = new Label();
		plDinhDangNhap = new Panel();
		label16 = new Label();
		BB27FFA4 = new Label();
		label5 = new Label();
		cbbDinhDang12 = new ComboBox();
		cbbDinhDang11 = new ComboBox();
		cbbDinhDang9 = new ComboBox();
		cbbTypeProxy = new ComboBox();
		label2 = new Label();
		E62C89B6 = new Label();
		cbbDinhDang1 = new ComboBox();
		cbbDinhDang2 = new ComboBox();
		BD8B93A0 = new ComboBox();
		E0A9DCAD = new ComboBox();
		EB380899 = new Label();
		CE0A4B11 = new ComboBox();
		label6 = new Label();
		A0013691 = new Label();
		cbbDinhDang10 = new ComboBox();
		E513122A = new ComboBox();
		label13 = new Label();
		cbbDinhDang6 = new ComboBox();
		label12 = new Label();
		cbbDinhDang7 = new ComboBox();
		E5216E34 = new Label();
		label9 = new Label();
		AD3B5BA9 = new Label();
		F33DFE94.SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		bunifuCards1.SuspendLayout();
		ctmsAcc.SuspendLayout();
		plDinhDangNhap.SuspendLayout();
		SuspendLayout();
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(482, 460);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(97, 31);
		btnAdd.TabIndex = 13;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += EF8AA195;
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(599, 460);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(97, 31);
		btnCancel.TabIndex = 14;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		label8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label8.Location = new Point(9, 367);
		label8.Name = "label8";
		label8.Size = new Size(97, 14);
		label8.TabIndex = 39;
		label8.Text = "Chọn định dạng:";
		label8.TextAlign = ContentAlignment.MiddleRight;
		D1907FB8.Cursor = Cursors.Hand;
		D1907FB8.DropDownStyle = ComboBoxStyle.DropDownList;
		D1907FB8.FormattingEnabled = true;
		D1907FB8.Items.AddRange(new object[8] { "Uid|Pass", "Uid|Pass|2FA", "Uid|Pass|Token|Cookie", "Uid|Pass|Token|Cookie|Email|Pass Email", "Uid|Pass|Token|Cookie|Email|Pass Email|2FA", "Email|Pass mail", "Email|Pass mail|Mail khôi phục", "Other..." });
		D1907FB8.Location = new Point(112, 364);
		D1907FB8.Name = "cbbDinhDangNhap";
		D1907FB8.Size = new Size(269, 24);
		D1907FB8.TabIndex = 40;
		D1907FB8.SelectedIndexChanged += D1907FB8_SelectedIndexChanged;
		AD20AA31.Fixed = true;
		AD20AA31.Horizontal = true;
		AD20AA31.TargetControl = bunifuCustomLabel1;
		AD20AA31.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(1179, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = F33DFE94;
		bunifuDragControl_0.Vertical = true;
		F33DFE94.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		F33DFE94.BackColor = Color.White;
		F33DFE94.Controls.Add(pictureBox2);
		F33DFE94.Controls.Add(pictureBox1);
		F33DFE94.Controls.Add(btnMinimize);
		F33DFE94.Controls.Add(bunifuCustomLabel1);
		F33DFE94.Cursor = Cursors.SizeAll;
		F33DFE94.Location = new Point(0, 3);
		F33DFE94.Name = "pnlHeader";
		F33DFE94.Size = new Size(1179, 31);
		F33DFE94.TabIndex = 9;
		pictureBox2.Cursor = Cursors.Default;
		pictureBox2.Image = Resources.Bitmap_4;
		pictureBox2.Location = new Point(2, 3);
		pictureBox2.Name = "pictureBox2";
		pictureBox2.Size = new Size(34, 27);
		pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox2.TabIndex = 79;
		pictureBox2.TabStop = false;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		pictureBox1.Location = new Point(-156, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 78;
		pictureBox1.TabStop = false;
		btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		btnMinimize.Location = new Point(1147, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(30, 30);
		btnMinimize.TabIndex = 77;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += DD9BA1B8;
		txbAccount.BorderStyle = BorderStyle.FixedSingle;
		txbAccount.Location = new Point(12, 77);
		txbAccount.Name = "txbAccount";
		txbAccount.Size = new Size(1147, 277);
		txbAccount.TabIndex = 48;
		txbAccount.Text = "";
		txbAccount.WordWrap = false;
		txbAccount.TextChanged += txbAccount_TextChanged;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(F33DFE94);
		bunifuCards1.Dock = DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(1179, 37);
		bunifuCards1.TabIndex = 49;
		ctmsAcc.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ctmsAcc.Items.AddRange(new ToolStripItem[5] { C1A5E425, CEA2251B, toolStripMenuItem_1, toolStripMenuItem_2, A9BE8DB9 });
		ctmsAcc.Name = "ctmsAcc";
		ctmsAcc.Size = new Size(179, 114);
		C1A5E425.DropDownItems.AddRange(new ToolStripItem[4] { B611003F, CFAF5AA5, A2A81E2E, toolStripMenuItem_0 });
		C1A5E425.Name = "chọnToolStripMenuItem1";
		C1A5E425.Size = new Size(178, 22);
		C1A5E425.Text = "Chọn";
		B611003F.Name = "tấtCảToolStripMenuItem1";
		B611003F.Size = new Size(143, 22);
		B611003F.Text = "Tất cả";
		CFAF5AA5.Name = "bôiĐenToolStripMenuItem1";
		CFAF5AA5.Size = new Size(143, 22);
		CFAF5AA5.Text = "Bôi đen";
		A2A81E2E.Name = "tàiKhoản0ToolStripMenuItem";
		A2A81E2E.Size = new Size(143, 22);
		A2A81E2E.Text = "Tài khoản=0";
		toolStripMenuItem_0.Name = "tàiKhoản1ToolStripMenuItem";
		toolStripMenuItem_0.Size = new Size(143, 22);
		toolStripMenuItem_0.Text = "Tài khoản=1";
		CEA2251B.Name = "toolStripMenuItem2";
		CEA2251B.Size = new Size(178, 22);
		CEA2251B.Text = "Bỏ chọn tất cả";
		toolStripMenuItem_1.Name = "tạoThiếtBịToolStripMenuItem";
		toolStripMenuItem_1.Size = new Size(178, 22);
		toolStripMenuItem_1.Text = "Tạo thiết bị";
		toolStripMenuItem_2.Name = "xóaThiếtBịToolStripMenuItem";
		toolStripMenuItem_2.Size = new Size(178, 22);
		toolStripMenuItem_2.Text = "Xóa thiết bị";
		A9BE8DB9.Name = "loadDanhSachThiêtBiToolStripMenuItem1";
		A9BE8DB9.Size = new Size(178, 22);
		A9BE8DB9.Text = "Làm mới danh sa\u0301ch";
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		label3.Location = new Point(698, 58);
		label3.Name = "label3";
		label3.Size = new Size(87, 16);
		label3.TabIndex = 55;
		label3.Text = "Tha\u0300nh công:";
		label3.TextAlign = ContentAlignment.MiddleRight;
		BA8F441D.AutoSize = true;
		BA8F441D.BackColor = SystemColors.Control;
		BA8F441D.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		BA8F441D.ForeColor = Color.FromArgb(53, 120, 229);
		BA8F441D.Location = new Point(781, 55);
		BA8F441D.Name = "lblSuccess";
		BA8F441D.Size = new Size(19, 19);
		BA8F441D.TabIndex = 50;
		BA8F441D.Text = "0";
		lblError.AutoSize = true;
		lblError.BackColor = SystemColors.Control;
		lblError.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		lblError.ForeColor = Color.FromArgb(192, 64, 0);
		lblError.Location = new Point(904, 55);
		lblError.Name = "lblError";
		lblError.Size = new Size(19, 19);
		lblError.TabIndex = 51;
		lblError.Text = "0";
		lblTotal.AutoSize = true;
		lblTotal.BackColor = SystemColors.Control;
		lblTotal.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		lblTotal.ForeColor = Color.Teal;
		lblTotal.Location = new Point(1064, 56);
		lblTotal.Name = "lblTotal";
		lblTotal.Size = new Size(19, 19);
		lblTotal.TabIndex = 53;
		lblTotal.Text = "0";
		B682F490.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		B682F490.Location = new Point(855, 58);
		B682F490.Name = "label4";
		B682F490.Size = new Size(52, 16);
		B682F490.TabIndex = 56;
		B682F490.Text = "Lỗi:";
		B682F490.TextAlign = ContentAlignment.MiddleRight;
		C18F7C34.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		C18F7C34.Location = new Point(1004, 58);
		C18F7C34.Name = "label7";
		C18F7C34.Size = new Size(63, 16);
		C18F7C34.TabIndex = 59;
		C18F7C34.Text = "Tô\u0309ng sô\u0301:";
		C18F7C34.TextAlign = ContentAlignment.MiddleRight;
		lblStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		lblStatus.ForeColor = Color.DarkGreen;
		lblStatus.Location = new Point(12, 44);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(227, 28);
		lblStatus.TabIndex = 60;
		lblStatus.Text = "Nhập thông tin tài khoản:";
		lblStatus.TextAlign = ContentAlignment.MiddleCenter;
		plDinhDangNhap.Controls.Add(label16);
		plDinhDangNhap.Controls.Add(BB27FFA4);
		plDinhDangNhap.Controls.Add(label5);
		plDinhDangNhap.Controls.Add(cbbDinhDang12);
		plDinhDangNhap.Controls.Add(cbbDinhDang11);
		plDinhDangNhap.Controls.Add(cbbDinhDang9);
		plDinhDangNhap.Controls.Add(cbbTypeProxy);
		plDinhDangNhap.Controls.Add(label2);
		plDinhDangNhap.Controls.Add(E62C89B6);
		plDinhDangNhap.Controls.Add(cbbDinhDang1);
		plDinhDangNhap.Controls.Add(cbbDinhDang2);
		plDinhDangNhap.Controls.Add(BD8B93A0);
		plDinhDangNhap.Controls.Add(E0A9DCAD);
		plDinhDangNhap.Controls.Add(EB380899);
		plDinhDangNhap.Controls.Add(CE0A4B11);
		plDinhDangNhap.Controls.Add(label6);
		plDinhDangNhap.Controls.Add(A0013691);
		plDinhDangNhap.Controls.Add(cbbDinhDang10);
		plDinhDangNhap.Controls.Add(E513122A);
		plDinhDangNhap.Controls.Add(label13);
		plDinhDangNhap.Controls.Add(cbbDinhDang6);
		plDinhDangNhap.Controls.Add(label12);
		plDinhDangNhap.Controls.Add(cbbDinhDang7);
		plDinhDangNhap.Controls.Add(E5216E34);
		plDinhDangNhap.Controls.Add(label9);
		plDinhDangNhap.Controls.Add(AD3B5BA9);
		plDinhDangNhap.Location = new Point(12, 392);
		plDinhDangNhap.Name = "plDinhDangNhap";
		plDinhDangNhap.Size = new Size(1157, 62);
		plDinhDangNhap.TabIndex = 61;
		label16.AutoSize = true;
		label16.Font = new Font("Tahoma", 12f);
		label16.Location = new Point(1057, 7);
		label16.Name = "label16";
		label16.Size = new Size(15, 19);
		label16.TabIndex = 128;
		label16.Text = "|";
		BB27FFA4.AutoSize = true;
		BB27FFA4.Font = new Font("Tahoma", 12f);
		BB27FFA4.Location = new Point(961, 6);
		BB27FFA4.Name = "label15";
		BB27FFA4.Size = new Size(15, 19);
		BB27FFA4.TabIndex = 128;
		BB27FFA4.Text = "|";
		label5.AutoSize = true;
		label5.Font = new Font("Tahoma", 12f);
		label5.Location = new Point(774, 4);
		label5.Name = "label5";
		label5.Size = new Size(15, 19);
		label5.TabIndex = 128;
		label5.Text = "|";
		cbbDinhDang12.Cursor = Cursors.Hand;
		cbbDinhDang12.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang12.FormattingEnabled = true;
		cbbDinhDang12.Location = new Point(1072, 7);
		cbbDinhDang12.Name = "cbbDinhDang12";
		cbbDinhDang12.Size = new Size(78, 24);
		cbbDinhDang12.TabIndex = 127;
		cbbDinhDang11.Cursor = Cursors.Hand;
		cbbDinhDang11.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang11.FormattingEnabled = true;
		cbbDinhDang11.Location = new Point(976, 6);
		cbbDinhDang11.Name = "cbbDinhDang11";
		cbbDinhDang11.Size = new Size(78, 24);
		cbbDinhDang11.TabIndex = 127;
		cbbDinhDang9.Cursor = Cursors.Hand;
		cbbDinhDang9.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang9.FormattingEnabled = true;
		cbbDinhDang9.Location = new Point(789, 4);
		cbbDinhDang9.Name = "cbbDinhDang9";
		cbbDinhDang9.Size = new Size(78, 24);
		cbbDinhDang9.TabIndex = 127;
		cbbTypeProxy.Cursor = Cursors.Hand;
		cbbTypeProxy.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTypeProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbbTypeProxy.FormattingEnabled = true;
		cbbTypeProxy.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		cbbTypeProxy.Location = new Point(85, 33);
		cbbTypeProxy.Name = "cbbTypeProxy";
		cbbTypeProxy.Size = new Size(130, 24);
		cbbTypeProxy.TabIndex = 126;
		cbbTypeProxy.Visible = false;
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(7, 36);
		label2.Name = "label2";
		label2.Size = new Size(70, 16);
		label2.TabIndex = 125;
		label2.Text = "Loại proxy:";
		label2.Visible = false;
		E62C89B6.AutoSize = true;
		E62C89B6.Font = new Font("Tahoma", 12f);
		E62C89B6.Location = new Point(5, 3);
		E62C89B6.Name = "label1";
		E62C89B6.Size = new Size(39, 19);
		E62C89B6.TabIndex = 42;
		E62C89B6.Text = "Uid|";
		cbbDinhDang1.Cursor = Cursors.Hand;
		cbbDinhDang1.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang1.FormattingEnabled = true;
		cbbDinhDang1.Location = new Point(44, 3);
		cbbDinhDang1.Name = "cbbDinhDang1";
		cbbDinhDang1.Size = new Size(78, 24);
		cbbDinhDang1.TabIndex = 40;
		cbbDinhDang1.SelectedIndexChanged += E99A6DBB;
		cbbDinhDang2.Cursor = Cursors.Hand;
		cbbDinhDang2.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang2.FormattingEnabled = true;
		cbbDinhDang2.Location = new Point(137, 3);
		cbbDinhDang2.Name = "cbbDinhDang2";
		cbbDinhDang2.Size = new Size(78, 24);
		cbbDinhDang2.TabIndex = 40;
		cbbDinhDang2.SelectedIndexChanged += E99A6DBB;
		BD8B93A0.Cursor = Cursors.Hand;
		BD8B93A0.DropDownStyle = ComboBoxStyle.DropDownList;
		BD8B93A0.FormattingEnabled = true;
		BD8B93A0.Location = new Point(230, 3);
		BD8B93A0.Name = "cbbDinhDang3";
		BD8B93A0.Size = new Size(78, 24);
		BD8B93A0.TabIndex = 40;
		BD8B93A0.SelectedIndexChanged += E99A6DBB;
		E0A9DCAD.Cursor = Cursors.Hand;
		E0A9DCAD.DropDownStyle = ComboBoxStyle.DropDownList;
		E0A9DCAD.FormattingEnabled = true;
		E0A9DCAD.Location = new Point(323, 3);
		E0A9DCAD.Name = "cbbDinhDang4";
		E0A9DCAD.Size = new Size(78, 24);
		E0A9DCAD.TabIndex = 40;
		E0A9DCAD.SelectedIndexChanged += E99A6DBB;
		EB380899.AutoSize = true;
		EB380899.Font = new Font("Tahoma", 12f);
		EB380899.Location = new Point(587, 3);
		EB380899.Name = "label14";
		EB380899.Size = new Size(15, 19);
		EB380899.TabIndex = 41;
		EB380899.Text = "|";
		CE0A4B11.Cursor = Cursors.Hand;
		CE0A4B11.DropDownStyle = ComboBoxStyle.DropDownList;
		CE0A4B11.FormattingEnabled = true;
		CE0A4B11.Location = new Point(416, 3);
		CE0A4B11.Name = "cbbDinhDang5";
		CE0A4B11.Size = new Size(78, 24);
		CE0A4B11.TabIndex = 40;
		CE0A4B11.SelectedIndexChanged += E99A6DBB;
		label6.AutoSize = true;
		label6.Font = new Font("Tahoma", 12f);
		label6.Location = new Point(867, 5);
		label6.Name = "label6";
		label6.Size = new Size(15, 19);
		label6.TabIndex = 41;
		label6.Text = "|";
		A0013691.AutoSize = true;
		A0013691.Font = new Font("Tahoma", 12f);
		A0013691.Location = new Point(680, 3);
		A0013691.Name = "label17";
		A0013691.Size = new Size(15, 19);
		A0013691.TabIndex = 41;
		A0013691.Text = "|";
		cbbDinhDang10.Cursor = Cursors.Hand;
		cbbDinhDang10.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang10.FormattingEnabled = true;
		cbbDinhDang10.Location = new Point(882, 5);
		cbbDinhDang10.Name = "cbbDinhDang10";
		cbbDinhDang10.Size = new Size(78, 24);
		cbbDinhDang10.TabIndex = 40;
		cbbDinhDang10.SelectedIndexChanged += E99A6DBB;
		E513122A.Cursor = Cursors.Hand;
		E513122A.DropDownStyle = ComboBoxStyle.DropDownList;
		E513122A.FormattingEnabled = true;
		E513122A.Location = new Point(695, 3);
		E513122A.Name = "cbbDinhDang8";
		E513122A.Size = new Size(78, 24);
		E513122A.TabIndex = 40;
		E513122A.SelectedIndexChanged += E99A6DBB;
		label13.AutoSize = true;
		label13.Font = new Font("Tahoma", 12f);
		label13.Location = new Point(494, 3);
		label13.Name = "label13";
		label13.Size = new Size(15, 19);
		label13.TabIndex = 41;
		label13.Text = "|";
		cbbDinhDang6.Cursor = Cursors.Hand;
		cbbDinhDang6.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang6.FormattingEnabled = true;
		cbbDinhDang6.Location = new Point(509, 3);
		cbbDinhDang6.Name = "cbbDinhDang6";
		cbbDinhDang6.Size = new Size(78, 24);
		cbbDinhDang6.TabIndex = 40;
		cbbDinhDang6.SelectedIndexChanged += E99A6DBB;
		label12.AutoSize = true;
		label12.Font = new Font("Tahoma", 12f);
		label12.Location = new Point(401, 3);
		label12.Name = "label12";
		label12.Size = new Size(15, 19);
		label12.TabIndex = 41;
		label12.Text = "|";
		cbbDinhDang7.Cursor = Cursors.Hand;
		cbbDinhDang7.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang7.FormattingEnabled = true;
		cbbDinhDang7.Location = new Point(602, 3);
		cbbDinhDang7.Name = "cbbDinhDang7";
		cbbDinhDang7.Size = new Size(78, 24);
		cbbDinhDang7.TabIndex = 40;
		cbbDinhDang7.SelectedIndexChanged += E99A6DBB;
		E5216E34.AutoSize = true;
		E5216E34.Font = new Font("Tahoma", 12f);
		E5216E34.Location = new Point(308, 3);
		E5216E34.Name = "label11";
		E5216E34.Size = new Size(15, 19);
		E5216E34.TabIndex = 41;
		E5216E34.Text = "|";
		label9.AutoSize = true;
		label9.Font = new Font("Tahoma", 12f);
		label9.Location = new Point(122, 3);
		label9.Name = "label9";
		label9.Size = new Size(15, 19);
		label9.TabIndex = 41;
		label9.Text = "|";
		AD3B5BA9.AutoSize = true;
		AD3B5BA9.Font = new Font("Tahoma", 12f);
		AD3B5BA9.Location = new Point(215, 3);
		AD3B5BA9.Name = "label10";
		AD3B5BA9.Size = new Size(15, 19);
		AD3B5BA9.TabIndex = 41;
		AD3B5BA9.Text = "|";
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(1179, 502);
		base.Controls.Add(plDinhDangNhap);
		base.Controls.Add(lblStatus);
		base.Controls.Add(label3);
		base.Controls.Add(BA8F441D);
		base.Controls.Add(lblError);
		base.Controls.Add(lblTotal);
		base.Controls.Add(B682F490);
		base.Controls.Add(C18F7C34);
		base.Controls.Add(btnAdd);
		base.Controls.Add(btnCancel);
		base.Controls.Add(txbAccount);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(D1907FB8);
		base.Controls.Add(label8);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fCapNhatDuLieu";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Nhập tài khoản";
		base.Load += A08F0AB0;
		F33DFE94.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ctmsAcc.ResumeLayout(performLayout: false);
		plDinhDangNhap.ResumeLayout(performLayout: false);
		plDinhDangNhap.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void AB2DF2A1()
	{
		btnAdd.Enabled = false;
	}

	[CompilerGenerated]
	private void method_1()
	{
		btnAdd.Enabled = true;
	}
}
