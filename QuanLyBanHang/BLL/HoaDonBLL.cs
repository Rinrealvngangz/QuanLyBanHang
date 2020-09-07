using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BLL
{
    public class HoaDonBLL
    {
        public List<HoaDonDTO> Loading_hoaDon()
        {
            return HoaDonDAL.Instance.LoadingHoaDon();

        }

        public List<HoaDonDTO> TimKiem_hoaDon(string tenKH)
        {
            return HoaDonDAL.Instance.TimKiemHoaDon(tenKH);

        }
        public bool Them_ChitietHD(ChiTietHoaDonDTO items)
        {
            if (items.MaHD == "" || items.MaSP == "" || items.TenSP == "" || items.Size == "" || items.Color == "" || items.Soluong == "" || items.Gia == null || items.TenNV == "" || items.TenKH == "") return false;
            return HoaDonDAL.Instance.ThemChiTiet_HD(items);
        }
        public bool DeleteHoaDon(int mahd)
        {

            return HoaDonDAL.Instance.DeleteHD(mahd);
        }

        public bool DeleteChiTietHoaDon(string mahd)
        {

            return HoaDonDAL.Instance.DeleteChiTietHD(mahd);
        }
        public bool DeleteAllHoaDon()
        {

            return HoaDonDAL.Instance.DeleteAllHD();
        }
        public bool DeleteAllChiTietHoaDon()
        {

            return HoaDonDAL.Instance.DeleteAllChitietHD();
        }
        public List<ChiTietHoaDonDTO> loadingChitietHD_Ma(int maHD)
        {
            return HoaDonDAL.Instance.FillChiTiet_HoaDon_Ma(maHD);


        }
        public List<HoaDonDTO> FillChitietHD_date(int day, int month, int year)
        {
            return HoaDonDAL.Instance.FillHoaDonTheo_Ngay(day, month, year);
        }
    }
}