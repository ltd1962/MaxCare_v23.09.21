using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class B5832B31 : UserControl
{
	private IContainer E820D183 = null;

	private Label label12;

	private Label FD21FC92;

	private Panel panel2;

	private LinkLabel DB870889;

	private LinkLabel linkLabel2;

	private Label DBA07B30;

	private Label label5;

	private Label label6;

	private Label label11;

	private PictureBox CCB76E84;

	private PictureBox pictureBox1;

	private Label label1;

	private Label B287B9B3;

	private Label label2;

	public B5832B31()
	{
		BB381622();
		Language.SetLanguage(this);
	}

	private void linkLabel2_Click(object sender, EventArgs e)
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

	private void DB870889_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && E820D183 != null)
		{
			E820D183.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void BB381622()
	{
		label12 = new Label();
		FD21FC92 = new Label();
		panel2 = new Panel();
		DB870889 = new LinkLabel();
		linkLabel2 = new LinkLabel();
		DBA07B30 = new Label();
		B287B9B3 = new Label();
		label5 = new Label();
		label6 = new Label();
		label2 = new Label();
		label11 = new Label();
		label1 = new Label();
		CCB76E84 = new PictureBox();
		pictureBox1 = new PictureBox();
		panel2.SuspendLayout();
		((ISupportInitialize)CCB76E84).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
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
		FD21FC92.AutoSize = true;
		FD21FC92.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FD21FC92.ForeColor = Color.FromArgb(192, 64, 0);
		FD21FC92.Location = new Point(209, 172);
		FD21FC92.Name = "label3";
		FD21FC92.Size = new Size(164, 25);
		FD21FC92.TabIndex = 27;
		FD21FC92.Text = "Hỗ trợ phần mềm:";
		panel2.BackColor = Color.WhiteSmoke;
		panel2.BorderStyle = BorderStyle.FixedSingle;
		panel2.Controls.Add(DB870889);
		panel2.Controls.Add(linkLabel2);
		panel2.Controls.Add(DBA07B30);
		panel2.Controls.Add(B287B9B3);
		panel2.Controls.Add(label5);
		panel2.Controls.Add(label6);
		panel2.Controls.Add(label2);
		panel2.Controls.Add(label11);
		panel2.Location = new Point(214, 200);
		panel2.Name = "panel2";
		panel2.Size = new Size(489, 121);
		panel2.TabIndex = 25;
		DB870889.AutoSize = true;
		DB870889.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		DB870889.Location = new Point(94, 4);
		DB870889.Name = "linkLabel1";
		DB870889.Size = new Size(190, 25);
		DB870889.TabIndex = 9;
		DB870889.TabStop = true;
		DB870889.Text = "https://bit.ly/43sB9Zq";
		DB870889.LinkClicked += DB870889_LinkClicked;
		DB870889.Click += linkLabel2_Click;
		linkLabel2.AutoSize = true;
		linkLabel2.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		linkLabel2.Location = new Point(94, 33);
		linkLabel2.Name = "linkLabel2";
		linkLabel2.Size = new Size(190, 25);
		linkLabel2.TabIndex = 9;
		linkLabel2.TabStop = true;
		linkLabel2.Text = "https://bit.ly/43sB9Zq";
		linkLabel2.Click += linkLabel2_Click;
		DBA07B30.AutoSize = true;
		DBA07B30.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		DBA07B30.ForeColor = Color.Black;
		DBA07B30.Location = new Point(3, 4);
		DBA07B30.Name = "label4";
		DBA07B30.Size = new Size(83, 25);
		DBA07B30.TabIndex = 2;
		DBA07B30.Text = "Website:";
		B287B9B3.AutoSize = true;
		B287B9B3.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B287B9B3.ForeColor = Color.Black;
		B287B9B3.Location = new Point(3, 91);
		B287B9B3.Name = "label7";
		B287B9B3.Size = new Size(62, 25);
		B287B9B3.TabIndex = 2;
		B287B9B3.Text = "CSKH:";
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
		label2.AutoSize = true;
		label2.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.ForeColor = Color.Black;
		label2.Location = new Point(94, 91);
		label2.Name = "label2";
		label2.Size = new Size(128, 25);
		label2.TabIndex = 2;
		label2.Text = "087-777-8777";
		label11.AutoSize = true;
		label11.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label11.ForeColor = Color.Black;
		label11.Location = new Point(94, 64);
		label11.Name = "label11";
		label11.Size = new Size(128, 25);
		label11.TabIndex = 2;
		label11.Text = "089-999-8999";
		label1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label1.Location = new Point(33, 143);
		label1.Name = "label1";
		label1.Size = new Size(653, 21);
		label1.TabIndex = 21;
		label1.Text = "PHẦN MỀM HỖ TRỢ KINH DOANH ONLINE - TỰ ĐỘNG HÓA MỌI THAO TÁC CỦA BẠN";
		label1.TextAlign = ContentAlignment.MiddleCenter;
		CCB76E84.Image = Resources.Bitmap_9;
		CCB76E84.Location = new Point(-17, 172);
		CCB76E84.Name = "pictureBox2";
		CCB76E84.Size = new Size(229, 293);
		CCB76E84.SizeMode = PictureBoxSizeMode.Zoom;
		CCB76E84.TabIndex = 23;
		CCB76E84.TabStop = false;
		pictureBox1.Image = Resources.AC8157A9;
		pictureBox1.Location = new Point(66, 3);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(620, 130);
		pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox1.TabIndex = 22;
		pictureBox1.TabStop = false;
		base.AutoScaleMode = AutoScaleMode.None;
		base.Controls.Add(label12);
		base.Controls.Add(FD21FC92);
		base.Controls.Add(panel2);
		base.Controls.Add(CCB76E84);
		base.Controls.Add(pictureBox1);
		base.Controls.Add(label1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Margin = new Padding(4);
		base.Name = "ucContact2";
		base.Size = new Size(714, 470);
		panel2.ResumeLayout(performLayout: false);
		panel2.PerformLayout();
		((ISupportInitialize)CCB76E84).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
