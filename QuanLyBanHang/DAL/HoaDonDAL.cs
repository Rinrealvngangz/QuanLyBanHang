using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class HoaDonDAL
    {
        private static HoaDonDAL instance;

        public static HoaDonDAL Instance
        {
            get
            {
                if (instance == null) return instance = new HoaDonDAL();
                return instance;

            }
            private set => instance = value;

        }
        private HoaDonDAL() { }

        public List<HoaDonDTO> LoadingHoaDon()
        {
            string query = "select * from HoaDon";
            List<HoaDonDTO> hoaDon = new List<HoaDonDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                HoaDonDTO items = new HoaDonDTO(row);
                hoaDon.Add(items);
            }
            return hoaDon;
        }
        public bool ThemChiTiet_HD(ChiTietHoaDonDTO items)
        {
            string query = "usp_ThemChiTiet_HoaDon @maHd , @masp , @tensp , @size , @color , @soluong , @gia , @tenNV , @tenKH";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { items.MaHD, items.MaSP, items.TenSP, items.Size, items.Color, items.Soluong, items.Gia, items.TenNV, items.TenKH});
            return data;       
        }
        public bool DeleteHD(int maHD)
        {
            string query = "usp_DeleteHoaDon @maHD";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { maHD });
            return data;
        }
        public bool DeleteChiTietHD(string maHD)
        {
            string query = "usp_Del_ChitietHoaDon @maHD";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { maHD });
            return data;
        }
        public bool DeleteAllChitietHD()
        {
            string query = "delete from ChiTietHoaDon";
            bool data = DataProvide.Instance.ExcuteNonQuery(query);
            return data;
        }
        public bool DeleteAllHD()
        {
            string query = "usp_DeleteAllHoaDon";
            bool data = DataProvide.Instance.ExcuteNonQuery(query);
            return data;
        }

        public List<ChiTietHoaDonDTO> FillChiTiet_HoaDon_Ma(int mahd)
        {
            string query = "usp_LoadingChiTietHoaDon_Ma @maHD";
            List<ChiTietHoaDonDTO> hoaDon = new List<ChiTietHoaDonDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query,new object[] { mahd} );
            foreach (DataRow row in data.Rows)
            {
                ChiTietHoaDonDTO items = new ChiTietHoaDonDTO(row);
                hoaDon.Add(items);
            }
            return hoaDon;
        }
        public List<HoaDonDTO> TimKiemHoaDon(string tenKH)
        {
            string query = "usp_TimKiemHD_ten @tenKH";
            List<HoaDonDTO> hoaDon = new List<HoaDonDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { tenKH });
            foreach (DataRow row in data.Rows)
            {
                HoaDonDTO items = new HoaDonDTO(row);
                hoaDon.Add(items);
            }
            return hoaDon;
        }
        public List<HoaDonDTO> FillHoaDonTheo_Ngay(int day,int month,int year)
        {
            string query = "usp_fillDateHoaDon @ngay , @thang , @nam";
            List<HoaDonDTO> hoaDon = new List<HoaDonDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { day,month,year });
            foreach (DataRow row in data.Rows)
            {
                HoaDonDTO items = new HoaDonDTO(row);
                hoaDon.Add(items);
            }
            return hoaDon;
        }



    }
}
