using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fUpdateData : Form
{
	private fMain CD96709A;

	private IContainer E5318623 = null;

	private BunifuCards bunifuCards1;

	private Panel D70373B1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private ComboBox cbbTypeUpdate;

	private Label DA8B6532;

	private TextBox txbData;

	private Label label2;

	private Button btnCancel;

	private Button btnAdd;

	private PictureBox C8924410;

	private Label label3;

	private ComboBox DA322907;

	private ComboBox C0101F23;

	private CheckBox ckbFbBlock;

	public fUpdateData(fMain c120353C_0, string string_0)
	{
		BE2F51B8();
		CD96709A = c120353C_0;
		cbbTypeUpdate.Text = string_0;
		DA322907.SelectedIndex = 0;
		Language.SetLanguage(this);
	}

	private void CD00C9AC(object sender, EventArgs e)
	{
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void EC3A882E(object sender, EventArgs e)
	{
		try
		{
			bool flag = false;
			if (cbbTypeUpdate.Text != "Tình trạng" && cbbTypeUpdate.Text != "Fb Block" && (txbData.Text.Equals("") || txbData.Text.Equals(" |")))
			{
				if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Ba\u0323n co\u0301 chă\u0301c muô\u0301n xo\u0301a dư\u0303 liê\u0323u của {0} tài khoản?"), CD96709A.CountChooseRowInDatagridview())) == DialogResult.Yes)
				{
					flag = true;
				}
			}
			else if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Ba\u0323n co\u0301 chă\u0301c muô\u0301n câ\u0323p nhâ\u0323t dư\u0303 liê\u0323u của {0} tài khoản?"), CD96709A.CountChooseRowInDatagridview())) == DialogResult.Yes)
			{
				flag = true;
			}
			if (!flag)
			{
				return;
			}
			List<string> list = new List<string>();
			string text = txbData.Text;
			for (int i = 0; i < CD96709A.dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					list.Add(CD96709A.GetCellAccount(i, "cId"));
				}
			}
			switch (cbbTypeUpdate.Text)
			{
			case "Email|Mail khôi phục":
			{
				if (!CommonSQL.ABA6020E(list, "email|mailrecovery", text))
				{
					break;
				}
				for (int num = 0; num < CD96709A.dtgvAcc.Rows.Count; num++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(num, "cEmail", text.Split('|')[0]);
						CD96709A.SetCellAccount(num, "cMailRecovery", text.Split('|')[1]);
					}
				}
				break;
			}
			case "2FA":
			{
				if (!CommonSQL.smethod_9(list, "fa2", text))
				{
					break;
				}
				for (int num9 = 0; num9 < CD96709A.dtgvAcc.Rows.Count; num9++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[num9].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(num9, "cFa2", text);
					}
				}
				break;
			}
			case "Token":
			{
				if (!CommonSQL.smethod_9(list, "token", text))
				{
					break;
				}
				for (int num3 = 0; num3 < CD96709A.dtgvAcc.Rows.Count; num3++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[num3].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(num3, "cToken", text);
					}
				}
				break;
			}
			case "Phone":
			{
				if (!CommonSQL.ABA6020E(list, "phone", text))
				{
					break;
				}
				for (int num8 = 0; num8 < CD96709A.dtgvAcc.Rows.Count; num8++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[num8].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(num8, "cPhone", text.Split('|')[0]);
					}
				}
				break;
			}
			case "Proxy":
			{
				int selectedIndex = DA322907.SelectedIndex;
				string text3 = ((text == "") ? "" : (text + "*" + selectedIndex));
				if (!CommonSQL.smethod_9(list, "proxy", text3))
				{
					break;
				}
				for (int num4 = 0; num4 < CD96709A.dtgvAcc.Rows.Count; num4++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[num4].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(num4, "cProxy", text3);
					}
				}
				break;
			}
			case "Notes":
			{
				if (!CommonSQL.smethod_9(list, "ghiChu", text))
				{
					break;
				}
				for (int k = 0; k < CD96709A.dtgvAcc.Rows.Count; k++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[k].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(k, "cGhiChu", text);
					}
				}
				break;
			}
			case "Cookie":
			{
				if (!CommonSQL.smethod_9(list, "cookie1", text))
				{
					break;
				}
				for (int num6 = 0; num6 < CD96709A.dtgvAcc.Rows.Count; num6++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[num6].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(num6, "cCookies", text);
					}
				}
				break;
			}
			case "Birthday":
			{
				if (!CommonSQL.smethod_9(list, "birthday", text))
				{
					break;
				}
				for (int n = 0; n < CD96709A.dtgvAcc.Rows.Count; n++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[n].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(n, "cBirthday", text);
					}
				}
				break;
			}
			case "PassMail":
			{
				if (!CommonSQL.ABA6020E(list, "PassMail", text))
				{
					break;
				}
				for (int num11 = 0; num11 < CD96709A.dtgvAcc.Rows.Count; num11++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[num11].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(num11, "cPassMail", text);
					}
				}
				break;
			}
			case "Password":
			{
				if (!CommonSQL.smethod_9(list, "pass", text))
				{
					break;
				}
				for (int num7 = 0; num7 < CD96709A.dtgvAcc.Rows.Count; num7++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[num7].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(num7, "cPassword", text);
					}
				}
				break;
			}
			case "Fb Block":
			{
				text = (ckbFbBlock.Checked ? "Yes" : "");
				if (!CommonSQL.ABA6020E(list, "fbBlock", text))
				{
					break;
				}
				for (int l = 0; l < CD96709A.dtgvAcc.Rows.Count; l++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[l].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(l, "cFbBlock", text);
					}
				}
				break;
			}
			case "Useragent":
			{
				if (!CommonSQL.smethod_9(list, "useragent", text))
				{
					break;
				}
				for (int num10 = 0; num10 < CD96709A.dtgvAcc.Rows.Count; num10++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[num10].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(num10, "cUseragent", text);
					}
				}
				break;
			}
			case "Mail|pass":
			{
				if (text.Split('|').Length != 2)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p la\u0323i đi\u0323nh da\u0323ng Mail|Pass Mail!", 3);
					return;
				}
				if (!CommonSQL.ABA6020E(list, "email|passmail", text))
				{
					break;
				}
				for (int num5 = 0; num5 < CD96709A.dtgvAcc.Rows.Count; num5++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[num5].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(num5, "cEmail", text.Split('|')[0]);
						CD96709A.SetCellAccount(num5, "cPassMail", text.Split('|')[1]);
					}
				}
				break;
			}
			case "Tình trạng":
			{
				string text2 = C0101F23.Text;
				if (!CommonSQL.smethod_9(list, "info", text2))
				{
					break;
				}
				for (int num2 = 0; num2 < CD96709A.dtgvAcc.Rows.Count; num2++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[num2].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(num2, "cInfo", text2);
					}
				}
				break;
			}
			case "Status 282":
			{
				if (!CommonSQL.ABA6020E(list, "status282", text))
				{
					break;
				}
				for (int m = 0; m < CD96709A.dtgvAcc.Rows.Count; m++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[m].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(m, "cStatus282", text);
					}
				}
				break;
			}
			case "Mail khôi phục":
			{
				if (!CommonSQL.ABA6020E(list, "mailrecovery", text))
				{
					break;
				}
				for (int j = 0; j < CD96709A.dtgvAcc.Rows.Count; j++)
				{
					if (Convert.ToBoolean(CD96709A.dtgvAcc.Rows[j].Cells["cChose"].Value))
					{
						CD96709A.SetCellAccount(j, "cMailRecovery", text.Split('|')[0]);
					}
				}
				break;
			}
			}
			Close();
		}
		catch
		{
			MessageBoxHelper.Show("Vui lòng thử lại sau!", 2);
		}
	}

	private void cbbTypeUpdate_SelectedIndexChanged(object sender, EventArgs e)
	{
		label3.Visible = cbbTypeUpdate.Text == "Proxy";
		DA322907.Visible = cbbTypeUpdate.Text == "Proxy";
		C0101F23.Visible = cbbTypeUpdate.Text == "Tình trạng";
		C0101F23.SelectedIndex = 0;
		ckbFbBlock.Visible = cbbTypeUpdate.Text == "Fb Block";
		txbData.Visible = cbbTypeUpdate.Text != "Tình trạng" && cbbTypeUpdate.Text != "Fb Block";
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && E5318623 != null)
		{
			E5318623.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void BE2F51B8()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fUpdateData));
		bunifuCards1 = new BunifuCards();
		D70373B1 = new Panel();
		btnMinimize = new Button();
		C8924410 = new PictureBox();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		cbbTypeUpdate = new ComboBox();
		DA8B6532 = new Label();
		txbData = new TextBox();
		label2 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		label3 = new Label();
		DA322907 = new ComboBox();
		C0101F23 = new ComboBox();
		ckbFbBlock = new CheckBox();
		bunifuCards1.SuspendLayout();
		D70373B1.SuspendLayout();
		((ISupportInitialize)C8924410).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.Controls.Add(D70373B1);
		bunifuCards1.Dock = DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(416, 38);
		bunifuCards1.TabIndex = 12;
		D70373B1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		D70373B1.BackColor = Color.White;
		D70373B1.Controls.Add(btnMinimize);
		D70373B1.Controls.Add(C8924410);
		D70373B1.Controls.Add(bunifuCustomLabel1);
		D70373B1.Location = new Point(0, 5);
		D70373B1.Name = "pnlHeader";
		D70373B1.Size = new Size(416, 32);
		D70373B1.TabIndex = 9;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		btnMinimize.Location = new Point(382, -1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += CD00C9AC;
		C8924410.Cursor = Cursors.Default;
		C8924410.Image = Resources.Bitmap_4;
		C8924410.Location = new Point(3, 1);
		C8924410.Name = "pictureBox1";
		C8924410.Size = new Size(34, 27);
		C8924410.SizeMode = PictureBoxSizeMode.Zoom;
		C8924410.TabIndex = 79;
		C8924410.TabStop = false;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(416, 32);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		cbbTypeUpdate.Cursor = Cursors.Hand;
		cbbTypeUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTypeUpdate.FormattingEnabled = true;
		cbbTypeUpdate.ItemHeight = 16;
		cbbTypeUpdate.Items.AddRange(new object[16]
		{
			"Token", "Cookie", "Password", "Mail|pass", "PassMail", "2FA", "Birthday", "Useragent", "Proxy", "Notes",
			"Email|Mail khôi phục", "Mail khôi phục", "Phone", "Fb Block", "Tình trạng", "Status 282"
		});
		cbbTypeUpdate.Location = new Point(146, 45);
		cbbTypeUpdate.Name = "cbbTypeUpdate";
		cbbTypeUpdate.Size = new Size(238, 24);
		cbbTypeUpdate.TabIndex = 13;
		cbbTypeUpdate.SelectedIndexChanged += cbbTypeUpdate_SelectedIndexChanged;
		DA8B6532.AutoSize = true;
		DA8B6532.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		DA8B6532.Location = new Point(34, 48);
		DA8B6532.Name = "label1";
		DA8B6532.Size = new Size(105, 16);
		DA8B6532.TabIndex = 14;
		DA8B6532.Text = "Dữ liệu cập nhật:";
		txbData.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		txbData.Location = new Point(146, 75);
		txbData.Name = "txbData";
		txbData.Size = new Size(238, 23);
		txbData.TabIndex = 15;
		txbData.Visible = false;
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(34, 78);
		label2.Name = "label2";
		label2.Size = new Size(84, 16);
		label2.TabIndex = 16;
		label2.Text = "Nhập dữ liệu:";
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(209, 141);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 18;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(111, 141);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 17;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += EC3A882E;
		label3.AutoSize = true;
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label3.Location = new Point(34, 107);
		label3.Name = "label3";
		label3.Size = new Size(70, 16);
		label3.TabIndex = 16;
		label3.Text = "Loại proxy:";
		DA322907.Cursor = Cursors.Hand;
		DA322907.DropDownStyle = ComboBoxStyle.DropDownList;
		DA322907.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		DA322907.FormattingEnabled = true;
		DA322907.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		DA322907.Location = new Point(146, 104);
		DA322907.Name = "cbbTypeProxy";
		DA322907.Size = new Size(130, 24);
		DA322907.TabIndex = 124;
		C0101F23.Cursor = Cursors.Hand;
		C0101F23.DropDownStyle = ComboBoxStyle.DropDownList;
		C0101F23.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		C0101F23.FormattingEnabled = true;
		C0101F23.Items.AddRange(new object[4] { "Live", "Die", "Checkpoint", "Changed pass" });
		C0101F23.Location = new Point(146, 75);
		C0101F23.Name = "cbbTinhTrang";
		C0101F23.Size = new Size(238, 24);
		C0101F23.TabIndex = 127;
		C0101F23.Visible = false;
		ckbFbBlock.AutoSize = true;
		ckbFbBlock.Cursor = Cursors.Hand;
		ckbFbBlock.Location = new Point(146, 78);
		ckbFbBlock.Name = "ckbFbBlock";
		ckbFbBlock.Size = new Size(73, 20);
		ckbFbBlock.TabIndex = 128;
		ckbFbBlock.Text = "Fb Block";
		ckbFbBlock.UseVisualStyleBackColor = true;
		ckbFbBlock.Visible = false;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(416, 180);
		base.Controls.Add(ckbFbBlock);
		base.Controls.Add(C0101F23);
		base.Controls.Add(DA322907);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(label3);
		base.Controls.Add(label2);
		base.Controls.Add(txbData);
		base.Controls.Add(DA8B6532);
		base.Controls.Add(cbbTypeUpdate);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fUpdateData";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fUpdateData";
		bunifuCards1.ResumeLayout(performLayout: false);
		D70373B1.ResumeLayout(performLayout: false);
		((ISupportInitialize)C8924410).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
