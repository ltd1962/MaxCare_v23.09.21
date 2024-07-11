using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ucThemHanhDongv1 : UserControl
{
	private fThemHanhDongv3 b8265D94_0;

	private string string_0;

	private IContainer icontainer_0 = null;

	private GroupBox groupBox5;

	private PictureBox pictureBox5;

	private Panel panel6;

	private Button DB1F9D38;

	private Button EEB16581;

	private Button BDACF314;

	private Button metroButton11;

	private Button FA1A7C93;

	private Button metroButton22;

	private Button metroButton73;

	private Button metroButton72;

	private Button FF086017;

	private Button metroButton3;

	private Button D7077AB2;

	private Button metroButton49;

	private GroupBox groupBox7;

	private Panel B18AE80F;

	private Button metroButton40;

	private Button metroButton42;

	private Button D7992A33;

	private Button metroButton47;

	private Button metroButton51;

	private Button metroButton44;

	private Button metroButton46;

	private Button metroButton50;

	private Button F08E61BC;

	private Button BD94DE25;

	private Button metroButton55;

	private Button metroButton74;

	private Button EC9F302A;

	private PictureBox B9B0EF09;

	private GroupBox groupBox6;

	private PictureBox pictureBox7;

	private Panel DD3D4930;

	private Button metroButton75;

	private Button metroButton64;

	private Button C9A05036;

	private Button metroButton71;

	private Button button3;

	private Button button6;

	private Button button9;

	private Button B2BFFB05;

	private Button A62EE913;

	private Button EEB5E7A8;

	private Button button1;

	private LinkLabel D3A6AB30;

	private Button FD3733A7;

	private Button A1127D22;

	private Button metroButton28;

	private GroupBox E18D5220;

	private Panel panel5;

	private Button metroButton38;

	private Button DD0AF325;

	private Button CB3E60BB;

	private Button D98686B5;

	private Button D60FE925;

	private Button metroButton13;

	private Button metroButton18;

	private Button F88A861E;

	private Button BA2E7510;

	private Button metroButton39;

	private Button metroButton9;

	private Button metroButton41;

	private PictureBox D19E5601;

	private GroupBox groupBox3;

	private PictureBox pictureBox6;

	private Panel panel7;

	private Button CE95BA97;

	private Button E584A51B;

	private Button metroButton48;

	private Button metroButton25;

	private Button metroButton31;

	private Button metroButton70;

	private Button metroButton36;

	private Button D892A916;

	private Button C28AF88F;

	private Button metroButton24;

	private Button metroButton27;

	private Button F1290E06;

	private GroupBox groupBox1;

	private Panel panel4;

	private Button C20A913C;

	private Button metroButton29;

	private Button AF29D10F;

	private Button metroButton59;

	private Button D9321601;

	private Button metroButton7;

	private Button metroButton5;

	private Button C9AE0934;

	private Button metroButton6;

	private Button metroButton66;

	private PictureBox pictureBox3;

	private GroupBox A330882D;

	private Panel panel3;

	private Button E9158BA4;

	private Button metroButton61;

	private Button metroButton62;

	private Button A60C6F8A;

	private Button metroButton65;

	private Button F3057BAB;

	private Button metroButton67;

	private Button metroButton68;

	private Button D8A93D08;

	private Button button4;

	private Button button2;

	private Button button5;

	private PictureBox D32E513A;

	public ucThemHanhDongv1(fThemHanhDongv3 b8265D94_1)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		b8265D94_0 = b8265D94_1;
		string_0 = b8265D94_1.string_0;
	}

	private void metroButton61_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDDocThongBao(string_0));
		if (fHDDocThongBao.F592AD29)
		{
			b8265D94_0.Close();
		}
	}

	private void FA151D14(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDXemStory(string_0));
		if (fHDXemStory.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton65_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDXemWatch(string_0));
		if (fHDXemWatch.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton67_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDNhanTinBanBe(string_0));
		if (fHDNhanTinBanBe.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void F7BF6906(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDChocBanBe(string_0));
		if (fHDChocBanBe.B088360B)
		{
			b8265D94_0.Close();
		}
	}

	private void E9158BA4_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDChucMungSinhNhat(string_0));
		if (fHDChucMungSinhNhat.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void B685C638(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDPhanHoiTinNhan(string_0));
		if (fHDPhanHoiTinNhan.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void A60C6F8A_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDDangStatus(string_0));
		if (fHDDangStatus.C32C8039)
		{
			b8265D94_0.Close();
		}
	}

	private void D8A93D08_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDDangStory(string_0));
		if (fHDDangStory.A783DF8F)
		{
			b8265D94_0.Close();
		}
	}

	private void AF023E26(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDTuongTacNewsfeed(string_0));
		if (fHDTuongTacNewsfeed.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void D286B485(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDTuongTacBanBe(string_0));
		if (fHDTuongTacBanBe.B70A01A3)
		{
			b8265D94_0.Close();
		}
	}

	private void D9321601_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDBaiVietNewsfeed(string_0));
		if (fHDBaiVietNewsfeed.C4B3DD27)
		{
			b8265D94_0.Close();
		}
	}

	private void E40A2510(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDBaiVietBanBe(string_0));
		if (fHDBaiVietBanBe.BD347D32)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton6_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDBaiVietNhom(string_0));
		if (fHDBaiVietNhom.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton5_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDBaiVietFanpage(string_0));
		if (fHDBaiVietFanpage.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton59_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDBaiVietTrenTuong(string_0));
		if (fHDBaiVietTrenTuong.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void C9AE0934_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDNghiGiaiLao(string_0));
		if (fHDNghiGiaiLao.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void C20A913C_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDChaySeeding(string_0));
		if (fHDChaySeeding.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void CB3E60BB_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDKetBanTheoTuKhoa(string_0));
		if (fHDKetBanTheoTuKhoa.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton13_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDKetBanGoiY(string_0));
		if (fHDKetBanGoiY.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void EA93F03C(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDXacNhanKetBan(string_0));
		if (fHDXacNhanKetBan.B12E03A4)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton9_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDKetBanTepUid(string_0));
		if (fHDKetBanTepUid.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void CD85578B(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDHuyLoiMoiKetBan(string_0));
		if (fHDHuyLoiMoiKetBan.BD36041F)
		{
			b8265D94_0.Close();
		}
	}

	private void F88A861E_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDHuyKetBan(string_0));
		if (fHDHuyKetBan.C41AFC20)
		{
			b8265D94_0.Close();
		}
	}

	private void B5BE3130(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDKetBanThanhVienNhom(string_0));
		if (fHDKetBanThanhVienNhom.FE2F2423)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton41_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDKetBanVoiBanCuaBanBe(string_0));
		if (fHDKetBanVoiBanCuaBanBe.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton39_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDKetBanVoiBanBeCuaUid(string_0));
		if (fHDKetBanVoiBanBeCuaUid.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton38_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDThamGiaNhomGoiY(string_0));
		if (fHDThamGiaNhomGoiY.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void DD0AF325_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDThamGiaNhomTuKhoa(string_0));
		if (fHDThamGiaNhomTuKhoa.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void D98686B5_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDThamGiaNhomUid(string_0));
		if (fHDThamGiaNhomUid.B90547A7)
		{
			b8265D94_0.Close();
		}
	}

	private void DAABD923(object sender, EventArgs e)
	{
		try
		{
			Common.ShowForm(new fHDBuffLikeComment(string_0));
			if (fHDBuffLikeComment.bool_0)
			{
				b8265D94_0.Close();
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError2(exception_, "metroButton26_Click");
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng liên hệ Admin!", 2);
		}
	}

	private void C8BB0C97(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDBuffFollowCaNhan(string_0));
		if (fHDBuffFollowCaNhan.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton31_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDBuffFollowLikePage(string_0));
		if (fHDBuffFollowLikePage.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void AD07BCB4(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDBuffTinNhanProfile(string_0));
		if (fHDBuffTinNhanProfile.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void D380CCAC(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDSpamBaiViet(string_0));
		if (fHDSpamBaiViet.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton36_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDDangBai(string_0));
		if (fHDDangBai.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void C28AF88F_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			Common.ShowForm(new fHDShareBaiTut(string_0));
			if (fHDShareBaiTut.ADAE2F9A)
			{
				b8265D94_0.Close();
			}
		}
		else
		{
			Common.ShowForm(new fHDShareBai(string_0));
			if (fHDShareBai.CC1F0516)
			{
				b8265D94_0.Close();
			}
		}
	}

	private void AC1A4BA4(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDPhanHoiBinhLuan(string_0));
		if (fHDPhanHoiBinhLuan.C7898DA0)
		{
			b8265D94_0.Close();
		}
	}

	private void E584A51B_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDDangStatusV2(string_0));
		if (fHDDangStatusV2.CBB17307)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton48_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDTuongTacLivestream(string_0));
		if (fHDTuongTacLivestream.B084CCB0)
		{
			b8265D94_0.Close();
		}
	}

	private void F1290E06_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDMoiLikePage(string_0));
		if (fHDMoiLikePage.A5877313)
		{
			b8265D94_0.Close();
		}
	}

	private void D892A916_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDMoiBanBeVaoNhom(string_0));
		if (fHDMoiBanBeVaoNhom.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void EEB16581_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDDoiMatKhau(string_0));
		if (fHDDoiMatKhau.CC18D121)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton49_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDXoaSdt(string_0));
		if (fHDXoaSdt.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void D7077AB2_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDAddMail(string_0));
		if (fHDAddMail.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton3_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDDoiTen(string_0));
		if (fHDDoiTen.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void FA1A7C93_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDUpAvatar(string_0));
		if (fHDUpAvatar.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton11_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDUpCover(string_0));
		if (fHDUpCover.D6397D15)
		{
			b8265D94_0.Close();
		}
	}

	private void BDACF314_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDOnOff2FA(string_0));
		if (fHDOnOff2FA.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void DB1F9D38_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDDoiNgonNgu(string_0));
		if (fHDDoiNgonNgu.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void DB126084(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDCapNhatThongTin(string_0));
		if (fHDCapNhatThongTin.A69247A9)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton72_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDXoaThietBiTinCay(string_0));
		if (fHDXoaThietBiTinCay.B7A3BCAE)
		{
			b8265D94_0.Close();
		}
	}

	private void F7896582(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDDangXuatThietBiCu(string_0));
		if (fHDDangXuatThietBiCu.FB2DC43C)
		{
			b8265D94_0.Close();
		}
	}

	private void B01B4A8F(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDRoiNhom(string_0));
		if (fHDRoiNhom.AF9F1289)
		{
			b8265D94_0.Close();
		}
	}

	private void CFB4FE2D(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDTimKiemGoogle(string_0));
		if (fHDTimKiemGoogle.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void FC987F0A(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDTruyCapWebsite(string_0));
		if (fHDTruyCapWebsite.AAB96118)
		{
			b8265D94_0.Close();
		}
	}

	private void EEB5E7A8_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDHuyLikePage(string_0));
		if (fHDHuyLikePage.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void B2BFFB05_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDLinkToInstagram(string_0));
		if (fHDLinkToInstagram.AD9B5B1F)
		{
			b8265D94_0.Close();
		}
	}

	private void B7B24602(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDHuyLienKetInstagram(string_0));
		if (fHDHuyLienKetInstagram.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void A62EE913_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDXoaBaiTuong(string_0));
		if (fHDXoaBaiTuong.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void EA185A11(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDXoaBaiPage(string_0));
		if (fHDXoaBaiPage.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton75_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDKhangSpam(string_0));
		if (fHDKhangSpam.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void C9A05036_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDBatCheDoChuyenNghiep(string_0));
		if (fHDBatCheDoChuyenNghiep.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void FF239336(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDTaoPage(string_0));
		if (fHDTaoPage.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void button6_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDUnlockProfile(string_0));
		if (fHDUnlockProfile.F130E896)
		{
			b8265D94_0.Close();
		}
	}

	private void D3A6AB30_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		b8265D94_0.Width = 1372;
		base.Width += 198;
		(sender as Control).Visible = false;
	}

	private void BA2D0C8C(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDDocThongBaov2(string_0));
		if (fHDDocThongBaov2.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void FAA84010(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDTuongTacNewsfeedv2(string_0));
		if (fHDTuongTacNewsfeedv2.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton46_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDTuongTacNhomv2(string_0));
		if (fHDTuongTacNhomv2.BA31D2B1)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton47_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDXacNhanKetBanv2(string_0));
		if (fHDXacNhanKetBanv2.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void D7992A33_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDSeedingByVideo(string_0));
		if (fHDSeedingByVideo.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void F08E61BC_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDThamGiaNhomTuKhoav2(string_0));
		if (fHDThamGiaNhomTuKhoav2.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void BD94DE25_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDKetBanTheoTuKhoav2(string_0));
		if (fHDKetBanTheoTuKhoav2.D6ADFB12)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton55_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDKetBanGoiYv2(string_0));
		if (fHDKetBanGoiYv2.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton50_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDXemStoryv2(string_0));
		if (fHDXemStoryv2.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void FC264329(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDXemWatchv2(string_0));
		if (fHDXemWatchv2.bool_0)
		{
			b8265D94_0.Close();
		}
	}

	private void EC9F302A_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDThamGiaNhomGoiYv2(string_0));
		if (fHDThamGiaNhomGoiYv2.C20E959F)
		{
			b8265D94_0.Close();
		}
	}

	private void metroButton74_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDXoaNhatKyHoatDong(string_0));
		if (fHDXoaNhatKyHoatDong.F1B5E793)
		{
			b8265D94_0.Close();
		}
	}

	private void DB14C9A9(object sender, EventArgs e)
	{
		Common.ShowForm(new fHDThamGiaNhomUidv2(string_0));
		if (fHDThamGiaNhomUidv2.bool_0)
		{
			b8265D94_0.Close();
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

	private void InitializeComponent()
	{
		this.groupBox5 = new System.Windows.Forms.GroupBox();
		this.pictureBox5 = new System.Windows.Forms.PictureBox();
		this.panel6 = new System.Windows.Forms.Panel();
		this.DB1F9D38 = new System.Windows.Forms.Button();
		this.EEB16581 = new System.Windows.Forms.Button();
		this.BDACF314 = new System.Windows.Forms.Button();
		this.metroButton11 = new System.Windows.Forms.Button();
		this.FA1A7C93 = new System.Windows.Forms.Button();
		this.metroButton22 = new System.Windows.Forms.Button();
		this.metroButton73 = new System.Windows.Forms.Button();
		this.metroButton72 = new System.Windows.Forms.Button();
		this.FF086017 = new System.Windows.Forms.Button();
		this.metroButton3 = new System.Windows.Forms.Button();
		this.D7077AB2 = new System.Windows.Forms.Button();
		this.metroButton49 = new System.Windows.Forms.Button();
		this.groupBox7 = new System.Windows.Forms.GroupBox();
		this.B18AE80F = new System.Windows.Forms.Panel();
		this.metroButton40 = new System.Windows.Forms.Button();
		this.metroButton42 = new System.Windows.Forms.Button();
		this.metroButton47 = new System.Windows.Forms.Button();
		this.metroButton51 = new System.Windows.Forms.Button();
		this.metroButton44 = new System.Windows.Forms.Button();
		this.metroButton46 = new System.Windows.Forms.Button();
		this.metroButton50 = new System.Windows.Forms.Button();
		this.F08E61BC = new System.Windows.Forms.Button();
		this.BD94DE25 = new System.Windows.Forms.Button();
		this.metroButton55 = new System.Windows.Forms.Button();
		this.metroButton74 = new System.Windows.Forms.Button();
		this.EC9F302A = new System.Windows.Forms.Button();
		this.D7992A33 = new System.Windows.Forms.Button();
		this.B9B0EF09 = new System.Windows.Forms.PictureBox();
		this.groupBox6 = new System.Windows.Forms.GroupBox();
		this.pictureBox7 = new System.Windows.Forms.PictureBox();
		this.DD3D4930 = new System.Windows.Forms.Panel();
		this.metroButton75 = new System.Windows.Forms.Button();
		this.metroButton64 = new System.Windows.Forms.Button();
		this.C9A05036 = new System.Windows.Forms.Button();
		this.metroButton71 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.button6 = new System.Windows.Forms.Button();
		this.button9 = new System.Windows.Forms.Button();
		this.B2BFFB05 = new System.Windows.Forms.Button();
		this.A62EE913 = new System.Windows.Forms.Button();
		this.EEB5E7A8 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.D3A6AB30 = new System.Windows.Forms.LinkLabel();
		this.FD3733A7 = new System.Windows.Forms.Button();
		this.A1127D22 = new System.Windows.Forms.Button();
		this.metroButton28 = new System.Windows.Forms.Button();
		this.E18D5220 = new System.Windows.Forms.GroupBox();
		this.panel5 = new System.Windows.Forms.Panel();
		this.metroButton38 = new System.Windows.Forms.Button();
		this.DD0AF325 = new System.Windows.Forms.Button();
		this.CB3E60BB = new System.Windows.Forms.Button();
		this.D98686B5 = new System.Windows.Forms.Button();
		this.D60FE925 = new System.Windows.Forms.Button();
		this.metroButton13 = new System.Windows.Forms.Button();
		this.metroButton18 = new System.Windows.Forms.Button();
		this.F88A861E = new System.Windows.Forms.Button();
		this.BA2E7510 = new System.Windows.Forms.Button();
		this.metroButton39 = new System.Windows.Forms.Button();
		this.metroButton9 = new System.Windows.Forms.Button();
		this.metroButton41 = new System.Windows.Forms.Button();
		this.D19E5601 = new System.Windows.Forms.PictureBox();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.pictureBox6 = new System.Windows.Forms.PictureBox();
		this.panel7 = new System.Windows.Forms.Panel();
		this.CE95BA97 = new System.Windows.Forms.Button();
		this.E584A51B = new System.Windows.Forms.Button();
		this.metroButton48 = new System.Windows.Forms.Button();
		this.metroButton25 = new System.Windows.Forms.Button();
		this.metroButton31 = new System.Windows.Forms.Button();
		this.metroButton70 = new System.Windows.Forms.Button();
		this.metroButton36 = new System.Windows.Forms.Button();
		this.D892A916 = new System.Windows.Forms.Button();
		this.C28AF88F = new System.Windows.Forms.Button();
		this.metroButton24 = new System.Windows.Forms.Button();
		this.metroButton27 = new System.Windows.Forms.Button();
		this.F1290E06 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.panel4 = new System.Windows.Forms.Panel();
		this.C20A913C = new System.Windows.Forms.Button();
		this.metroButton29 = new System.Windows.Forms.Button();
		this.AF29D10F = new System.Windows.Forms.Button();
		this.metroButton59 = new System.Windows.Forms.Button();
		this.D9321601 = new System.Windows.Forms.Button();
		this.metroButton7 = new System.Windows.Forms.Button();
		this.metroButton5 = new System.Windows.Forms.Button();
		this.C9AE0934 = new System.Windows.Forms.Button();
		this.metroButton6 = new System.Windows.Forms.Button();
		this.metroButton66 = new System.Windows.Forms.Button();
		this.pictureBox3 = new System.Windows.Forms.PictureBox();
		this.A330882D = new System.Windows.Forms.GroupBox();
		this.panel3 = new System.Windows.Forms.Panel();
		this.E9158BA4 = new System.Windows.Forms.Button();
		this.metroButton61 = new System.Windows.Forms.Button();
		this.metroButton62 = new System.Windows.Forms.Button();
		this.A60C6F8A = new System.Windows.Forms.Button();
		this.metroButton65 = new System.Windows.Forms.Button();
		this.F3057BAB = new System.Windows.Forms.Button();
		this.metroButton67 = new System.Windows.Forms.Button();
		this.metroButton68 = new System.Windows.Forms.Button();
		this.D8A93D08 = new System.Windows.Forms.Button();
		this.button4 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.button5 = new System.Windows.Forms.Button();
		this.D32E513A = new System.Windows.Forms.PictureBox();
		this.groupBox5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
		this.panel6.SuspendLayout();
		this.groupBox7.SuspendLayout();
		this.B18AE80F.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.B9B0EF09).BeginInit();
		this.groupBox6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox7).BeginInit();
		this.DD3D4930.SuspendLayout();
		this.E18D5220.SuspendLayout();
		this.panel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.D19E5601).BeginInit();
		this.groupBox3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox6).BeginInit();
		this.panel7.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.panel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
		this.A330882D.SuspendLayout();
		this.panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.D32E513A).BeginInit();
		base.SuspendLayout();
		this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.groupBox5.Controls.Add(this.pictureBox5);
		this.groupBox5.Controls.Add(this.panel6);
		this.groupBox5.Location = new System.Drawing.Point(782, 3);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Size = new System.Drawing.Size(189, 472);
		this.groupBox5.TabIndex = 8;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "Chức năng Đổi thông tin";
		this.pictureBox5.Image = Resources.B0A0C4B5;
		this.pictureBox5.Location = new System.Drawing.Point(18, 22);
		this.pictureBox5.Name = "pictureBox5";
		this.pictureBox5.Size = new System.Drawing.Size(151, 83);
		this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox5.TabIndex = 1;
		this.pictureBox5.TabStop = false;
		this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.panel6.AutoScroll = true;
		this.panel6.Controls.Add(this.DB1F9D38);
		this.panel6.Controls.Add(this.EEB16581);
		this.panel6.Controls.Add(this.BDACF314);
		this.panel6.Controls.Add(this.metroButton11);
		this.panel6.Controls.Add(this.FA1A7C93);
		this.panel6.Controls.Add(this.metroButton22);
		this.panel6.Controls.Add(this.metroButton73);
		this.panel6.Controls.Add(this.metroButton72);
		this.panel6.Controls.Add(this.FF086017);
		this.panel6.Controls.Add(this.metroButton3);
		this.panel6.Controls.Add(this.D7077AB2);
		this.panel6.Controls.Add(this.metroButton49);
		this.panel6.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.panel6.Location = new System.Drawing.Point(1, 120);
		this.panel6.Name = "panel6";
		this.panel6.Size = new System.Drawing.Size(187, 347);
		this.panel6.TabIndex = 14;
		this.DB1F9D38.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DB1F9D38.Location = new System.Drawing.Point(17, 203);
		this.DB1F9D38.Name = "metroButton19";
		this.DB1F9D38.Size = new System.Drawing.Size(151, 26);
		this.DB1F9D38.TabIndex = 8;
		this.DB1F9D38.Text = "Đổi ngôn ngữ";
		this.DB1F9D38.Click += new System.EventHandler(DB1F9D38_Click);
		this.EEB16581.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EEB16581.Location = new System.Drawing.Point(17, 0);
		this.EEB16581.Name = "metroButton2";
		this.EEB16581.Size = new System.Drawing.Size(151, 26);
		this.EEB16581.TabIndex = 8;
		this.EEB16581.Text = "Đổi mật khẩu";
		this.EEB16581.Click += new System.EventHandler(EEB16581_Click);
		this.BDACF314.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BDACF314.Location = new System.Drawing.Point(17, 174);
		this.BDACF314.Name = "metroButton12";
		this.BDACF314.Size = new System.Drawing.Size(151, 26);
		this.BDACF314.TabIndex = 8;
		this.BDACF314.Text = "Bật - Tắt 2FA";
		this.BDACF314.Click += new System.EventHandler(BDACF314_Click);
		this.metroButton11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton11.Location = new System.Drawing.Point(17, 145);
		this.metroButton11.Name = "metroButton11";
		this.metroButton11.Size = new System.Drawing.Size(151, 26);
		this.metroButton11.TabIndex = 8;
		this.metroButton11.Text = "Up Cover";
		this.metroButton11.Click += new System.EventHandler(metroButton11_Click);
		this.FA1A7C93.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FA1A7C93.Location = new System.Drawing.Point(17, 116);
		this.FA1A7C93.Name = "metroButton10";
		this.FA1A7C93.Size = new System.Drawing.Size(151, 26);
		this.FA1A7C93.TabIndex = 8;
		this.FA1A7C93.Text = "Up Avatar";
		this.FA1A7C93.Click += new System.EventHandler(FA1A7C93_Click);
		this.metroButton22.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton22.Location = new System.Drawing.Point(17, 319);
		this.metroButton22.Name = "metroButton22";
		this.metroButton22.Size = new System.Drawing.Size(151, 26);
		this.metroButton22.TabIndex = 2;
		this.metroButton22.Text = "Rời nhóm";
		this.metroButton22.Click += new System.EventHandler(B01B4A8F);
		this.metroButton73.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton73.Location = new System.Drawing.Point(17, 290);
		this.metroButton73.Name = "metroButton73";
		this.metroButton73.Size = new System.Drawing.Size(151, 26);
		this.metroButton73.TabIndex = 8;
		this.metroButton73.Text = "Đăng xuất thiết bị cũ";
		this.metroButton73.Click += new System.EventHandler(F7896582);
		this.metroButton72.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton72.Location = new System.Drawing.Point(17, 261);
		this.metroButton72.Name = "metroButton72";
		this.metroButton72.Size = new System.Drawing.Size(151, 26);
		this.metroButton72.TabIndex = 8;
		this.metroButton72.Text = "Xóa thiết bị tin cậy";
		this.metroButton72.Click += new System.EventHandler(metroButton72_Click);
		this.FF086017.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FF086017.Location = new System.Drawing.Point(17, 232);
		this.FF086017.Name = "metroButton4";
		this.FF086017.Size = new System.Drawing.Size(151, 26);
		this.FF086017.TabIndex = 8;
		this.FF086017.Text = "Cập nhật thông tin";
		this.FF086017.Click += new System.EventHandler(DB126084);
		this.metroButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton3.Location = new System.Drawing.Point(17, 87);
		this.metroButton3.Name = "metroButton3";
		this.metroButton3.Size = new System.Drawing.Size(151, 26);
		this.metroButton3.TabIndex = 8;
		this.metroButton3.Text = "Đổi tên";
		this.metroButton3.Click += new System.EventHandler(metroButton3_Click);
		this.D7077AB2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D7077AB2.Location = new System.Drawing.Point(17, 58);
		this.D7077AB2.Name = "btnAddMail";
		this.D7077AB2.Size = new System.Drawing.Size(151, 26);
		this.D7077AB2.TabIndex = 8;
		this.D7077AB2.Text = "Add Mail";
		this.D7077AB2.Click += new System.EventHandler(D7077AB2_Click);
		this.metroButton49.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton49.Location = new System.Drawing.Point(17, 29);
		this.metroButton49.Name = "metroButton49";
		this.metroButton49.Size = new System.Drawing.Size(151, 26);
		this.metroButton49.TabIndex = 8;
		this.metroButton49.Text = "Xóa Sđt";
		this.metroButton49.Click += new System.EventHandler(metroButton49_Click);
		this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.groupBox7.Controls.Add(this.B18AE80F);
		this.groupBox7.Controls.Add(this.B9B0EF09);
		this.groupBox7.Location = new System.Drawing.Point(1171, 3);
		this.groupBox7.Name = "groupBox7";
		this.groupBox7.Size = new System.Drawing.Size(189, 472);
		this.groupBox7.TabIndex = 9;
		this.groupBox7.TabStop = false;
		this.groupBox7.Text = "Tính năng chạy trên WWW";
		this.B18AE80F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.B18AE80F.AutoScroll = true;
		this.B18AE80F.Controls.Add(this.metroButton40);
		this.B18AE80F.Controls.Add(this.metroButton42);
		this.B18AE80F.Controls.Add(this.metroButton47);
		this.B18AE80F.Controls.Add(this.metroButton51);
		this.B18AE80F.Controls.Add(this.metroButton44);
		this.B18AE80F.Controls.Add(this.metroButton46);
		this.B18AE80F.Controls.Add(this.metroButton50);
		this.B18AE80F.Controls.Add(this.F08E61BC);
		this.B18AE80F.Controls.Add(this.BD94DE25);
		this.B18AE80F.Controls.Add(this.metroButton55);
		this.B18AE80F.Controls.Add(this.metroButton74);
		this.B18AE80F.Controls.Add(this.EC9F302A);
		this.B18AE80F.Controls.Add(this.D7992A33);
		this.B18AE80F.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B18AE80F.Location = new System.Drawing.Point(1, 120);
		this.B18AE80F.Name = "panel2";
		this.B18AE80F.Size = new System.Drawing.Size(187, 347);
		this.B18AE80F.TabIndex = 14;
		this.metroButton40.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton40.Location = new System.Drawing.Point(17, 0);
		this.metroButton40.Name = "metroButton40";
		this.metroButton40.Size = new System.Drawing.Size(151, 26);
		this.metroButton40.TabIndex = 7;
		this.metroButton40.Text = "Đọc thông báo";
		this.metroButton40.Click += new System.EventHandler(BA2D0C8C);
		this.metroButton42.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton42.Location = new System.Drawing.Point(17, 29);
		this.metroButton42.Name = "metroButton42";
		this.metroButton42.Size = new System.Drawing.Size(151, 26);
		this.metroButton42.TabIndex = 7;
		this.metroButton42.Text = "Tương tác Newsfeed";
		this.metroButton42.Click += new System.EventHandler(FAA84010);
		this.metroButton47.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton47.Location = new System.Drawing.Point(17, 87);
		this.metroButton47.Name = "metroButton47";
		this.metroButton47.Size = new System.Drawing.Size(151, 26);
		this.metroButton47.TabIndex = 10;
		this.metroButton47.Text = "Xác nhận kết bạn";
		this.metroButton47.Click += new System.EventHandler(metroButton47_Click);
		this.metroButton51.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton51.Location = new System.Drawing.Point(17, 261);
		this.metroButton51.Name = "metroButton51";
		this.metroButton51.Size = new System.Drawing.Size(151, 26);
		this.metroButton51.TabIndex = 2;
		this.metroButton51.Text = "Xem Watch";
		this.metroButton51.Click += new System.EventHandler(FC264329);
		this.metroButton44.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton44.Location = new System.Drawing.Point(17, 116);
		this.metroButton44.Name = "metroButton44";
		this.metroButton44.Size = new System.Drawing.Size(151, 26);
		this.metroButton44.TabIndex = 7;
		this.metroButton44.Text = "Tham gia nhóm theo ID";
		this.metroButton44.Click += new System.EventHandler(DB14C9A9);
		this.metroButton46.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton46.Location = new System.Drawing.Point(17, 58);
		this.metroButton46.Name = "metroButton46";
		this.metroButton46.Size = new System.Drawing.Size(151, 26);
		this.metroButton46.TabIndex = 9;
		this.metroButton46.Text = "Tương tác nhóm v2";
		this.metroButton46.Click += new System.EventHandler(metroButton46_Click);
		this.metroButton50.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton50.Location = new System.Drawing.Point(17, 232);
		this.metroButton50.Name = "metroButton50";
		this.metroButton50.Size = new System.Drawing.Size(151, 26);
		this.metroButton50.TabIndex = 1;
		this.metroButton50.Text = "Xem Story";
		this.metroButton50.Click += new System.EventHandler(metroButton50_Click);
		this.F08E61BC.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F08E61BC.Location = new System.Drawing.Point(17, 145);
		this.F08E61BC.Name = "metroButton52";
		this.F08E61BC.Size = new System.Drawing.Size(151, 26);
		this.F08E61BC.TabIndex = 0;
		this.F08E61BC.Text = "Tham gia nhóm từ khóa";
		this.F08E61BC.Click += new System.EventHandler(F08E61BC_Click);
		this.BD94DE25.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BD94DE25.Location = new System.Drawing.Point(17, 174);
		this.BD94DE25.Name = "metroButton54";
		this.BD94DE25.Size = new System.Drawing.Size(151, 26);
		this.BD94DE25.TabIndex = 0;
		this.BD94DE25.Text = "Kết bạn theo từ khóa";
		this.BD94DE25.Click += new System.EventHandler(BD94DE25_Click);
		this.metroButton55.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton55.Location = new System.Drawing.Point(17, 203);
		this.metroButton55.Name = "metroButton55";
		this.metroButton55.Size = new System.Drawing.Size(151, 26);
		this.metroButton55.TabIndex = 1;
		this.metroButton55.Text = "Kết bạn theo gợi ý";
		this.metroButton55.Click += new System.EventHandler(metroButton55_Click);
		this.metroButton74.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton74.Location = new System.Drawing.Point(17, 319);
		this.metroButton74.Name = "metroButton74";
		this.metroButton74.Size = new System.Drawing.Size(151, 26);
		this.metroButton74.TabIndex = 11;
		this.metroButton74.Text = "Xóa nhật ký hoạt động";
		this.metroButton74.Click += new System.EventHandler(metroButton74_Click);
		this.EC9F302A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EC9F302A.Location = new System.Drawing.Point(17, 290);
		this.EC9F302A.Name = "metroButton53";
		this.EC9F302A.Size = new System.Drawing.Size(151, 26);
		this.EC9F302A.TabIndex = 3;
		this.EC9F302A.Text = "Tham gia nhóm gợi ý";
		this.EC9F302A.Click += new System.EventHandler(EC9F302A_Click);
		this.D7992A33.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D7992A33.Location = new System.Drawing.Point(17, 116);
		this.D7992A33.Name = "metroButton1";
		this.D7992A33.Size = new System.Drawing.Size(151, 26);
		this.D7992A33.TabIndex = 0;
		this.D7992A33.Text = "Seeding bằng Video";
		this.D7992A33.Visible = false;
		this.D7992A33.Click += new System.EventHandler(D7992A33_Click);
		this.B9B0EF09.Image = Resources.E1B00703;
		this.B9B0EF09.Location = new System.Drawing.Point(18, 22);
		this.B9B0EF09.Name = "pictureBox8";
		this.B9B0EF09.Size = new System.Drawing.Size(151, 83);
		this.B9B0EF09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.B9B0EF09.TabIndex = 1;
		this.B9B0EF09.TabStop = false;
		this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.groupBox6.Controls.Add(this.pictureBox7);
		this.groupBox6.Controls.Add(this.DD3D4930);
		this.groupBox6.Location = new System.Drawing.Point(976, 3);
		this.groupBox6.Name = "groupBox6";
		this.groupBox6.Size = new System.Drawing.Size(189, 472);
		this.groupBox6.TabIndex = 10;
		this.groupBox6.TabStop = false;
		this.groupBox6.Text = "Chư\u0301c năng kha\u0301c";
		this.pictureBox7.Image = Resources.D1A326A0;
		this.pictureBox7.Location = new System.Drawing.Point(18, 22);
		this.pictureBox7.Name = "pictureBox7";
		this.pictureBox7.Size = new System.Drawing.Size(151, 83);
		this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox7.TabIndex = 1;
		this.pictureBox7.TabStop = false;
		this.DD3D4930.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.DD3D4930.AutoScroll = true;
		this.DD3D4930.Controls.Add(this.metroButton75);
		this.DD3D4930.Controls.Add(this.metroButton64);
		this.DD3D4930.Controls.Add(this.C9A05036);
		this.DD3D4930.Controls.Add(this.metroButton71);
		this.DD3D4930.Controls.Add(this.button3);
		this.DD3D4930.Controls.Add(this.button6);
		this.DD3D4930.Controls.Add(this.button9);
		this.DD3D4930.Controls.Add(this.B2BFFB05);
		this.DD3D4930.Controls.Add(this.A62EE913);
		this.DD3D4930.Controls.Add(this.EEB5E7A8);
		this.DD3D4930.Controls.Add(this.button1);
		this.DD3D4930.Controls.Add(this.D3A6AB30);
		this.DD3D4930.Controls.Add(this.FD3733A7);
		this.DD3D4930.Controls.Add(this.A1127D22);
		this.DD3D4930.Controls.Add(this.metroButton28);
		this.DD3D4930.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DD3D4930.Location = new System.Drawing.Point(1, 120);
		this.DD3D4930.Name = "panel8";
		this.DD3D4930.Size = new System.Drawing.Size(187, 347);
		this.DD3D4930.TabIndex = 14;
		this.metroButton75.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton75.Location = new System.Drawing.Point(17, 203);
		this.metroButton75.Name = "metroButton75";
		this.metroButton75.Size = new System.Drawing.Size(151, 26);
		this.metroButton75.TabIndex = 13;
		this.metroButton75.Text = "Kháng spam";
		this.metroButton75.Click += new System.EventHandler(metroButton75_Click);
		this.metroButton64.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton64.Location = new System.Drawing.Point(17, 174);
		this.metroButton64.Name = "metroButton64";
		this.metroButton64.Size = new System.Drawing.Size(151, 26);
		this.metroButton64.TabIndex = 11;
		this.metroButton64.Text = "Xóa bài trên page";
		this.metroButton64.Click += new System.EventHandler(EA185A11);
		this.C9A05036.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C9A05036.Location = new System.Drawing.Point(17, 232);
		this.C9A05036.Name = "metroButton60";
		this.C9A05036.Size = new System.Drawing.Size(151, 26);
		this.C9A05036.TabIndex = 7;
		this.C9A05036.Text = "Chế độ chuyên nghiệp";
		this.C9A05036.Click += new System.EventHandler(C9A05036_Click);
		this.metroButton71.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton71.Location = new System.Drawing.Point(17, 203);
		this.metroButton71.Name = "metroButton71";
		this.metroButton71.Size = new System.Drawing.Size(151, 26);
		this.metroButton71.TabIndex = 7;
		this.metroButton71.Text = "Report";
		this.metroButton71.Visible = false;
		this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button3.Location = new System.Drawing.Point(17, 261);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(151, 26);
		this.button3.TabIndex = 7;
		this.button3.Text = "Tạo page";
		this.button3.Click += new System.EventHandler(FF239336);
		this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button6.Location = new System.Drawing.Point(17, 290);
		this.button6.Name = "button6";
		this.button6.Size = new System.Drawing.Size(151, 26);
		this.button6.TabIndex = 10;
		this.button6.Text = "Unlock profile";
		this.button6.Click += new System.EventHandler(button6_Click);
		this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button9.Location = new System.Drawing.Point(17, 116);
		this.button9.Name = "button9";
		this.button9.Size = new System.Drawing.Size(151, 26);
		this.button9.TabIndex = 10;
		this.button9.Text = "Hủy liên kết Instagram";
		this.button9.Click += new System.EventHandler(B7B24602);
		this.B2BFFB05.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B2BFFB05.Location = new System.Drawing.Point(17, 87);
		this.B2BFFB05.Name = "metroButton63";
		this.B2BFFB05.Size = new System.Drawing.Size(151, 26);
		this.B2BFFB05.TabIndex = 10;
		this.B2BFFB05.Text = "Liên kết Instagram";
		this.B2BFFB05.Click += new System.EventHandler(B2BFFB05_Click);
		this.A62EE913.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A62EE913.Location = new System.Drawing.Point(17, 145);
		this.A62EE913.Name = "metroButton30";
		this.A62EE913.Size = new System.Drawing.Size(151, 26);
		this.A62EE913.TabIndex = 3;
		this.A62EE913.Text = "Xóa bài trên tường";
		this.A62EE913.Click += new System.EventHandler(A62EE913_Click);
		this.EEB5E7A8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EEB5E7A8.Location = new System.Drawing.Point(17, 58);
		this.EEB5E7A8.Name = "metroButton57";
		this.EEB5E7A8.Size = new System.Drawing.Size(151, 26);
		this.EEB5E7A8.TabIndex = 6;
		this.EEB5E7A8.Text = "Hủy like page";
		this.EEB5E7A8.Click += new System.EventHandler(EEB5E7A8_Click);
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Location = new System.Drawing.Point(17, 203);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(151, 26);
		this.button1.TabIndex = 8;
		this.button1.Text = "Kết bạn vip";
		this.D3A6AB30.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D3A6AB30.LinkColor = System.Drawing.Color.Gray;
		this.D3A6AB30.Location = new System.Drawing.Point(14, 322);
		this.D3A6AB30.Name = "linkLabel1";
		this.D3A6AB30.Size = new System.Drawing.Size(151, 20);
		this.D3A6AB30.TabIndex = 14;
		this.D3A6AB30.TabStop = true;
		this.D3A6AB30.Text = "Xem thêm...";
		this.D3A6AB30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D3A6AB30.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(D3A6AB30_LinkClicked);
		this.FD3733A7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FD3733A7.Location = new System.Drawing.Point(17, 0);
		this.FD3733A7.Name = "metroButton32";
		this.FD3733A7.Size = new System.Drawing.Size(151, 26);
		this.FD3733A7.TabIndex = 0;
		this.FD3733A7.Text = "Ti\u0300m kiê\u0301m Google";
		this.FD3733A7.Click += new System.EventHandler(CFB4FE2D);
		this.A1127D22.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A1127D22.Location = new System.Drawing.Point(17, 29);
		this.A1127D22.Name = "metroButton33";
		this.A1127D22.Size = new System.Drawing.Size(151, 26);
		this.A1127D22.TabIndex = 0;
		this.A1127D22.Text = "Truy cập Website";
		this.A1127D22.Click += new System.EventHandler(FC987F0A);
		this.metroButton28.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton28.Location = new System.Drawing.Point(17, 0);
		this.metroButton28.Name = "metroButton28";
		this.metroButton28.Size = new System.Drawing.Size(151, 26);
		this.metroButton28.TabIndex = 2;
		this.metroButton28.Text = "Backup dư\u0303 liê\u0323u";
		this.E18D5220.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.E18D5220.Controls.Add(this.panel5);
		this.E18D5220.Controls.Add(this.D19E5601);
		this.E18D5220.Location = new System.Drawing.Point(392, 3);
		this.E18D5220.Name = "groupBox4";
		this.E18D5220.Size = new System.Drawing.Size(189, 472);
		this.E18D5220.TabIndex = 7;
		this.E18D5220.TabStop = false;
		this.E18D5220.Text = "Chức năng Bạn bè - Nhóm";
		this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.panel5.AutoScroll = true;
		this.panel5.Controls.Add(this.metroButton38);
		this.panel5.Controls.Add(this.DD0AF325);
		this.panel5.Controls.Add(this.CB3E60BB);
		this.panel5.Controls.Add(this.D98686B5);
		this.panel5.Controls.Add(this.D60FE925);
		this.panel5.Controls.Add(this.metroButton13);
		this.panel5.Controls.Add(this.metroButton18);
		this.panel5.Controls.Add(this.F88A861E);
		this.panel5.Controls.Add(this.BA2E7510);
		this.panel5.Controls.Add(this.metroButton39);
		this.panel5.Controls.Add(this.metroButton9);
		this.panel5.Controls.Add(this.metroButton41);
		this.panel5.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.panel5.Location = new System.Drawing.Point(1, 120);
		this.panel5.Name = "panel5";
		this.panel5.Size = new System.Drawing.Size(187, 347);
		this.panel5.TabIndex = 14;
		this.metroButton38.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton38.Location = new System.Drawing.Point(17, 261);
		this.metroButton38.Name = "metroButton38";
		this.metroButton38.Size = new System.Drawing.Size(151, 26);
		this.metroButton38.TabIndex = 3;
		this.metroButton38.Text = "Tham gia nhóm theo gợi ý";
		this.metroButton38.Click += new System.EventHandler(metroButton38_Click);
		this.DD0AF325.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DD0AF325.Location = new System.Drawing.Point(17, 290);
		this.DD0AF325.Name = "metroButton23";
		this.DD0AF325.Size = new System.Drawing.Size(151, 26);
		this.DD0AF325.TabIndex = 0;
		this.DD0AF325.Text = "Tham gia nhóm từ khóa";
		this.DD0AF325.Click += new System.EventHandler(DD0AF325_Click);
		this.CB3E60BB.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CB3E60BB.Location = new System.Drawing.Point(17, 0);
		this.CB3E60BB.Name = "metroButton14";
		this.CB3E60BB.Size = new System.Drawing.Size(151, 26);
		this.CB3E60BB.TabIndex = 0;
		this.CB3E60BB.Text = "Kết bạn theo từ khóa";
		this.CB3E60BB.Click += new System.EventHandler(CB3E60BB_Click);
		this.D98686B5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D98686B5.Location = new System.Drawing.Point(17, 319);
		this.D98686B5.Name = "metroButton21";
		this.D98686B5.Size = new System.Drawing.Size(151, 26);
		this.D98686B5.TabIndex = 1;
		this.D98686B5.Text = "Tham gia nhóm theo ID";
		this.D98686B5.Click += new System.EventHandler(D98686B5_Click);
		this.D60FE925.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D60FE925.Location = new System.Drawing.Point(17, 116);
		this.D60FE925.Name = "metroButton15";
		this.D60FE925.Size = new System.Drawing.Size(151, 26);
		this.D60FE925.TabIndex = 5;
		this.D60FE925.Text = "Hủy lời mời đã gửi";
		this.D60FE925.Click += new System.EventHandler(CD85578B);
		this.metroButton13.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton13.Location = new System.Drawing.Point(17, 29);
		this.metroButton13.Name = "metroButton13";
		this.metroButton13.Size = new System.Drawing.Size(151, 26);
		this.metroButton13.TabIndex = 1;
		this.metroButton13.Text = "Kết bạn theo gợi ý";
		this.metroButton13.Click += new System.EventHandler(metroButton13_Click);
		this.metroButton18.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton18.Location = new System.Drawing.Point(17, 58);
		this.metroButton18.Name = "metroButton18";
		this.metroButton18.Size = new System.Drawing.Size(151, 26);
		this.metroButton18.TabIndex = 2;
		this.metroButton18.Text = "Xác nhận kết bạn";
		this.metroButton18.Click += new System.EventHandler(EA93F03C);
		this.F88A861E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F88A861E.Location = new System.Drawing.Point(17, 145);
		this.F88A861E.Name = "metroButton17";
		this.F88A861E.Size = new System.Drawing.Size(151, 26);
		this.F88A861E.TabIndex = 6;
		this.F88A861E.Text = "Hủy kết bạn";
		this.F88A861E.Click += new System.EventHandler(F88A861E_Click);
		this.BA2E7510.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BA2E7510.Location = new System.Drawing.Point(17, 174);
		this.BA2E7510.Name = "metroButton16";
		this.BA2E7510.Size = new System.Drawing.Size(151, 26);
		this.BA2E7510.TabIndex = 3;
		this.BA2E7510.Text = "Kết bạn thành viên nhóm";
		this.BA2E7510.Click += new System.EventHandler(B5BE3130);
		this.metroButton39.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton39.Location = new System.Drawing.Point(17, 232);
		this.metroButton39.Name = "metroButton39";
		this.metroButton39.Size = new System.Drawing.Size(151, 26);
		this.metroButton39.TabIndex = 6;
		this.metroButton39.Text = "Kết bạn với bạn bè của UID";
		this.metroButton39.Click += new System.EventHandler(metroButton39_Click);
		this.metroButton9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton9.Location = new System.Drawing.Point(17, 87);
		this.metroButton9.Name = "metroButton9";
		this.metroButton9.Size = new System.Drawing.Size(151, 26);
		this.metroButton9.TabIndex = 4;
		this.metroButton9.Text = "Kết bạn theo tệp UID";
		this.metroButton9.Click += new System.EventHandler(metroButton9_Click);
		this.metroButton41.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton41.Location = new System.Drawing.Point(17, 203);
		this.metroButton41.Name = "metroButton41";
		this.metroButton41.Size = new System.Drawing.Size(151, 26);
		this.metroButton41.TabIndex = 6;
		this.metroButton41.Text = "Kết bạn với bạn của bạn bè";
		this.metroButton41.Click += new System.EventHandler(metroButton41_Click);
		this.D19E5601.Image = Resources.Bitmap_30;
		this.D19E5601.Location = new System.Drawing.Point(18, 22);
		this.D19E5601.Name = "pictureBox4";
		this.D19E5601.Size = new System.Drawing.Size(151, 83);
		this.D19E5601.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.D19E5601.TabIndex = 1;
		this.D19E5601.TabStop = false;
		this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.groupBox3.Controls.Add(this.pictureBox6);
		this.groupBox3.Controls.Add(this.panel7);
		this.groupBox3.Location = new System.Drawing.Point(587, 3);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(189, 472);
		this.groupBox3.TabIndex = 11;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Chư\u0301c năng Seeding";
		this.pictureBox6.Image = Resources.F486621E;
		this.pictureBox6.Location = new System.Drawing.Point(18, 22);
		this.pictureBox6.Name = "pictureBox6";
		this.pictureBox6.Size = new System.Drawing.Size(151, 83);
		this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox6.TabIndex = 1;
		this.pictureBox6.TabStop = false;
		this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.panel7.AutoScroll = true;
		this.panel7.Controls.Add(this.CE95BA97);
		this.panel7.Controls.Add(this.E584A51B);
		this.panel7.Controls.Add(this.metroButton48);
		this.panel7.Controls.Add(this.metroButton25);
		this.panel7.Controls.Add(this.metroButton31);
		this.panel7.Controls.Add(this.metroButton70);
		this.panel7.Controls.Add(this.metroButton36);
		this.panel7.Controls.Add(this.D892A916);
		this.panel7.Controls.Add(this.C28AF88F);
		this.panel7.Controls.Add(this.metroButton24);
		this.panel7.Controls.Add(this.metroButton27);
		this.panel7.Controls.Add(this.F1290E06);
		this.panel7.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.panel7.Location = new System.Drawing.Point(1, 120);
		this.panel7.Name = "panel7";
		this.panel7.Size = new System.Drawing.Size(187, 347);
		this.panel7.TabIndex = 14;
		this.CE95BA97.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CE95BA97.Location = new System.Drawing.Point(17, 0);
		this.CE95BA97.Name = "metroButton26";
		this.CE95BA97.Size = new System.Drawing.Size(151, 26);
		this.CE95BA97.TabIndex = 0;
		this.CE95BA97.Text = "Tương ta\u0301c ba\u0300i viê\u0301t";
		this.CE95BA97.Click += new System.EventHandler(DAABD923);
		this.E584A51B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E584A51B.Location = new System.Drawing.Point(17, 232);
		this.E584A51B.Name = "metroButton45";
		this.E584A51B.Size = new System.Drawing.Size(151, 26);
		this.E584A51B.TabIndex = 8;
		this.E584A51B.Text = "Đăng status v2";
		this.E584A51B.Click += new System.EventHandler(E584A51B_Click);
		this.metroButton48.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton48.Location = new System.Drawing.Point(17, 261);
		this.metroButton48.Name = "metroButton48";
		this.metroButton48.Size = new System.Drawing.Size(151, 26);
		this.metroButton48.TabIndex = 8;
		this.metroButton48.Text = "Tương tác Livestream";
		this.metroButton48.Click += new System.EventHandler(metroButton48_Click);
		this.metroButton25.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton25.Location = new System.Drawing.Point(17, 29);
		this.metroButton25.Name = "metroButton25";
		this.metroButton25.Size = new System.Drawing.Size(151, 26);
		this.metroButton25.TabIndex = 1;
		this.metroButton25.Text = "Buff Follow ca\u0301 nhân";
		this.metroButton25.Click += new System.EventHandler(C8BB0C97);
		this.metroButton31.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton31.Location = new System.Drawing.Point(17, 58);
		this.metroButton31.Name = "metroButton31";
		this.metroButton31.Size = new System.Drawing.Size(151, 26);
		this.metroButton31.TabIndex = 1;
		this.metroButton31.Text = "Buff Like, Follow page";
		this.metroButton31.Click += new System.EventHandler(metroButton31_Click);
		this.metroButton70.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton70.Location = new System.Drawing.Point(17, 203);
		this.metroButton70.Name = "metroButton70";
		this.metroButton70.Size = new System.Drawing.Size(151, 26);
		this.metroButton70.TabIndex = 6;
		this.metroButton70.Text = "Phản hồi bình luận";
		this.metroButton70.Click += new System.EventHandler(AC1A4BA4);
		this.metroButton36.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton36.Location = new System.Drawing.Point(17, 145);
		this.metroButton36.Name = "metroButton36";
		this.metroButton36.Size = new System.Drawing.Size(151, 26);
		this.metroButton36.TabIndex = 2;
		this.metroButton36.Text = "Đăng bài";
		this.metroButton36.Click += new System.EventHandler(metroButton36_Click);
		this.D892A916.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D892A916.Location = new System.Drawing.Point(17, 319);
		this.D892A916.Name = "metroButton20";
		this.D892A916.Size = new System.Drawing.Size(151, 26);
		this.D892A916.TabIndex = 3;
		this.D892A916.Text = "Mời bạn bè vào nhóm";
		this.D892A916.Click += new System.EventHandler(D892A916_Click);
		this.C28AF88F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C28AF88F.Location = new System.Drawing.Point(17, 174);
		this.C28AF88F.Name = "metroButton37";
		this.C28AF88F.Size = new System.Drawing.Size(151, 26);
		this.C28AF88F.TabIndex = 2;
		this.C28AF88F.Text = "Share bài";
		this.C28AF88F.Click += new System.EventHandler(C28AF88F_Click);
		this.metroButton24.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton24.Location = new System.Drawing.Point(17, 116);
		this.metroButton24.Name = "metroButton24";
		this.metroButton24.Size = new System.Drawing.Size(151, 26);
		this.metroButton24.TabIndex = 3;
		this.metroButton24.Text = "Spam bài viết theo ID";
		this.metroButton24.Click += new System.EventHandler(D380CCAC);
		this.metroButton27.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton27.Location = new System.Drawing.Point(17, 87);
		this.metroButton27.Name = "metroButton27";
		this.metroButton27.Size = new System.Drawing.Size(151, 26);
		this.metroButton27.TabIndex = 3;
		this.metroButton27.Text = "Buff Tin nhắn theo UID";
		this.metroButton27.Click += new System.EventHandler(AD07BCB4);
		this.F1290E06.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F1290E06.Location = new System.Drawing.Point(17, 290);
		this.F1290E06.Name = "metroButton56";
		this.F1290E06.Size = new System.Drawing.Size(151, 26);
		this.F1290E06.TabIndex = 3;
		this.F1290E06.Text = "Mời bạn bè like page";
		this.F1290E06.Click += new System.EventHandler(F1290E06_Click);
		this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.groupBox1.Controls.Add(this.panel4);
		this.groupBox1.Controls.Add(this.pictureBox3);
		this.groupBox1.Location = new System.Drawing.Point(197, 3);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(189, 472);
		this.groupBox1.TabIndex = 6;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Tương tác bài viết";
		this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.panel4.AutoScroll = true;
		this.panel4.Controls.Add(this.C20A913C);
		this.panel4.Controls.Add(this.metroButton29);
		this.panel4.Controls.Add(this.AF29D10F);
		this.panel4.Controls.Add(this.metroButton59);
		this.panel4.Controls.Add(this.D9321601);
		this.panel4.Controls.Add(this.metroButton7);
		this.panel4.Controls.Add(this.metroButton5);
		this.panel4.Controls.Add(this.C9AE0934);
		this.panel4.Controls.Add(this.metroButton6);
		this.panel4.Controls.Add(this.metroButton66);
		this.panel4.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.panel4.Location = new System.Drawing.Point(1, 120);
		this.panel4.Name = "panel4";
		this.panel4.Size = new System.Drawing.Size(187, 347);
		this.panel4.TabIndex = 14;
		this.C20A913C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C20A913C.Location = new System.Drawing.Point(17, 232);
		this.C20A913C.Name = "button8";
		this.C20A913C.Size = new System.Drawing.Size(151, 26);
		this.C20A913C.TabIndex = 13;
		this.C20A913C.Text = "Kiếm tiền Golike";
		this.C20A913C.Click += new System.EventHandler(C20A913C_Click);
		this.metroButton29.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton29.Location = new System.Drawing.Point(17, 0);
		this.metroButton29.Name = "metroButton29";
		this.metroButton29.Size = new System.Drawing.Size(151, 26);
		this.metroButton29.TabIndex = 0;
		this.metroButton29.Text = "Tương tác Newsfeed";
		this.metroButton29.Click += new System.EventHandler(AF023E26);
		this.AF29D10F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AF29D10F.Location = new System.Drawing.Point(17, 29);
		this.AF29D10F.Name = "metroButton34";
		this.AF29D10F.Size = new System.Drawing.Size(151, 26);
		this.AF29D10F.TabIndex = 1;
		this.AF29D10F.Text = "Tương ta\u0301c Bạn bè";
		this.AF29D10F.Click += new System.EventHandler(D286B485);
		this.metroButton59.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton59.Location = new System.Drawing.Point(17, 174);
		this.metroButton59.Name = "metroButton59";
		this.metroButton59.Size = new System.Drawing.Size(151, 26);
		this.metroButton59.TabIndex = 4;
		this.metroButton59.Text = "Bài viết trên tường";
		this.metroButton59.Click += new System.EventHandler(metroButton59_Click);
		this.D9321601.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D9321601.Location = new System.Drawing.Point(17, 58);
		this.D9321601.Name = "metroButton8";
		this.D9321601.Size = new System.Drawing.Size(151, 26);
		this.D9321601.TabIndex = 0;
		this.D9321601.Text = "Bài viết Newsfeed";
		this.D9321601.Click += new System.EventHandler(D9321601_Click);
		this.metroButton7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton7.Location = new System.Drawing.Point(17, 87);
		this.metroButton7.Name = "metroButton7";
		this.metroButton7.Size = new System.Drawing.Size(151, 26);
		this.metroButton7.TabIndex = 1;
		this.metroButton7.Text = "Bài viết Bạn bè";
		this.metroButton7.Click += new System.EventHandler(E40A2510);
		this.metroButton5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton5.Location = new System.Drawing.Point(17, 145);
		this.metroButton5.Name = "metroButton5";
		this.metroButton5.Size = new System.Drawing.Size(151, 26);
		this.metroButton5.TabIndex = 3;
		this.metroButton5.Text = "Bài viết Fanpage";
		this.metroButton5.Click += new System.EventHandler(metroButton5_Click);
		this.C9AE0934.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C9AE0934.Location = new System.Drawing.Point(17, 203);
		this.C9AE0934.Name = "metroButton35";
		this.C9AE0934.Size = new System.Drawing.Size(151, 26);
		this.C9AE0934.TabIndex = 0;
		this.C9AE0934.Text = "Nghỉ giải lao";
		this.C9AE0934.Click += new System.EventHandler(C9AE0934_Click);
		this.metroButton6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton6.Location = new System.Drawing.Point(17, 116);
		this.metroButton6.Name = "metroButton6";
		this.metroButton6.Size = new System.Drawing.Size(151, 26);
		this.metroButton6.TabIndex = 2;
		this.metroButton6.Text = "Bài viết Nhóm";
		this.metroButton6.Click += new System.EventHandler(metroButton6_Click);
		this.metroButton66.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton66.Location = new System.Drawing.Point(17, 232);
		this.metroButton66.Name = "metroButton66";
		this.metroButton66.Size = new System.Drawing.Size(151, 26);
		this.metroButton66.TabIndex = 13;
		this.metroButton66.Text = "Công khai bài gắn thẻ (ẩn)";
		this.metroButton66.Visible = false;
		this.pictureBox3.Image = Resources.Bitmap_1;
		this.pictureBox3.Location = new System.Drawing.Point(18, 22);
		this.pictureBox3.Name = "pictureBox3";
		this.pictureBox3.Size = new System.Drawing.Size(151, 83);
		this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox3.TabIndex = 1;
		this.pictureBox3.TabStop = false;
		this.A330882D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.A330882D.Controls.Add(this.panel3);
		this.A330882D.Controls.Add(this.D32E513A);
		this.A330882D.Location = new System.Drawing.Point(3, 4);
		this.A330882D.Name = "groupBox2";
		this.A330882D.Size = new System.Drawing.Size(189, 472);
		this.A330882D.TabIndex = 5;
		this.A330882D.TabStop = false;
		this.A330882D.Text = "Tương tác cá nhân";
		this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.panel3.AutoScroll = true;
		this.panel3.Controls.Add(this.E9158BA4);
		this.panel3.Controls.Add(this.metroButton61);
		this.panel3.Controls.Add(this.metroButton62);
		this.panel3.Controls.Add(this.A60C6F8A);
		this.panel3.Controls.Add(this.metroButton65);
		this.panel3.Controls.Add(this.F3057BAB);
		this.panel3.Controls.Add(this.metroButton67);
		this.panel3.Controls.Add(this.metroButton68);
		this.panel3.Controls.Add(this.D8A93D08);
		this.panel3.Controls.Add(this.button4);
		this.panel3.Controls.Add(this.button2);
		this.panel3.Controls.Add(this.button5);
		this.panel3.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.panel3.Location = new System.Drawing.Point(1, 120);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(187, 347);
		this.panel3.TabIndex = 14;
		this.E9158BA4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E9158BA4.Location = new System.Drawing.Point(17, 145);
		this.E9158BA4.Name = "metroButton78";
		this.E9158BA4.Size = new System.Drawing.Size(151, 26);
		this.E9158BA4.TabIndex = 5;
		this.E9158BA4.Text = "Chúc mừng sinh nhật";
		this.E9158BA4.Click += new System.EventHandler(E9158BA4_Click);
		this.metroButton61.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton61.Location = new System.Drawing.Point(17, 0);
		this.metroButton61.Name = "metroButton61";
		this.metroButton61.Size = new System.Drawing.Size(151, 26);
		this.metroButton61.TabIndex = 0;
		this.metroButton61.Text = "Đọc thông báo";
		this.metroButton61.Click += new System.EventHandler(metroButton61_Click);
		this.metroButton62.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton62.Location = new System.Drawing.Point(17, 29);
		this.metroButton62.Name = "metroButton62";
		this.metroButton62.Size = new System.Drawing.Size(151, 26);
		this.metroButton62.TabIndex = 1;
		this.metroButton62.Text = "Xem Story";
		this.metroButton62.Click += new System.EventHandler(FA151D14);
		this.A60C6F8A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A60C6F8A.Location = new System.Drawing.Point(17, 203);
		this.A60C6F8A.Name = "metroButton76";
		this.A60C6F8A.Size = new System.Drawing.Size(151, 26);
		this.A60C6F8A.TabIndex = 2;
		this.A60C6F8A.Text = "Đăng status";
		this.A60C6F8A.Click += new System.EventHandler(A60C6F8A_Click);
		this.metroButton65.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton65.Location = new System.Drawing.Point(17, 58);
		this.metroButton65.Name = "metroButton65";
		this.metroButton65.Size = new System.Drawing.Size(151, 26);
		this.metroButton65.TabIndex = 2;
		this.metroButton65.Text = "Xem Watch";
		this.metroButton65.Click += new System.EventHandler(metroButton65_Click);
		this.F3057BAB.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F3057BAB.Location = new System.Drawing.Point(17, 116);
		this.F3057BAB.Name = "metroButton69";
		this.F3057BAB.Size = new System.Drawing.Size(151, 26);
		this.F3057BAB.TabIndex = 4;
		this.F3057BAB.Text = "Chọc bạn bè";
		this.F3057BAB.Click += new System.EventHandler(F7BF6906);
		this.metroButton67.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton67.Location = new System.Drawing.Point(17, 87);
		this.metroButton67.Name = "metroButton67";
		this.metroButton67.Size = new System.Drawing.Size(151, 26);
		this.metroButton67.TabIndex = 3;
		this.metroButton67.Text = "Nhắn tin ba\u0323n be\u0300";
		this.metroButton67.Click += new System.EventHandler(metroButton67_Click);
		this.metroButton68.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton68.Location = new System.Drawing.Point(17, 174);
		this.metroButton68.Name = "metroButton68";
		this.metroButton68.Size = new System.Drawing.Size(151, 26);
		this.metroButton68.TabIndex = 6;
		this.metroButton68.Text = "Phản hồi tin nhắn";
		this.metroButton68.Click += new System.EventHandler(B685C638);
		this.D8A93D08.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D8A93D08.Location = new System.Drawing.Point(17, 232);
		this.D8A93D08.Name = "metroButton77";
		this.D8A93D08.Size = new System.Drawing.Size(151, 26);
		this.D8A93D08.TabIndex = 2;
		this.D8A93D08.Text = "Đăng story";
		this.D8A93D08.Click += new System.EventHandler(D8A93D08_Click);
		this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button4.Location = new System.Drawing.Point(17, 232);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(151, 26);
		this.button4.TabIndex = 7;
		this.button4.Text = "Share page (ẩn)";
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.Location = new System.Drawing.Point(17, 232);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(151, 26);
		this.button2.TabIndex = 7;
		this.button2.Text = "Uptop Post (ẩn)";
		this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button5.Location = new System.Drawing.Point(17, 232);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(151, 26);
		this.button5.TabIndex = 2;
		this.button5.Text = "Đăng reel";
		this.D32E513A.Image = Resources.CEB076B3;
		this.D32E513A.Location = new System.Drawing.Point(18, 22);
		this.D32E513A.Name = "pictureBox2";
		this.D32E513A.Size = new System.Drawing.Size(151, 83);
		this.D32E513A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.D32E513A.TabIndex = 1;
		this.D32E513A.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.groupBox5);
		base.Controls.Add(this.groupBox7);
		base.Controls.Add(this.groupBox6);
		base.Controls.Add(this.E18D5220);
		base.Controls.Add(this.groupBox3);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.A330882D);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "ucThemHanhDongv1";
		base.Size = new System.Drawing.Size(1171, 476);
		this.groupBox5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
		this.panel6.ResumeLayout(false);
		this.groupBox7.ResumeLayout(false);
		this.B18AE80F.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.B9B0EF09).EndInit();
		this.groupBox6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox7).EndInit();
		this.DD3D4930.ResumeLayout(false);
		this.E18D5220.ResumeLayout(false);
		this.panel5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.D19E5601).EndInit();
		this.groupBox3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox6).EndInit();
		this.panel7.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.panel4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
		this.A330882D.ResumeLayout(false);
		this.panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.D32E513A).EndInit();
		base.ResumeLayout(false);
	}
}
