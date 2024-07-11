using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fDanhSachKichBan_Old : Form
{
	private string F31D0EA2 = "";

	private IContainer CEB17715 = null;

	private ToolTip toolTip_0;

	private BunifuDragControl F58171B7;

	private BunifuDragControl B9169F39;

	private GroupBox DE2200A7;

	private BunifuCards E39FC02A;

	private Panel BB237734;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button button1;

	private GroupBox groupBox2;

	public DataGridView dtgvKichBan;

	public DataGridView dtgvHanhDong;

	private ContextMenuStrip ECAB14B9;

	private ToolStripMenuItem EF81CB9B;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem CAB14E0C;

	private ToolStripMenuItem toolStripMenuItem_1;

	private Button button3;

	private Button D2A14635;

	private ContextMenuStrip D7268688;

	private ToolStripMenuItem toolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem4;

	private ToolStripMenuItem toolStripMenuItem2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn F3A293B4;

	private DataGridViewTextBoxColumn cTenHanhDong;

	private DataGridViewTextBoxColumn cTheLoai;

	private Panel panel1;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cId_KichBan;

	private DataGridViewTextBoxColumn C70EDA18;

	private SplitContainer splitContainer1;

	public fDanhSachKichBan_Old(string string_0)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		Language.LangCtmsAcc(ECAB14B9);
		Language.LangCtmsAcc(D7268688);
		F31D0EA2 = string_0;
	}

	private void D03028A1()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(DE2200A7);
		foreach (DataGridViewColumn column in dtgvKichBan.Columns)
		{
			Language.smethod_1(column);
		}
		Language.smethod_0(groupBox2);
		foreach (DataGridViewColumn column2 in dtgvHanhDong.Columns)
		{
			Language.smethod_1(column2);
		}
		Language.FE014894(EF81CB9B);
		Language.FE014894(toolStripMenuItem_0);
		Language.FE014894(CAB14E0C);
		Language.FE014894(toolStripMenuItem_1);
		Language.FE014894(toolStripMenuItem1);
		Language.FE014894(toolStripMenuItem3);
		Language.FE014894(toolStripMenuItem4);
		Language.FE014894(toolStripMenuItem2);
	}

	private void F9927207(object sender, EventArgs e)
	{
		method_5(F31D0EA2);
	}

	private void D828711D(object sender, EventArgs e)
	{
		Close();
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		method_6();
	}

	private void CAB14E0C_Click(object sender, EventArgs e)
	{
		EE967A12();
	}

	private void toolStripMenuItem4_Click(object sender, EventArgs e)
	{
		method_3();
	}

	public void method_0(ref DataGridView dataGridView_0, int AA8D54AC, int EB0AB494)
	{
		string text = "";
		for (int i = 1; i < dataGridView_0.Columns.Count; i++)
		{
			text = DatagridviewHelper.GetStatusDataGridView(dataGridView_0, AA8D54AC, i);
			DatagridviewHelper.smethod_5(dataGridView_0, AA8D54AC, i, DatagridviewHelper.GetStatusDataGridView(dataGridView_0, EB0AB494, i));
			DatagridviewHelper.smethod_5(dataGridView_0, EB0AB494, i, text);
		}
	}

	private void FD21B881(object sender, EventArgs e)
	{
		int index = dtgvHanhDong.SelectedRows[0].Index;
		if (index == 0)
		{
			return;
		}
		string text = DatagridviewHelper.GetStatusDataGridView(dtgvHanhDong, index - 1, "cId_HanhDong");
		string text2 = DatagridviewHelper.GetStatusDataGridView(dtgvHanhDong, index, "cId_HanhDong");
		if (text + text2 != "")
		{
			if (InteractSQL.smethod_14(text, text2))
			{
				method_0(ref dtgvHanhDong, index, index - 1);
				dtgvHanhDong.Rows[index - 1].Selected = true;
			}
			else
			{
				MessageBoxHelper.Show("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		int index = dtgvHanhDong.SelectedRows[0].Index;
		if (index == dtgvHanhDong.RowCount - 1)
		{
			return;
		}
		string text = DatagridviewHelper.GetStatusDataGridView(dtgvHanhDong, index + 1, "cId_HanhDong");
		string text2 = DatagridviewHelper.GetStatusDataGridView(dtgvHanhDong, index, "cId_HanhDong");
		if (text + text2 != "")
		{
			if (InteractSQL.smethod_14(text, text2))
			{
				method_0(ref dtgvHanhDong, index, index + 1);
				dtgvHanhDong.Rows[index + 1].Selected = true;
			}
			else
			{
				MessageBoxHelper.Show("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void D88B582B(object sender, EventArgs e)
	{
		ThemKichBan();
	}

	private void toolStripMenuItem1_Click(object sender, EventArgs e)
	{
		ABBA18BB();
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		method_8();
	}

	private void C81B67B0(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex > -1)
		{
			method_2();
		}
	}

	private void BC1728B9(object sender, EventArgs e)
	{
		method_4();
	}

	private void toolStripMenuItem2_Click(object sender, EventArgs e)
	{
		method_1();
	}

	private void F032BA07(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Delete:
			method_3();
			break;
		case Keys.Insert:
		case Keys.F1:
			ABBA18BB();
			break;
		case Keys.F2:
			method_4();
			break;
		case Keys.F5:
			method_2();
			break;
		case Keys.D:
			if (e.Modifiers == Keys.Control)
			{
				method_1();
			}
			break;
		}
	}

	private void method_1()
	{
		try
		{
			if (dtgvHanhDong.RowCount == 0)
			{
				MessageBoxHelper.Show("Vui lòng thêm hành động trước!", 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvHanhDong.SelectedRows[0];
			string f5B787AE = dataGridViewRow.Cells["cId_HanhDong"].Value.ToString();
			string text = dataGridViewRow.Cells["cTenHanhDong"].Value.ToString();
			string text2 = text + " - Copy";
			int num = 2;
			while (InteractSQL.smethod_10(text2))
			{
				text2 = text + $" - Copy ({num++})";
			}
			if (InteractSQL.smethod_12(f5B787AE, text2))
			{
				DataTable dataTable = InteractSQL.EE968A20();
				dtgvHanhDong.Rows.Add(dtgvHanhDong.RowCount + 1, dataTable.Rows[0]["Id_HanhDong"], dataTable.Rows[0]["TenHanhDong"], dataTable.Rows[0]["MoTa"]);
			}
			else
			{
				MessageBoxHelper.Show("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
		catch
		{
		}
	}

	private void method_2()
	{
		try
		{
			dtgvHanhDong.Rows.Clear();
			if (dtgvKichBan.RowCount != 0)
			{
				DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
				string string_ = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
				DataTable dataTable = InteractSQL.GetAllHanhDongByKichBan(string_);
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					dtgvHanhDong.Rows.Add(dtgvHanhDong.RowCount + 1, dataTable.Rows[i]["Id_HanhDong"], dataTable.Rows[i]["TenHanhDong"], dataTable.Rows[i]["MoTa"]);
				}
			}
		}
		catch
		{
		}
	}

	private void method_3()
	{
		try
		{
			if (dtgvHanhDong.RowCount == 0)
			{
				MessageBoxHelper.Show("Vui lòng thêm hành động trước!", 3);
			}
			else
			{
				if (MessageBoxHelper.ShowMessages("Bạn có chắc muốn xóa hoạt động này?") != DialogResult.Yes)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = dtgvHanhDong.SelectedRows[0];
				if (InteractSQL.A18973AD(dataGridViewRow.Cells["cId_HanhDong"].Value.ToString()))
				{
					int index = dataGridViewRow.Index;
					for (int i = index; i < dtgvHanhDong.Rows.Count - 1; i++)
					{
						method_0(ref dtgvHanhDong, i, i + 1);
					}
					dtgvHanhDong.Rows.RemoveAt(dtgvHanhDong.Rows.Count - 1);
				}
				else
				{
					MessageBoxHelper.Show("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void ABBA18BB()
	{
		try
		{
			if (dtgvKichBan.RowCount == 0)
			{
				MessageBoxHelper.Show("Vui lòng thêm kịch bản trước!", 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			int count = InteractSQL.GetAllHanhDongByKichBan(text).Rows.Count;
			Common.ShowForm(new fThemHanhDongv3(text));
			DataTable dataTable = InteractSQL.GetAllHanhDongByKichBan(text);
			int count2 = dataTable.Rows.Count;
			if (count2 > count)
			{
				dtgvHanhDong.Rows.Add(dtgvHanhDong.RowCount + 1, dataTable.Rows[count2 - 1]["Id_HanhDong"], dataTable.Rows[count2 - 1]["TenHanhDong"], dataTable.Rows[count2 - 1]["MoTa"]);
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void method_4()
	{
		try
		{
			if (dtgvHanhDong.RowCount == 0)
			{
				MessageBoxHelper.Show("Vui lòng thêm hành động trước!", 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvHanhDong.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_HanhDong"].Value.ToString();
			DataTable dataTable = InteractSQL.FB881189(text);
			Form form = null;
			switch (dataTable.Rows[0]["TenTuongTac"].ToString())
			{
			case "HDDoiTen":
				form = new fHDDoiTen("", 1, text);
				break;
			case "HDAnMail":
				form = new fHDAnMail("", 1, text);
				break;
			case "HDXoaSdt":
				form = new fHDXoaSdt("", 1, text);
				break;
			case "HDVerify":
				form = new fHDVerify("", 1, text);
				break;
			case "HDReport":
				form = new fHDReport("", 1, text);
				break;
			case "HDRoiNhom":
				form = new fHDRoiNhom("", 1, text);
				break;
			case "HDTaoPage":
				form = new fHDTaoPage("", 1, text);
				break;
			case "HDUpCover":
				form = new fHDUpCover("", 1, text);
				break;
			case "HDDangBai":
				form = new fHDDangBai("", 1, text);
				break;
			case "HDAddMail":
				form = new fHDAddMail("", 1, text);
				break;
			case "HDOnOff2FA":
				form = new fHDOnOff2FA("", 1, text);
				break;
			case "HDXemWatch":
				form = new fHDXemWatch("", 1, text);
				break;
			case "HDXemStory":
				form = new fHDXemStory("", 1, text);
				break;
			case "HDShareBai":
				form = new fHDShareBai("", 1, text);
				break;
			case "HDDangReel":
				form = new fHDDangReel("", 1, text);
				break;
			case "HDChaySpam":
				form = new fHDChaySpam("", 1, text);
				break;
			case "HDUpAvatar":
				form = new fHDUpAvatar("", 1, text);
				break;
			case "HDChocBanBe":
				form = new fHDChocBanBe("", 1, text);
				break;
			case "HDHuyKetBan":
				form = new fHDHuyKetBan("", 1, text);
				break;
			case "HDKetBanVip":
				form = new fHDKetBanVip("", 1, text);
				break;
			case "HDKhangSpam":
				form = new fHDKhangSpam("", 1, text);
				break;
			case "HDUptopPost":
				form = new fHDUptopPost("", 1, text);
				break;
			case "HDSharePage":
				form = new fHDSharePage("", 1, text);
				break;
			case "HDLoginMail":
				form = new fHDLoginMail("", 1, text);
				break;
			case "HDDangStory":
				form = new fHDDangStory("", 1, text);
				break;
			case "HDKetBanGoiY":
				form = new fHDKetBanGoiY("", 1, text);
				break;
			case "HDBackupData":
				form = new fHDBackupData("", 1, text);
				break;
			case "HDXoaTinNhan":
				form = new fHDXoaTinNhan("", 1, text);
				break;
			case "HDDoiMatKhau":
				form = new fHDDoiMatKhau("", 1, text);
				break;
			case "HDDangStatus":
				form = new fHDDangStatus("", 1, text);
				break;
			case "HDXoaBaiPage":
				form = new fHDXoaBaiPage("", 1, text);
				break;
			case "HDXemStoryv2":
				form = new fHDXemStoryv2("", 1, text);
				break;
			case "HDDoiNgonNgu":
				form = new fHDDoiNgonNgu("", 1, text);
				break;
			case "HDXemWatchv2":
				form = new fHDXemWatchv2("", 1, text);
				break;
			case "HDMoiLikePage":
				form = new fHDMoiLikePage("", 1, text);
				break;
			case "HDHuyLikePage":
				form = new fHDHuyLikePage("", 1, text);
				break;
			case "HDXoaBaiTuong":
				form = new fHDXoaBaiTuong("", 1, text);
				break;
			case "HDBaiVietNhom":
				form = new fHDBaiVietNhom("", 1, text);
				break;
			case "HDDocThongBao":
				form = new fHDDocThongBao("", 1, text);
				break;
			case "HDSpamBaiViet":
				form = new fHDSpamBaiViet("", 1, text);
				break;
			case "HDNghiGiaiLao":
				form = new fHDNghiGiaiLao("", 1, text);
				break;
			case "HDChaySeeding":
				form = new fHDChaySeeding("", 1, text);
				break;
			case "HDShareBaiTut":
				form = new fHDShareBaiTut("", 1, text);
				break;
			case "HDNhanTinPage":
				form = new fHDNhanTinPage("", 1, text);
				break;
			case "HDNhanTinBanBe":
				form = new fHDNhanTinBanBe("", 1, text);
				break;
			case "HDKetBanTepUid":
				form = new fHDKetBanTepUid("", 1, text);
				break;
			case "HDKetBanGoiYv2":
				form = new fHDKetBanGoiYv2("", 1, text);
				break;
			case "HDBaiVietBanBe":
				form = new fHDBaiVietBanBe("", 1, text);
				break;
			case "HDChangeTenPhu":
				form = new fHDChangeTenPhu("", 1, text);
				break;
			case "HDDangStatusV2":
				form = new fHDDangStatusV2("", 1, text);
				break;
			case "HDXacNhanKetBan":
				form = new fHDXacNhanKetBan("", 1, text);
				break;
			case "HDTimKiemGoogle":
				form = new fHDTimKiemGoogle("", 1, text);
				break;
			case "HDSpamBaiVietv2":
				form = new fHDSpamBaiVietv2("", 1, text);
				break;
			case "HDDangBaiTheoID":
				form = new fHDDangBaiTheoID("", 1, text);
				break;
			case "HDChangeSoThich":
				form = new fHDChangeSoThich("", 1, text);
				break;
			case "HDTuongTacBanBe":
				form = new fHDTuongTacBanBe("", 1, text);
				break;
			case "HDKetBanNewfeed":
				form = new fHDKetBanNewfeed("", 1, text);
				break;
			case "HDDocThongBaov2":
				form = new fHDDocThongBaov2("", 1, text);
				break;
			case "HDBuffViewVideo":
				form = new fHDBuffViewVideo("", 1, text);
				break;
			case "HDUnlockProfile":
				form = new fHDUnlockProfile("", 1, text);
				break;
			case "HDTruyCapWebsite":
				form = new fHDTruyCapWebsite("", 1, text);
				break;
			case "HDThamGiaNhomUid":
				form = new fHDThamGiaNhomUid("", 1, text);
				break;
			case "HDPhanHoiTinNhan":
				form = new fHDPhanHoiTinNhan("", 1, text);
				break;
			case "HDGiaiCheckpoint":
				form = new fHDGiaiCheckpoint("", 1, text);
				break;
			case "HDBaiVietFanpage":
				form = new fHDBaiVietFanpage("", 1, text);
				break;
			case "HDTuongTacNhomv2":
				form = new fHDTuongTacNhomv2("", 1, text);
				break;
			case "HDSeedingByVideo":
				form = new fHDSeedingByVideo("", 1, text);
				break;
			case "HDBaiVietProfile":
				form = new fHDBaiVietProfile("", 1, text);
				break;
			case "HDKetBanTepUidv2":
				form = new fHDKetBanTepUidv2("", 1, text);
				break;
			case "HDLinkToInstagram":
				form = new fHDLinkToInstagram("", 1, text);
				break;
			case "HDMoiBanBeVaoNhom":
				form = new fHDMoiBanBeVaoNhom("", 1, text);
				break;
			case "HDThamGiaNhomGoiY":
				form = new fHDThamGiaNhomGoiY("", 1, text);
				break;
			case "HDKetBanTepUidNew":
				form = new fHDKetBanTepUidNew("", 1, text);
				break;
			case "HDHuyLoiMoiKetBan":
				form = new fHDHuyLoiMoiKetBan("", 1, text);
				break;
			case "HDBuffLikeComment":
				form = new fHDBuffLikeComment("", 1, text);
				break;
			case "HDPhanHoiBinhLuan":
				form = new fHDPhanHoiBinhLuan("", 1, text);
				break;
			case "HDBaiVietNewsfeed":
				form = new fHDBaiVietNewsfeed("", 1, text);
				break;
			case "HDCapNhatThongTin":
				form = new fHDCapNhatThongTin("", 1, text);
				break;
			case "HDXemStoryChiDinh":
				form = new fHDXemStoryChiDinh("", 1, text);
				break;
			case "HDXacNhanKetBanv2":
				form = new fHDXacNhanKetBanv2("", 1, text);
				break;
			case "HDBaiVietTrenTuong":
				form = new fHDBaiVietTrenTuong("", 1, text);
				break;
			case "HDXoaThietBiTinCay":
				form = new fHDXoaThietBiTinCay("", 1, text);
				break;
			case "HDKetBanTheoTuKhoa":
				form = new fHDKetBanTheoTuKhoa("", 1, text);
				break;
			case "HDBuffFollowCaNhan":
				form = new fHDBuffFollowCaNhan("", 1, text);
				break;
			case "HDChucMungSinhNhat":
				form = new fHDChucMungSinhNhat("", 1, text);
				break;
			case "HDTuongTacNewsfeed":
				form = new fHDTuongTacNewsfeed("", 1, text);
				break;
			case "HDThamGiaNhomUidv2":
				form = new fHDThamGiaNhomUidv2("", 1, text);
				break;
			case "HDThamGiaNhomTuKhoa":
				form = new fHDThamGiaNhomTuKhoa("", 1, text);
				break;
			case "HDThamGiaNhomGoiYv2":
				form = new fHDThamGiaNhomGoiYv2("", 1, text);
				break;
			case "HDBaiVietNewsfeedv2":
				form = new fHDBaiVietNewsfeedv2("", 1, text);
				break;
			case "HDDangXuatThietBiCu":
				form = new fHDDangXuatThietBiCu("", 1, text);
				break;
			case "HDXoaNhatKyHoatDong":
				form = new fHDXoaNhatKyHoatDong("", 1, text);
				break;
			case "HDTuongTacNewsfeedv2":
				form = new fHDTuongTacNewsfeedv2("", 1, text);
				break;
			case "HDTuongTacLivestream":
				form = new fHDTuongTacLivestream("", 1, text);
				break;
			case "HDBuffFollowLikePage":
				form = new fHDBuffFollowLikePage("", 1, text);
				break;
			case "HDBuffTinNhanProfile":
				form = new fHDBuffTinNhanProfile("", 1, text);
				break;
			case "HDKetBanTheoTuKhoav2":
				form = new fHDKetBanTheoTuKhoav2("", 1, text);
				break;
			case "HDThamGiaNhomTuKhoav2":
				form = new fHDThamGiaNhomTuKhoav2("", 1, text);
				break;
			case "HDKetBanThanhVienNhom":
				form = new fHDKetBanThanhVienNhom("", 1, text);
				break;
			case "HDHuyLienKetInstagram":
				form = new fHDHuyLienKetInstagram("", 1, text);
				break;
			case "HDBatCheDoChuyenNghiep":
				form = new fHDBatCheDoChuyenNghiep("", 1, text);
				break;
			case "HDKetBanVoiBanCuaBanBe":
				form = new fHDKetBanVoiBanCuaBanBe("", 1, text);
				break;
			case "HDKetBanVoiBanBeCuaUid":
				form = new fHDKetBanVoiBanBeCuaUid("", 1, text);
				break;
			case "HDTuongTacBaiVietTheoID":
				form = new fHDTuongTacBaiVietTheoID("", 1, text);
				break;
			case "HDTuongTacBaiVietNhomv2":
				form = new fHDTuongTacBaiVietNhomv2("", 1, text);
				break;
			case "HDCongKhaiBaiVietGanThe":
				form = new fHDCongKhaiBaiVietGanThe("", 1, text);
				break;
			}
			if (form != null)
			{
				Common.ShowForm(form);
			}
			dataTable = InteractSQL.FB881189(text);
			DatagridviewHelper.SetStatusDataGridView(dtgvHanhDong, dataGridViewRow.Index, "cTenHanhDong", dataTable.Rows[0]["TenHanhDong"].ToString());
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void CF092128(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Delete:
			EE967A12();
			break;
		case Keys.Insert:
		case Keys.F1:
			ThemKichBan();
			break;
		case Keys.F2:
			method_6();
			break;
		case Keys.F5:
			method_5();
			break;
		case Keys.D:
			if (e.Modifiers == Keys.Control)
			{
				method_8();
			}
			break;
		}
	}

	private void method_5(string string_0 = "")
	{
		try
		{
			dtgvKichBan.Rows.Clear();
			DataTable dataTable = InteractSQL.GetAllKichBan();
			if (dataTable.Rows.Count > 0)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					DataRow dataRow = dataTable.Rows[i];
					dtgvKichBan.Rows.Add(i + 1, dataRow["Id_KichBan"], dataRow["TenKichBan"]);
				}
			}
			if (string_0 != "")
			{
				for (int j = 0; j < dtgvKichBan.RowCount; j++)
				{
					if (DatagridviewHelper.GetStatusDataGridView(dtgvKichBan, j, "cId_KichBan") == string_0)
					{
						dtgvKichBan.Rows[j].Selected = true;
						break;
					}
				}
			}
			method_2();
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
		}
	}

	private void EE967A12()
	{
		try
		{
			if (dtgvKichBan.RowCount == 0)
			{
				MessageBoxHelper.Show("Vui lòng thêm kịch bản trước!", 3);
			}
			else
			{
				if (MessageBoxHelper.ShowMessages("Bạn có chắc muốn xóa kịch bản này?") != DialogResult.Yes)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
				if (InteractSQL.smethod_7(dataGridViewRow.Cells["cId_KichBan"].Value.ToString()))
				{
					int index = dataGridViewRow.Index;
					for (int i = index; i < dtgvKichBan.Rows.Count - 1; i++)
					{
						method_0(ref dtgvKichBan, i, i + 1);
					}
					dtgvKichBan.Rows.RemoveAt(dtgvKichBan.Rows.Count - 1);
					method_2();
				}
				else
				{
					MessageBoxHelper.Show("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void method_6()
	{
		try
		{
			if (dtgvKichBan.RowCount == 0)
			{
				MessageBoxHelper.Show("Vui lòng thêm kịch bản trước!", 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			Common.ShowForm(new fThemKichBan(1, text));
			string object_ = InteractSQL.B6A0BD0E(text).Rows[0]["TenKichBan"].ToString();
			DatagridviewHelper.SetStatusDataGridView(dtgvKichBan, dataGridViewRow.Index, "cTenKichBan", object_);
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void ThemKichBan()
	{
		try
		{
			string text = "";
			try
			{
				text = InteractSQL.smethod_3().Rows[0]["Id_KichBan"].ToString();
			}
			catch
			{
			}
			Common.ShowForm(new fThemKichBan(0));
			DataTable dataTable = InteractSQL.smethod_3();
			string text2 = "";
			try
			{
				text2 = dataTable.Rows[0]["Id_KichBan"].ToString();
			}
			catch
			{
			}
			if (text != text2)
			{
				dtgvKichBan.Rows.Add(dtgvKichBan.RowCount + 1, dataTable.Rows[0]["Id_KichBan"], dataTable.Rows[0]["TenKichBan"]);
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void method_8()
	{
		try
		{
			if (dtgvKichBan.RowCount == 0)
			{
				MessageBoxHelper.Show("Vui lòng thêm kịch bản trước!", 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
			string f = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			string text = dataGridViewRow.Cells["cTenKichBan"].Value.ToString();
			string string_ = text + " - Copy";
			int num = 2;
			while (InteractSQL.smethod_5(string_))
			{
				string_ = text + $" - Copy ({num++})";
			}
			if (InteractSQL.smethod_8(f, string_))
			{
				DataTable dataTable = InteractSQL.smethod_3();
				dtgvKichBan.Rows.Add(dtgvKichBan.RowCount + 1, dataTable.Rows[0]["Id_KichBan"], dataTable.Rows[0]["TenKichBan"]);
			}
			else
			{
				MessageBoxHelper.Show("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
		catch
		{
		}
	}

	private void dtgvKichBan_KeyUp(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		Keys keys = keyCode;
		if (keys == Keys.Up || keys == Keys.Down)
		{
			method_2();
		}
	}

	private void C4BA111D(object sender, PaintEventArgs e)
	{
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

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && CEB17715 != null)
		{
			CEB17715.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.CEB17715 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhSachKichBan_Old));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.CEB17715);
		this.F58171B7 = new Bunifu.Framework.UI.BunifuDragControl(this.CEB17715);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.B9169F39 = new Bunifu.Framework.UI.BunifuDragControl(this.CEB17715);
		this.BB237734 = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.DE2200A7 = new System.Windows.Forms.GroupBox();
		this.dtgvKichBan = new System.Windows.Forms.DataGridView();
		this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cId_KichBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.C70EDA18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ECAB14B9 = new System.Windows.Forms.ContextMenuStrip(this.CEB17715);
		this.EF81CB9B = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.CAB14E0C = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.E39FC02A = new Bunifu.Framework.UI.BunifuCards();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.button3 = new System.Windows.Forms.Button();
		this.D2A14635 = new System.Windows.Forms.Button();
		this.dtgvHanhDong = new System.Windows.Forms.DataGridView();
		this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.F3A293B4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cTenHanhDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.D7268688 = new System.Windows.Forms.ContextMenuStrip(this.CEB17715);
		this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.panel1 = new System.Windows.Forms.Panel();
		this.splitContainer1 = new System.Windows.Forms.SplitContainer();
		this.BB237734.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.DE2200A7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvKichBan).BeginInit();
		this.ECAB14B9.SuspendLayout();
		this.E39FC02A.SuspendLayout();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvHanhDong).BeginInit();
		this.D7268688.SuspendLayout();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		base.SuspendLayout();
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 10000;
		this.toolTip_0.InitialDelay = 200;
		this.toolTip_0.ReshowDelay = 40;
		this.toolTip_0.ToolTipTitle = "Chú thích";
		this.F58171B7.Fixed = true;
		this.F58171B7.Horizontal = true;
		this.F58171B7.TargetControl = this.bunifuCustomLabel1;
		this.F58171B7.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(951, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Qua\u0309n ly\u0301 ki\u0323ch ba\u0309n";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.B9169F39.Fixed = true;
		this.B9169F39.Horizontal = true;
		this.B9169F39.TargetControl = this.BB237734;
		this.B9169F39.Vertical = true;
		this.BB237734.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.BB237734.BackColor = System.Drawing.Color.White;
		this.BB237734.Controls.Add(this.button1);
		this.BB237734.Controls.Add(this.pictureBox1);
		this.BB237734.Controls.Add(this.bunifuCustomLabel1);
		this.BB237734.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.BB237734.Location = new System.Drawing.Point(0, 3);
		this.BB237734.Name = "pnlHeader";
		this.BB237734.Size = new System.Drawing.Size(986, 31);
		this.BB237734.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(957, 2);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(D828711D);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.DE2200A7.BackColor = System.Drawing.Color.White;
		this.DE2200A7.Controls.Add(this.dtgvKichBan);
		this.DE2200A7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DE2200A7.Location = new System.Drawing.Point(0, 0);
		this.DE2200A7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DE2200A7.Name = "groupBox1";
		this.DE2200A7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DE2200A7.Size = new System.Drawing.Size(330, 517);
		this.DE2200A7.TabIndex = 1;
		this.DE2200A7.TabStop = false;
		this.DE2200A7.Text = "Danh sách kịch bản";
		this.dtgvKichBan.AllowUserToAddRows = false;
		this.dtgvKichBan.AllowUserToDeleteRows = false;
		this.dtgvKichBan.AllowUserToResizeRows = false;
		this.dtgvKichBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dtgvKichBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dtgvKichBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dtgvKichBan.Columns.AddRange(this.cStt, this.cId_KichBan, this.C70EDA18);
		this.dtgvKichBan.ContextMenuStrip = this.ECAB14B9;
		this.dtgvKichBan.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dtgvKichBan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dtgvKichBan.Location = new System.Drawing.Point(3, 20);
		this.dtgvKichBan.MultiSelect = false;
		this.dtgvKichBan.Name = "dtgvKichBan";
		this.dtgvKichBan.RowHeadersVisible = false;
		this.dtgvKichBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgvKichBan.Size = new System.Drawing.Size(324, 493);
		this.dtgvKichBan.TabIndex = 76;
		this.dtgvKichBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(C81B67B0);
		this.dtgvKichBan.KeyDown += new System.Windows.Forms.KeyEventHandler(CF092128);
		this.dtgvKichBan.KeyUp += new System.Windows.Forms.KeyEventHandler(dtgvKichBan_KeyUp);
		this.cStt.HeaderText = "STT";
		this.cStt.Name = "cStt";
		this.cStt.Width = 35;
		this.cId_KichBan.HeaderText = "Column1";
		this.cId_KichBan.Name = "cId_KichBan";
		this.cId_KichBan.Visible = false;
		this.C70EDA18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.C70EDA18.HeaderText = "Tên kịch bản";
		this.C70EDA18.Name = "cTenKichBan";
		this.C70EDA18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.ECAB14B9.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.EF81CB9B, this.toolStripMenuItem_0, this.CAB14E0C, this.toolStripMenuItem_1 });
		this.ECAB14B9.Name = "contextMenuStrip1";
		this.ECAB14B9.Size = new System.Drawing.Size(162, 92);
		this.EF81CB9B.Image = Resources.Bitmap_52;
		this.EF81CB9B.Name = "thêmMớiToolStripMenuItem";
		this.EF81CB9B.Size = new System.Drawing.Size(161, 22);
		this.EF81CB9B.Text = "Thêm ki\u0323ch ba\u0309n";
		this.EF81CB9B.Click += new System.EventHandler(D88B582B);
		this.toolStripMenuItem_0.Image = Resources.Bitmap_80;
		this.toolStripMenuItem_0.Name = "sửaToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(161, 22);
		this.toolStripMenuItem_0.Text = "Sửa tên ki\u0323ch ba\u0309n";
		this.toolStripMenuItem_0.Click += new System.EventHandler(toolStripMenuItem_0_Click);
		this.CAB14E0C.Image = Resources.F6929D2E;
		this.CAB14E0C.Name = "xóaToolStripMenuItem";
		this.CAB14E0C.Size = new System.Drawing.Size(161, 22);
		this.CAB14E0C.Text = "Xóa ki\u0323ch ba\u0309n";
		this.CAB14E0C.Click += new System.EventHandler(CAB14E0C_Click);
		this.toolStripMenuItem_1.Image = Resources.ACAAF18F;
		this.toolStripMenuItem_1.Name = "nhânBảnToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(161, 22);
		this.toolStripMenuItem_1.Text = "Nhân bản";
		this.toolStripMenuItem_1.Click += new System.EventHandler(toolStripMenuItem_1_Click);
		this.E39FC02A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.E39FC02A.BackColor = System.Drawing.Color.White;
		this.E39FC02A.BorderRadius = 0;
		this.E39FC02A.BottomSahddow = true;
		this.E39FC02A.color = System.Drawing.Color.DarkViolet;
		this.E39FC02A.Controls.Add(this.BB237734);
		this.E39FC02A.LeftSahddow = false;
		this.E39FC02A.Location = new System.Drawing.Point(1, 0);
		this.E39FC02A.Name = "bunifuCards1";
		this.E39FC02A.RightSahddow = true;
		this.E39FC02A.ShadowDepth = 20;
		this.E39FC02A.Size = new System.Drawing.Size(989, 37);
		this.E39FC02A.TabIndex = 12;
		this.groupBox2.BackColor = System.Drawing.Color.White;
		this.groupBox2.Controls.Add(this.button3);
		this.groupBox2.Controls.Add(this.D2A14635);
		this.groupBox2.Controls.Add(this.dtgvHanhDong);
		this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.groupBox2.Location = new System.Drawing.Point(0, 0);
		this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.groupBox2.Size = new System.Drawing.Size(639, 517);
		this.groupBox2.TabIndex = 1;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Danh sách hành động";
		this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button3.Image = Resources.DFACFA22;
		this.button3.Location = new System.Drawing.Point(594, 64);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(41, 38);
		this.button3.TabIndex = 78;
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.D2A14635.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.D2A14635.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D2A14635.Image = Resources.Bitmap_143;
		this.D2A14635.Location = new System.Drawing.Point(594, 19);
		this.D2A14635.Name = "button2";
		this.D2A14635.Size = new System.Drawing.Size(41, 38);
		this.D2A14635.TabIndex = 78;
		this.D2A14635.UseVisualStyleBackColor = true;
		this.D2A14635.Click += new System.EventHandler(FD21B881);
		this.dtgvHanhDong.AllowUserToAddRows = false;
		this.dtgvHanhDong.AllowUserToDeleteRows = false;
		this.dtgvHanhDong.AllowUserToResizeRows = false;
		this.dtgvHanhDong.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.dtgvHanhDong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dtgvHanhDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.dtgvHanhDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dtgvHanhDong.Columns.AddRange(this.dataGridViewTextBoxColumn1, this.F3A293B4, this.cTenHanhDong, this.cTheLoai);
		this.dtgvHanhDong.ContextMenuStrip = this.D7268688;
		this.dtgvHanhDong.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dtgvHanhDong.Location = new System.Drawing.Point(6, 20);
		this.dtgvHanhDong.MultiSelect = false;
		this.dtgvHanhDong.Name = "dtgvHanhDong";
		this.dtgvHanhDong.RowHeadersVisible = false;
		this.dtgvHanhDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgvHanhDong.Size = new System.Drawing.Size(585, 493);
		this.dtgvHanhDong.TabIndex = 77;
		this.dtgvHanhDong.KeyDown += new System.Windows.Forms.KeyEventHandler(F032BA07);
		this.dataGridViewTextBoxColumn1.HeaderText = "STT";
		this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn1.Width = 35;
		this.F3A293B4.HeaderText = "Column1";
		this.F3A293B4.Name = "cId_HanhDong";
		this.F3A293B4.Visible = false;
		this.cTenHanhDong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cTenHanhDong.HeaderText = "Tên hành động";
		this.cTenHanhDong.Name = "cTenHanhDong";
		this.cTenHanhDong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.cTheLoai.HeaderText = "Loại tương tác";
		this.cTheLoai.Name = "cTheLoai";
		this.cTheLoai.Width = 175;
		this.D7268688.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.toolStripMenuItem1, this.toolStripMenuItem3, this.toolStripMenuItem4, this.toolStripMenuItem2 });
		this.D7268688.Name = "contextMenuStrip1";
		this.D7268688.Size = new System.Drawing.Size(166, 92);
		this.toolStripMenuItem1.Image = Resources.Bitmap_51;
		this.toolStripMenuItem1.Name = "toolStripMenuItem1";
		this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
		this.toolStripMenuItem1.Text = "Thêm ha\u0300nh đô\u0323ng";
		this.toolStripMenuItem1.Click += new System.EventHandler(toolStripMenuItem1_Click);
		this.toolStripMenuItem3.Image = Resources.Bitmap_79;
		this.toolStripMenuItem3.Name = "toolStripMenuItem3";
		this.toolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
		this.toolStripMenuItem3.Text = "Sửa ha\u0300nh đô\u0323ng";
		this.toolStripMenuItem3.Click += new System.EventHandler(BC1728B9);
		this.toolStripMenuItem4.Image = Resources.Bitmap_77;
		this.toolStripMenuItem4.Name = "toolStripMenuItem4";
		this.toolStripMenuItem4.Size = new System.Drawing.Size(165, 22);
		this.toolStripMenuItem4.Text = "Xóa ha\u0300nh đô\u0323ng";
		this.toolStripMenuItem4.Click += new System.EventHandler(toolStripMenuItem4_Click);
		this.toolStripMenuItem2.Image = Resources.E01A6C20;
		this.toolStripMenuItem2.Name = "toolStripMenuItem2";
		this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
		this.toolStripMenuItem2.Text = "Nhân bản";
		this.toolStripMenuItem2.Click += new System.EventHandler(toolStripMenuItem2_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.splitContainer1);
		this.panel1.Controls.Add(this.E39FC02A);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(992, 565);
		this.panel1.TabIndex = 13;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.splitContainer1.Location = new System.Drawing.Point(4, 40);
		this.splitContainer1.Name = "splitContainer1";
		this.splitContainer1.Panel1.Controls.Add(this.DE2200A7);
		this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
		this.splitContainer1.Size = new System.Drawing.Size(984, 517);
		this.splitContainer1.SplitterDistance = 330;
		this.splitContainer1.SplitterWidth = 15;
		this.splitContainer1.TabIndex = 13;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(992, 565);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fDanhSachKichBan_Old";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(F9927207);
		base.Paint += new System.Windows.Forms.PaintEventHandler(C4BA111D);
		this.BB237734.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.DE2200A7.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dtgvKichBan).EndInit();
		this.ECAB14B9.ResumeLayout(false);
		this.E39FC02A.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dtgvHanhDong).EndInit();
		this.D7268688.ResumeLayout(false);
		this.panel1.ResumeLayout(false);
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
		this.splitContainer1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
