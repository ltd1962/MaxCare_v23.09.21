using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class ucContact : UserControl
{
	private IContainer icontainer_0 = null;

	private Label label12;

	private Label FB8FE307;

	private Panel AF811C84;

	private LinkLabel C7936D87;

	private LinkLabel C6221781;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label11;

	private PictureBox C72604BC;

	private PictureBox BF07A922;

	private Label label1;

	private Label label9;

	private Label label7;

	private Label E90532AA;

	private Label B9A30F04;

	public ucContact()
	{
		A51A9220();
		Language.SetLanguage(this);
	}

	private void C6221781_Click(object sender, EventArgs e)
	{
		string text = (sender as LinkLabel).Text;
		try
		{
			Process.Start("chrome.exe", text);
		}
		catch
		{
			Process.Start(text);
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void A51A9220()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ucContact));
		label12 = new Label();
		FB8FE307 = new Label();
		AF811C84 = new Panel();
		C7936D87 = new LinkLabel();
		C6221781 = new LinkLabel();
		label4 = new Label();
		label9 = new Label();
		label7 = new Label();
		label5 = new Label();
		label6 = new Label();
		E90532AA = new Label();
		B9A30F04 = new Label();
		label11 = new Label();
		label1 = new Label();
		C72604BC = new PictureBox();
		BF07A922 = new PictureBox();
		AF811C84.SuspendLayout();
		((ISupportInitialize)C72604BC).BeginInit();
		((ISupportInitialize)BF07A922).BeginInit();
		SuspendLayout();
		label12.BorderStyle = BorderStyle.FixedSingle;
		label12.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label12.ForeColor = Color.Red;
		label12.Location = new Point(214, 355);
		label12.Name = "label12";
		label12.Size = new Size(489, 110);
		label12.TabIndex = 28;
		label12.Text = "Chú ý: Nghiêm cấm sử dụng phần mềm vào các mục đích xấu, vi phạm pháp luật. Nếu cố tình sẽ bị xóa khỏi hệ thống vĩnh viễn, và phải chịu hoàn toàn trách nhiệm trước pháp luật.";
		label12.TextAlign = ContentAlignment.MiddleCenter;
		FB8FE307.AutoSize = true;
		FB8FE307.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FB8FE307.ForeColor = Color.FromArgb(192, 64, 0);
		FB8FE307.Location = new Point(209, 172);
		FB8FE307.Name = "label3";
		FB8FE307.Size = new Size(164, 25);
		FB8FE307.TabIndex = 27;
		FB8FE307.Text = "Hỗ trợ phần mềm:";
		AF811C84.BackColor = Color.WhiteSmoke;
		AF811C84.BorderStyle = BorderStyle.FixedSingle;
		AF811C84.Controls.Add(C7936D87);
		AF811C84.Controls.Add(C6221781);
		AF811C84.Controls.Add(label4);
		AF811C84.Controls.Add(label9);
		AF811C84.Controls.Add(label7);
		AF811C84.Controls.Add(label5);
		AF811C84.Controls.Add(label6);
		AF811C84.Controls.Add(E90532AA);
		AF811C84.Controls.Add(B9A30F04);
		AF811C84.Controls.Add(label11);
		AF811C84.Location = new Point(214, 198);
		AF811C84.Name = "panel2";
		AF811C84.Size = new Size(489, 147);
		AF811C84.TabIndex = 25;
		C7936D87.AutoSize = true;
		C7936D87.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		C7936D87.Location = new Point(94, 4);
		C7936D87.Name = "linkLabel1";
		C7936D87.Size = new Size(207, 25);
		C7936D87.TabIndex = 9;
		C7936D87.TabStop = true;
		C7936D87.Text = "https://www.facebook.com/longk.hoanghai";
        C7936D87.Click += C6221781_Click;
		C6221781.AutoSize = true;
		C6221781.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		C6221781.Location = new Point(94, 33);
		C6221781.Name = "linkLabel2";
		C6221781.Size = new Size(378, 25);
		C6221781.TabIndex = 9;
		C6221781.TabStop = true;
		C6221781.Text = "https://www.facebook.com/longk.hoanghai";
		C6221781.Click += C6221781_Click;
		label4.AutoSize = true;
		label4.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label4.ForeColor = Color.Black;
		label4.Location = new Point(3, 4);
		label4.Name = "label4";
		label4.Size = new Size(83, 25);
		label4.TabIndex = 2;
		label4.Text = "Website:";
		label9.AutoSize = true;
		label9.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label9.ForeColor = Color.Black;
		label9.Location = new Point(3, 118);
		label9.Name = "label9";
		label9.Size = new Size(95, 25);
		label9.TabIndex = 2;
		label9.Text = "Khiếu nại:";
		label7.AutoSize = true;
		label7.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label7.ForeColor = Color.Black;
		label7.Location = new Point(3, 91);
		label7.Name = "label7";
		label7.Size = new Size(62, 25);
		label7.TabIndex = 2;
		label7.Text = "CSKH:";
		label5.AutoSize = true;
		label5.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label5.ForeColor = Color.Black;
		label5.Location = new Point(3, 64);
		label5.Name = "label5";
		label5.Size = new Size(77, 25);
		label5.TabIndex = 2;
		label5.Text = "Hotline:";
		label6.AutoSize = true;
		label6.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label6.ForeColor = Color.Black;
		label6.Location = new Point(3, 33);
		label6.Name = "label6";
		label6.Size = new Size(87, 25);
		label6.TabIndex = 2;
		label6.Text = "Fanpage:";
		E90532AA.AutoSize = true;
		E90532AA.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		E90532AA.ForeColor = Color.Black;
		E90532AA.Location = new Point(94, 118);
		E90532AA.Name = "label8";
		E90532AA.Size = new Size(120, 25);
		E90532AA.TabIndex = 2;
		E90532AA.Text = "0358.394.040";
		B9A30F04.AutoSize = true;
		B9A30F04.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B9A30F04.ForeColor = Color.Black;
		B9A30F04.Location = new Point(94, 91);
		B9A30F04.Name = "label2";
		B9A30F04.Size = new Size(120, 25);
		B9A30F04.TabIndex = 2;
		B9A30F04.Text = "0966.260.829";
		label11.AutoSize = true;
		label11.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label11.ForeColor = Color.Black;
		label11.Location = new Point(94, 64);
		label11.Name = "label11";
		label11.Size = new Size(120, 25);
		label11.TabIndex = 2;
		label11.Text = "0969.078.803";
		label1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label1.Location = new Point(33, 143);
		label1.Name = "label1";
		label1.Size = new Size(653, 21);
		label1.TabIndex = 21;
		label1.Text = "PHẦN MỀM HỖ TRỢ KINH DOANH ONLINE - TỰ ĐỘNG HÓA MỌI THAO TÁC CỦA BẠN";
		label1.TextAlign = ContentAlignment.MiddleCenter;
		C72604BC.Image = Resources.Bitmap_3;
		C72604BC.Location = new Point(-17, 172);
		C72604BC.Name = "pictureBox2";
		C72604BC.Size = new Size(229, 293);
		C72604BC.SizeMode = PictureBoxSizeMode.Zoom;
		C72604BC.TabIndex = 23;
		C72604BC.TabStop = false;
		BF07A922.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		BF07A922.Location = new Point(66, 3);
		BF07A922.Name = "pictureBox1";
		BF07A922.Size = new Size(620, 130);
		BF07A922.SizeMode = PictureBoxSizeMode.AutoSize;
		BF07A922.TabIndex = 22;
		BF07A922.TabStop = false;
		base.AutoScaleMode = AutoScaleMode.None;
		base.Controls.Add(label12);
		base.Controls.Add(FB8FE307);
		base.Controls.Add(AF811C84);
		base.Controls.Add(C72604BC);
		base.Controls.Add(BF07A922);
		base.Controls.Add(label1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Margin = new Padding(4);
		base.Name = "ucContact";
		base.Size = new Size(714, 470);
		AF811C84.ResumeLayout(performLayout: false);
		AF811C84.PerformLayout();
		((ISupportInitialize)C72604BC).EndInit();
		((ISupportInitialize)BF07A922).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
