using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DAL;
using DTO;
namespace BLL
{
   public class SanPhamBLL
    {
        public List<SanPham>  LoadingSanPham()
        {
            return SanPhamDAL.Instance.LoadingSanPham();
        }
    
        public bool UpdateHinhAnh(string img , string masp)
        {
            return SanPhamDAL.Instance.UpdateHinhAnh(img, masp);
        }

        public bool ThemSP_Kho(SanPham sp)
        {
            if (sp.MaSP == "" || sp.TenSP == "" || sp.DonGia == null || sp.SoLuong == null || sp.MaHang == "") return false;

            return SanPhamDAL.Instance.ThemSPTuKho(sp);
        }

        public bool ThemSize_Color(ThongTinSPDTO items)
        {
           if( items.Color.Length ==0 && items.Size.Length ==0) return false;
           
            return ThongTinSPDAL.Instance.ThemSize_Color(items);

        }
        public List<ThongTinSPDTO>LoadingColorTheoMa(string masp, string size)
        {
            return ThongTinSPDAL.Instance.LoadingColor(masp,size);
        }

        public List<ThongTinSPDTO> LoadingSizeTheoMa(string masp)
        {
            return ThongTinSPDAL.Instance.LoadingSize(masp);
        }
        public List<SanPham> Fill_sp_TheoTen(string tenhang)
        {
            return SanPhamDAL.Instance.FillTenHang(tenhang);
        }
        public List<Hang>LoadingHang()
        {
            return SanPhamDAL.Instance.LoadingMaHang();
        }

        public bool UpdateSanPham(SanPham sp)
        {
            return SanPhamDAL.Instance.UpdateSanPham(sp);
        }
        public bool DeleteSanPham(string ma)
        {
            if (ma == "") return false;
            return SanPhamDAL.Instance.DeleteSanPham(ma);
        }

        public List<SanPham> TimKiemSP(string tensp)
        {
         
            return SanPhamDAL.Instance.TimKiemSP(tensp);
        }
        public int DemSLTTSP(string masp)
        {
            return SanPhamDAL.Instance.DemSLTrongTTSP(masp);
        }

        public bool Them_GioHang(GioHang sp)
        {
            if (sp.MaSP == "" || sp.TenSP == "" || sp.Size == "" || sp.Color == "" || sp.DonGia == null || sp.SoLuong == "") return false;
                    return SanPhamDAL.Instance.ThemSP_GioHang(sp);
        }

        public List<GioHang> Loading_Gio_SP()
        {

            return SanPhamDAL.Instance.Loading_GioHang();
        }

        public int DemHoaDon_Ma()
        {
            return SanPhamDAL.Instance.DemHoaDon();
        }

        public bool Them_HoaDon(HoaDonDTO hd)
        {
            if (hd.TenKH == "" || hd.TenNV == "" || hd.TongGia == null) return false;
            return SanPhamDAL.Instance.ThemHoaDon(hd);

        }

        public bool DeleteGiohang(string masp ,string size, string color ,string soluong)
        {
            if (masp == "") return false;
            return SanPhamDAL.Instance.DeleteGioHang(masp,size ,color ,soluong);
        }
        public int TinhTongTien()
        {
            return SanPhamDAL.Instance.TinhTongtien();
        }
        public bool DeleteAllGioHang()
        {
            return SanPhamDAL.Instance.DeleteAll();
        }
        public int CheckHoaDon()
        {
            return SanPhamDAL.Instance.CheckHD();
        }
        public string DemGioHang()
        {
            return SanPhamDAL.Instance.DemGioHang();
        }
     
    }
}
