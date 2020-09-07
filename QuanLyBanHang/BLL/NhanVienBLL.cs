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
   public class NhanVienBLL
    {
        public List<NhanVienDTO> LoadingNhanVien()
        {
            return NhanVienDAL.Intance.LoadingNV();
        }

        public List<NhanVienDTO>FillNhanVien_GioiTinh(string gioiTinh)
        {

            return NhanVienDAL.Intance.FillGioiTinh_NV(gioiTinh);
        }

        public List<NhanVienDTO>FillNhanVien_Ten()
        {
            return NhanVienDAL.Intance.FilltenNV();
        }
        public bool UpdateNV(NhanVienDTO NV)
        {
            if (NV.TenNV == "" || NV.GioiTinh == "" || NV.DiaChi == "" || NV.Sdt == "" || NV.NgaySinh == null) return false;
            return NhanVienDAL.Intance.UpdateNV(NV);
        }
        public bool ThemNV(NhanVienDTO NV)
        {
            if (NV.TenNV == "" || NV.GioiTinh == "" || NV.DiaChi == "" || NV.Sdt == "" || NV.NgaySinh == null || NV.HinhAnh =="") return false;
            return NhanVienDAL.Intance.ThemNV(NV);
        }
        public bool ThemNVNoImage(NhanVienDTO NV)
        {
            if (NV.TenNV == "" || NV.GioiTinh == "" || NV.DiaChi == "" || NV.Sdt == "" || NV.NgaySinh == null) return false;
            return NhanVienDAL.Intance.ThemNVNoImage(NV);
        }


        public bool DeleteNV(string maNv)
        {
            return NhanVienDAL.Intance.DeleteNV(maNv);
        }

   

        public List<NhanVienDTO> TimKiemNV(string tenNV)
        {
          
            return NhanVienDAL.Intance.TimKiemNV(tenNV);
        }
        public List<NhanVienDTO> FillNameAndImage(string user)
        {
            return NhanVienDAL.Intance.FillNameAndImage(user);
        }
        public bool UpdateAvatar_NV(string maNv,string img)
        {
            return NhanVienDAL.Intance.Update_Avatar_NV(maNv, img);
        }
    }
}
