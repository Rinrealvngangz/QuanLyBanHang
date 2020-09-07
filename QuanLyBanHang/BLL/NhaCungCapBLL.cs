using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
   public class NhaCungCapBLL
    {
        public List<NhaCungCapDTO>LoadingNCC()
        {
            return NhaCungCapDAL.Intance.LoadingNCC();
        }
        public List<NhaCungCapDTO> LoadingNCC_Ma(string maNcc)
        {
            return NhaCungCapDAL.Intance.listNCC_Ma(maNcc);
        }
        public bool DeleteNCC(string maNCC)
        {
            if (maNCC == "") return false;
            return NhaCungCapDAL.Intance.DeleteNCC(maNCC);
        }
        public bool UpdateNCC(NhaCungCapDTO NCC)
        {
            if (NCC.TenNCC == "" || NCC.Sdt == "" || NCC.DiaChi == "" || NCC.Hang == "") return false;
            return NhaCungCapDAL.Intance.UpdateNCC(NCC);
        }
        public bool insertNCC(NhaCungCapDTO NCC)
        {
            if (NCC.TenNCC == "" || NCC.Sdt == "" || NCC.DiaChi == "" || NCC.Hang == "" || NCC.HinhAnh ==null) return false;
                      
            return NhaCungCapDAL.Intance.insertNCC(NCC);
        }
        public bool UpdateLogo(string logo ,string maNCC)
        {
            return NhaCungCapDAL.Intance.UpdateLogo(logo,maNCC);
        }
        public List<NhaCungCapDTO> TimkiemNCC(string tenNCC)
        {
            return NhaCungCapDAL.Intance.timKiemNCC(tenNCC);
        }
        public List<NhaCungCapDTO> FillNCCTheo_Hang(string hang)
        {
            return NhaCungCapDAL.Intance.FillNCCTheo_Hang(hang);
        }
    }
}
