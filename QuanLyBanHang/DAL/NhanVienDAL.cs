using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
   public  class NhanVienDAL
    {
        private static NhanVienDAL intance;

        public static NhanVienDAL Intance
        {
            get { if (intance == null) return intance = new NhanVienDAL(); return intance; }
            private set => intance = value;
        }
        private NhanVienDAL() { }

        public List<NhanVienDTO> LoadingNV()
        {
            string query = "select * from NhanVien";
            List<NhanVienDTO> NV = new List<NhanVienDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO items = new NhanVienDTO(row);
                NV.Add(items);
            }
            return NV;
        }
        public List<NhanVienDTO> FillNameAndImage(string user)
        {
            List<NhanVienDTO> listNV = new List<NhanVienDTO>();
            string query = "fillImgNameNV @user";
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { user });
            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO sp = new NhanVienDTO(row);
                listNV.Add(sp);
            }
            return listNV;
        }
        public bool DeleteNV(string maNV)
        {
            string query = "DeleteNhanVien @maNV";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { maNV });
            return data;
        }

        public bool UpdateNV(NhanVienDTO NV)
        {
            string query = "usp_updateNhanVien @maNV , @tenNV , @gioiTinh , @diaChi , @ntn , @sdt";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { NV.MaNV ,  NV.TenNV , NV.GioiTinh ,NV.DiaChi ,NV.NgaySinh,NV.Sdt });
            return data;
        }

        public bool ThemNV(NhanVienDTO NV)
        {
            string query = "usp_insertNhanVien @maNV , @tenNV , @gioiTinh , @diaChi , @ntn , @hinhAnh , @sdt";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { NV.MaNV, NV.TenNV, NV.GioiTinh, NV.DiaChi, NV.NgaySinh,NV.HinhAnh , NV.Sdt });
            return data;
        }
        public bool ThemNVNoImage(NhanVienDTO NV)
        {
            string query = "usp_insertNVFrom_SignUp @maNV , @tenNV , @gioiTinh , @diaChi , @ntn , @sdt";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { NV.MaNV, NV.TenNV, NV.GioiTinh, NV.DiaChi, NV.NgaySinh, NV.Sdt });
            return data;
        }

        public bool Update_Avatar_NV(string maNV ,string hinhanh)
        {
            string query = "usp_UpdateAvartar_NV @hinhanh , @maNV";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] {hinhanh , maNV});
            return data;
        }

       
        public List<NhanVienDTO> TimKiemNV(string tenNV)
        {
            string query = "TimKiemNhanVien @tenNV";
            List<NhanVienDTO> NV = new List<NhanVienDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query,new object[] { tenNV });
            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO items = new NhanVienDTO(row);
                NV.Add(items);
            }
            return NV;
        }

        public List<NhanVienDTO> FilltenNV()
        {
            string query = "FillTenNhanVien";
            List<NhanVienDTO> NV = new List<NhanVienDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO items = new NhanVienDTO(row);
                NV.Add(items);
            }
            return NV;
        }

        public List<NhanVienDTO> FillGioiTinh_NV(string gioitinh)
        {
            string query = "FillGioiNhanVien @giotinh";
            List<NhanVienDTO> NV = new List<NhanVienDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { gioitinh });
            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO items = new NhanVienDTO(row);
                NV.Add(items);
            }
            return NV;
        }

    }
}
