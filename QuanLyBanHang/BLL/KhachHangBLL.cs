using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
   public class KhachHangBLL
    {
        public List<KhachHangDTO> LoadingKhachHang()
        {
            return KhachHangDAL.Instance.LoadingKhachHang();
        }

        public List<KhachHangDTO> FillKhachhang_Ten()
        {

            return KhachHangDAL.Instance.Fill_TenKH();
        }

        public List<KhachHangDTO> Fill_NgayMua(int ngay , int thang , int nam)
        {
            return KhachHangDAL.Instance.Fill_NgayMua(ngay, thang, nam);
        }
        public bool UpdateKH(KhachHangDTO KH)
        {
            if (KH.TenKH == "" || KH.DiaChi == "" || KH.Sdt == null || KH.NgayMua == "") return false;
            return KhachHangDAL.Instance.UpdateKH(KH);
        }

        public bool DeleteKH(string MaKH)
        {
            return KhachHangDAL.Instance.DeleteKH(MaKH);
        }

        public bool InsertKH(KhachHangDTO KH)
        {
            if (KH.TenKH == "" || KH.DiaChi == "" || KH.Sdt == null || KH.NgayMua == ""|| KH.MaKH =="") return false;
            return KhachHangDAL.Instance.InsertKH(KH);
        }

        public List<KhachHangDTO> TimKiemKhachhang_Ten(string tenKH)
        {
            
            return KhachHangDAL.Instance.TimKiemKhachHang(tenKH);
        }

        public string TimMaxKhachHang_ma()
        {
            return KhachHangDAL.Instance.TimMaxKhachHang();
        }
        public int DemKhachHang()
        {
            return KhachHangDAL.Instance.DemKhachHang();
        }

    }
}
