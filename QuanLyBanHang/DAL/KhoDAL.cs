using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
   public class KhoDAL
    {
        private static KhoDAL instance;

        public static KhoDAL Instance {
            get {
                if (instance == null) return instance = new KhoDAL();
                return instance;

            } private set => instance = value; 
        
        }
        public List<KhoDTO> LoadingSanPhamKho()
        {
            List<KhoDTO> ListKho = new List<KhoDTO>();
            string query = "select * from NhapKho";
            DataTable data = DataProvide.Instance.ExcuteQuery(query);
            foreach(DataRow items in data.Rows )
            {
                KhoDTO Kho = new KhoDTO(items);
                ListKho.Add(Kho);
            }
            return ListKho;
        }

        public bool UpdateSPKho(KhoDTO kho)
        {
            string query = "UpdateSPKho @masp , @tensp , @soluong , @dongia , @maNCC";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { kho.Masp, kho.Tensp, kho.SoLuong, kho.DonGia, kho.MaNCC });
            return data;
        }
        public bool UpdateSoLuongKho(int soluong , string masp)
        {
            string query = "UpdateSoLuongKho @soluong , @masp";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] {soluong ,masp });
            return data;
        }

        public bool DeleteSPKho(string masp)
        {
            string query = "DeleteSPKho @masp";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] {masp });
            return data;
        }
        public bool AddSPKho(KhoDTO kho)
        {
            string query = "usp_ThemKho @masp , @tensp , @ntn , @soluong , @maNCC , @gia";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { kho.Masp, kho.Tensp, kho.Ngaynhap ,kho.SoLuong, kho.MaNCC ,  kho.DonGia });
            return data;
        }

        public  List<KhoDTO> listSP_Timkiem (string tensp)
        {
            string query = "usp_TimKiemSanPhamKho @Tensp";
            List<KhoDTO> listKhoTK = new List<KhoDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { tensp });
            foreach(DataRow items in data.Rows)
            {
                KhoDTO kho = new KhoDTO(items);
                listKhoTK.Add(kho);
            }
            return listKhoTK;
        }

        public List<KhoDTO> listSP_fill()
        {
            string query = "usp_FillSP";
            List<KhoDTO> listKhoTK = new List<KhoDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query);
            foreach (DataRow items in data.Rows)
            {
                KhoDTO kho = new KhoDTO(items);
                listKhoTK.Add(kho);
            }
            return listKhoTK;
        }
        public List<KhoDTO> TimSanPhamTheo_NTN( int ngay , int thang , int nam)
        {
            string query = "usp_fillDate @ngay , @thang , @nam";
            List<KhoDTO> listKhoSP = new List<KhoDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { ngay, thang, nam });
            foreach(DataRow row in data.Rows)
            {
                KhoDTO items = new KhoDTO(row);
                listKhoSP.Add(items);
            }
            return listKhoSP;
        }
      
    }
}
