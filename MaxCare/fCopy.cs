using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCopy : Form
{
	private List<ComboBox> C788BC28;

	private List<string> list_0 = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel F68CA02B;

	private Button EDA227A7;

	private Button btnCancel;

	private Button btnAdd;

	private Label label1;

	private BunifuDragControl bunifuDragControl_0;

	private ComboBox BBA91921;

	private ComboBox cbbDinhDang2;

	private ComboBox CF997426;

	private ComboBox cbbDinhDang4;

	private Label label14;

	private ComboBox DE29BFBF;

	private Label label13;

	private ComboBox cbbDinhDang6;

	private Label label12;

	private ComboBox cbbDinhDang7;

	private Label F83A1B2C;

	private Label label9;

	private Label label10;

	private ComboBox CB0E8F98;

	private ComboBox B5306FB8;

	private Label label2;

	private Label DCADCE2C;

	private Button button1;

	private ComboBox cbbDinhDang10;

	private Label label4;

	public fCopy(List<string> list_1)
	{
		InitializeComponent();
		list_0 = list_1;
		Language.SetLanguage(this);
		C788BC28 = new List<ComboBox> { BBA91921, cbbDinhDang2, CF997426, cbbDinhDang4, DE29BFBF, cbbDinhDang6, cbbDinhDang7, B5306FB8, CB0E8F98, cbbDinhDang10 };
	}

	private void EDA227A7_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A5B0130D()
	{
		try
		{
			string text = "";
			for (int i = 0; i < C788BC28.Count; i++)
			{
				text = text + C788BC28[i].SelectedIndex + "|";
			}
			text = text.TrimEnd('|');
			SettingsTool.GetSettings("configFormat").GetJson("copyFormat", text);
			SettingsTool.GetSettings("configFormat").method_7();
		}
		catch
		{
		}
	}

	private void D211E02F()
	{
		try
		{
			string text = SettingsTool.GetSettings("configFormat").GetValue("copyFormat");
			if (text != "")
			{
				for (int i = 0; i < C788BC28.Count; i++)
				{
					C788BC28[i].SelectedIndex = Convert.ToInt32(text.Split('|')[i]);
				}
			}
		}
		catch
		{
		}
	}

	private void method_0()
	{
		try
		{
			for (int i = 0; i < C788BC28.Count; i++)
			{
				C788BC28[i].SelectedIndex = -1;
			}
		}
		catch
		{
		}
	}

	private void C31288A6(object sender, EventArgs e)
	{
		try
		{
			if (!Base.smethod_3())
			{
				return;
			}
			List<string> list = new List<string>();
			string text = "";
			int num = 0;
			int num2 = C788BC28.Count - 1;
			while (num2 >= 0)
			{
				if (C788BC28[num2].SelectedIndex == -1)
				{
					num2--;
					continue;
				}
				num = num2 + 1;
				break;
			}
			if (num == 0)
			{
				MessageBoxHelper.Show("vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng câ\u0300n copy!", 3);
				return;
			}
			A5B0130D();
			int num3 = 0;
			for (int i = 0; i < list_0.Count; i++)
			{
				text = "";
				string[] array = list_0[i].Split('|');
				for (int j = 0; j < C788BC28.Count; j++)
				{
					if (C788BC28[j].SelectedIndex > 0)
					{
						text += array[C788BC28[j].SelectedIndex - 1];
					}
					text += "|";
				}
				text = text.TrimEnd('|');
				for (num3 = text.Split('|').Count(); num3 < num; num3++)
				{
					text += "|";
				}
				list.Add(text);
			}
			string string_ = string.Join("\r\n", list);
			Common.SetTextToClipboard(string_);
			MessageBoxHelper.Show("Copy tha\u0300nh công!");
			Close();
		}
		catch (Exception ex)
		{
			Common.ExportError2(null, ex.ToString());
			MessageBoxHelper.Show("Có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B2810125(object sender, EventArgs e)
	{
		method_0();
	}

	private void fCopy_Load(object sender, EventArgs e)
	{
		foreach (ComboBox item in C788BC28)
		{
			Common.F714B10E(item, new List<string>
			{
				"", "Uid", "Pass", "Token", "Cookie", "Email", "Email full", "Pass Email", "2FA", "Useragent",
				"Proxy", "Tên", "Giới tính", "Theo dõi", "Bạn bè", "Nhóm", "Ngày sinh", "Ngày tạo", "Ghi chú", "Location",
				"Mail khôi phục", "Tương tác cuối", "Dating", "Ads", "BM"
			});
			item.SelectedIndex = -1;
			item.DropDownWidth = 100;
		}
		D211E02F();
	}

	protected override void Dispose(bool BE2C26AD)
	{
		if (BE2C26AD && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(BE2C26AD);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCopy));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.EDA227A7 = new System.Windows.Forms.Button();
		this.F68CA02B = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.BBA91921 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang2 = new System.Windows.Forms.ComboBox();
		this.CF997426 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang4 = new System.Windows.Forms.ComboBox();
		this.label14 = new System.Windows.Forms.Label();
		this.DE29BFBF = new System.Windows.Forms.ComboBox();
		this.label13 = new System.Windows.Forms.Label();
		this.cbbDinhDang6 = new System.Windows.Forms.ComboBox();
		this.label12 = new System.Windows.Forms.Label();
		this.cbbDinhDang7 = new System.Windows.Forms.ComboBox();
		this.F83A1B2C = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.CB0E8F98 = new System.Windows.Forms.ComboBox();
		this.B5306FB8 = new System.Windows.Forms.ComboBox();
		this.label2 = new System.Windows.Forms.Label();
		this.DCADCE2C = new System.Windows.Forms.Label();
		this.button1 = new System.Windows.Forms.Button();
		this.cbbDinhDang10 = new System.Windows.Forms.ComboBox();
		this.label4 = new System.Windows.Forms.Label();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(1122, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.EDA227A7);
		this.pnlHeader.Controls.Add(this.F68CA02B);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1122, 32);
		this.pnlHeader.TabIndex = 9;
		this.EDA227A7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EDA227A7.Dock = System.Windows.Forms.DockStyle.Right;
		this.EDA227A7.FlatAppearance.BorderSize = 0;
		this.EDA227A7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.EDA227A7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EDA227A7.ForeColor = System.Drawing.Color.White;
		this.EDA227A7.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.EDA227A7.Location = new System.Drawing.Point(1090, 0);
		this.EDA227A7.Name = "btnMinimize";
		this.EDA227A7.Size = new System.Drawing.Size(32, 32);
		this.EDA227A7.TabIndex = 9;
		this.EDA227A7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.EDA227A7.UseVisualStyleBackColor = true;
		this.EDA227A7.Click += new System.EventHandler(EDA227A7_Click);
		this.F68CA02B.BackColor = System.Drawing.Color.Transparent;
		this.F68CA02B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.F68CA02B.Dock = System.Windows.Forms.DockStyle.Fill;
		this.F68CA02B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F68CA02B.ForeColor = System.Drawing.Color.Black;
		this.F68CA02B.Location = new System.Drawing.Point(0, 0);
		this.F68CA02B.Name = "bunifuCustomLabel1";
		this.F68CA02B.Size = new System.Drawing.Size(1122, 32);
		this.F68CA02B.TabIndex = 1;
		this.F68CA02B.Text = "Tu\u0300y cho\u0323n đi\u0323nh da\u0323ng sao che\u0301p";
		this.F68CA02B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(622, 124);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(514, 124);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Xa\u0301c nhâ\u0323n";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(C31288A6);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label1.Location = new System.Drawing.Point(20, 66);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(131, 16);
		this.label1.TabIndex = 20;
		this.label1.Text = "Cho\u0323n đi\u0323nh da\u0323ng copy:";
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.F68CA02B;
		this.bunifuDragControl_0.Vertical = true;
		this.BBA91921.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BBA91921.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.BBA91921.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BBA91921.FormattingEnabled = true;
		this.BBA91921.Location = new System.Drawing.Point(158, 65);
		this.BBA91921.Name = "cbbDinhDang1";
		this.BBA91921.Size = new System.Drawing.Size(78, 24);
		this.BBA91921.TabIndex = 42;
		this.cbbDinhDang2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang2.FormattingEnabled = true;
		this.cbbDinhDang2.Location = new System.Drawing.Point(255, 65);
		this.cbbDinhDang2.Name = "cbbDinhDang2";
		this.cbbDinhDang2.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang2.TabIndex = 43;
		this.CF997426.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CF997426.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.CF997426.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CF997426.FormattingEnabled = true;
		this.CF997426.Location = new System.Drawing.Point(352, 65);
		this.CF997426.Name = "cbbDinhDang3";
		this.CF997426.Size = new System.Drawing.Size(78, 24);
		this.CF997426.TabIndex = 44;
		this.cbbDinhDang4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang4.FormattingEnabled = true;
		this.cbbDinhDang4.Location = new System.Drawing.Point(449, 65);
		this.cbbDinhDang4.Name = "cbbDinhDang4";
		this.cbbDinhDang4.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang4.TabIndex = 45;
		this.label14.AutoSize = true;
		this.label14.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label14.Location = new System.Drawing.Point(721, 67);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(19, 19);
		this.label14.TabIndex = 49;
		this.label14.Text = "|";
		this.DE29BFBF.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DE29BFBF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.DE29BFBF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DE29BFBF.FormattingEnabled = true;
		this.DE29BFBF.Location = new System.Drawing.Point(546, 65);
		this.DE29BFBF.Name = "cbbDinhDang5";
		this.DE29BFBF.Size = new System.Drawing.Size(78, 24);
		this.DE29BFBF.TabIndex = 46;
		this.label13.AutoSize = true;
		this.label13.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label13.Location = new System.Drawing.Point(624, 67);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(19, 19);
		this.label13.TabIndex = 50;
		this.label13.Text = "|";
		this.cbbDinhDang6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang6.FormattingEnabled = true;
		this.cbbDinhDang6.Location = new System.Drawing.Point(643, 65);
		this.cbbDinhDang6.Name = "cbbDinhDang6";
		this.cbbDinhDang6.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang6.TabIndex = 47;
		this.label12.AutoSize = true;
		this.label12.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label12.Location = new System.Drawing.Point(527, 67);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(19, 19);
		this.label12.TabIndex = 51;
		this.label12.Text = "|";
		this.cbbDinhDang7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang7.FormattingEnabled = true;
		this.cbbDinhDang7.Location = new System.Drawing.Point(740, 65);
		this.cbbDinhDang7.Name = "cbbDinhDang7";
		this.cbbDinhDang7.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang7.TabIndex = 48;
		this.F83A1B2C.AutoSize = true;
		this.F83A1B2C.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F83A1B2C.Location = new System.Drawing.Point(430, 67);
		this.F83A1B2C.Name = "label11";
		this.F83A1B2C.Size = new System.Drawing.Size(19, 19);
		this.F83A1B2C.TabIndex = 52;
		this.F83A1B2C.Text = "|";
		this.label9.AutoSize = true;
		this.label9.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label9.Location = new System.Drawing.Point(236, 67);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(19, 19);
		this.label9.TabIndex = 53;
		this.label9.Text = "|";
		this.label10.AutoSize = true;
		this.label10.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label10.Location = new System.Drawing.Point(333, 67);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(19, 19);
		this.label10.TabIndex = 54;
		this.label10.Text = "|";
		this.CB0E8F98.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CB0E8F98.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.CB0E8F98.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CB0E8F98.FormattingEnabled = true;
		this.CB0E8F98.Location = new System.Drawing.Point(934, 65);
		this.CB0E8F98.Name = "cbbDinhDang9";
		this.CB0E8F98.Size = new System.Drawing.Size(78, 24);
		this.CB0E8F98.TabIndex = 48;
		this.B5306FB8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B5306FB8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.B5306FB8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B5306FB8.FormattingEnabled = true;
		this.B5306FB8.Location = new System.Drawing.Point(837, 65);
		this.B5306FB8.Name = "cbbDinhDang8";
		this.B5306FB8.Size = new System.Drawing.Size(78, 24);
		this.B5306FB8.TabIndex = 47;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(818, 67);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(19, 19);
		this.label2.TabIndex = 50;
		this.label2.Text = "|";
		this.DCADCE2C.AutoSize = true;
		this.DCADCE2C.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DCADCE2C.Location = new System.Drawing.Point(915, 67);
		this.DCADCE2C.Name = "label3";
		this.DCADCE2C.Size = new System.Drawing.Size(19, 19);
		this.DCADCE2C.TabIndex = 49;
		this.DCADCE2C.Text = "|";
		this.button1.BackColor = System.Drawing.Color.DarkOrange;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Location = new System.Drawing.Point(377, 124);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(121, 29);
		this.button1.TabIndex = 4;
		this.button1.Text = "Reset định dạng";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new System.EventHandler(B2810125);
		this.cbbDinhDang10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbDinhDang10.FormattingEnabled = true;
		this.cbbDinhDang10.Location = new System.Drawing.Point(1033, 65);
		this.cbbDinhDang10.Name = "cbbDinhDang10";
		this.cbbDinhDang10.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang10.TabIndex = 48;
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.Location = new System.Drawing.Point(1014, 67);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(19, 19);
		this.label4.TabIndex = 49;
		this.label4.Text = "|";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1122, 165);
		base.Controls.Add(this.BBA91921);
		base.Controls.Add(this.cbbDinhDang2);
		base.Controls.Add(this.CF997426);
		base.Controls.Add(this.cbbDinhDang4);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.DCADCE2C);
		base.Controls.Add(this.label14);
		base.Controls.Add(this.DE29BFBF);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.B5306FB8);
		base.Controls.Add(this.label13);
		base.Controls.Add(this.cbbDinhDang6);
		base.Controls.Add(this.cbbDinhDang10);
		base.Controls.Add(this.CB0E8F98);
		base.Controls.Add(this.label12);
		base.Controls.Add(this.cbbDinhDang7);
		base.Controls.Add(this.F83A1B2C);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.label10);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCopy";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fCopy_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
