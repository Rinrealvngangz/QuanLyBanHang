using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
   public class KhoBLL
    {
        public List<KhoDTO> LoadingKho()
        {
            return KhoDAL.Instance.LoadingSanPhamKho();
        }
        public bool UpdateSPKho(KhoDTO kho)
        {
            return KhoDAL.Instance.UpdateSPKho(kho);
        }

        public bool UpdateSoluongKho(int soluong , string masp)
        {
            if (soluong == null || masp == "") return false;
            return KhoDAL.Instance.UpdateSoLuongKho(soluong, masp);
        }

        public bool DeleteSPKho(string masp)
        {
            return KhoDAL.Instance.DeleteSPKho(masp);
        }
        public List<KhoDTO> TimKiemSP_Kho(string Tensp)
        {
            return KhoDAL.Instance.listSP_Timkiem(Tensp);
        }
        public List<KhoDTO> FillSP_Kho()
        {
            return KhoDAL.Instance.listSP_fill();
        }
        public bool AddSPKho(KhoDTO kho)
        {
            if (kho.Tensp == "" || kho.MaNCC == "" || kho.Masp == "" || kho.Ngaynhap == null || kho.SoLuong == null || kho.DonGia == null) return false;
            return KhoDAL.Instance.AddSPKho(kho);
        }
        public List<KhoDTO> TimkiemSP_ngaynhap(int ngay, int thang, int nam)
        {
            return KhoDAL.Instance.TimSanPhamTheo_NTN(ngay, thang, nam);
        }
    }
}
