using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
   public class NhaCungCapDAL
    {
        private static NhaCungCapDAL intance;

        public static NhaCungCapDAL Intance {
            get { if (intance == null) return intance = new NhaCungCapDAL(); return intance; }
           private set => intance = value;
        }
        private NhaCungCapDAL() { }

        public List<NhaCungCapDTO> LoadingNCC()
        {
            string query = "select * from Supplier";
            List<NhaCungCapDTO> NCC = new List<NhaCungCapDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query);
            foreach( DataRow row in data.Rows)
            {
                NhaCungCapDTO items = new NhaCungCapDTO(row);
                NCC.Add(items);
            }
            return NCC;
        }
        public bool DeleteNCC(string maNCC)
        {
            string query = "DeleteNCC @maNCC";
            bool data = DataProvide.Instance.ExcuteNonQuery(query,new object[] { maNCC});
            return data;
        }
        public bool UpdateNCC(NhaCungCapDTO NCC)
        {
            string query = "UpdateNCC @maNCC , @tenNCC , @diachi , @sdt , @hang";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { NCC.MaNCC, NCC.TenNCC, NCC.DiaChi, NCC.Sdt, NCC.Hang });
            return data;
        }
        public bool insertNCC(NhaCungCapDTO NCC)
        {
            string query = "usp_ThemNCC @maNCC , @tenNCC , @diachi , @sdt , @hang , @hinhAnh";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { NCC.MaNCC, NCC.TenNCC, NCC.DiaChi, NCC.Sdt, NCC.Hang , NCC.HinhAnh });
            return data;
        }
        public bool UpdateLogo(string logo , string maNCC)
        {
            string query = "UpdateLogo @anh , @maNCC";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { logo,maNCC });
            return data;
        }

        public List<NhaCungCapDTO> timKiemNCC(string tenNCC)
        {
            string query = "TimKiemNCC @tenNCC";
            List<NhaCungCapDTO> NCC = new List<NhaCungCapDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query,new object[] {tenNCC });
            foreach (DataRow row in data.Rows)
            {
                NhaCungCapDTO items = new NhaCungCapDTO(row);
                NCC.Add(items);
            }
            return NCC;
        }

        public List<NhaCungCapDTO> FillNCCTheo_Hang(string hang)
        {
            string query = "FillTheoHang @Hang";
            List<NhaCungCapDTO> NCC = new List<NhaCungCapDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { hang });
            foreach (DataRow row in data.Rows)
            {
                NhaCungCapDTO items = new NhaCungCapDTO(row);
                NCC.Add(items);
            }
            return NCC;
        }
        public List<NhaCungCapDTO> listNCC_Ma(string maNCC)
        {
            string query = "LoadingNCCTheoMa @maNCC";
            List<NhaCungCapDTO> listNCC = new List<NhaCungCapDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { maNCC });
            foreach (DataRow items in data.Rows)
            {
                NhaCungCapDTO NCC = new NhaCungCapDTO(items);
                listNCC.Add(NCC);
            }
            return listNCC;
        }

    }
}
