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
    public class SanPhamDAL
    {
        private static SanPhamDAL instance;

        public static SanPhamDAL Instance {
            get { if (instance == null) instance = new SanPhamDAL(); return instance; }
            private set => instance = value; }

        public List<SanPham> LoadingSanPham()
        {
            string query = "select * from SanPham";
            List<SanPham> ListSP = new List<SanPham>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query);
            foreach (DataRow items in data.Rows)
            {
                SanPham sp = new SanPham(items);
                ListSP.Add(sp);
            }
            return ListSP;
        }
       
        public bool ThemSPTuKho(SanPham sp)
        {
            string query = "themSPtuKho @maSp , @tensp , @dongia , @soluong , @mahang";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { sp.MaSP ,sp.TenSP , sp.DonGia ,sp.SoLuong ,sp.MaHang});

            return data;
        }
        public bool UpdateHinhAnh(string img, string masp)
        {
            string query = "updateHinhAnh @img , @masp";
             bool data = DataProvide.Instance.ExcuteNonQuery(query, new object []{ img, masp });
         
            return data ;
        }

        public List<SanPham> FillTenHang(string tenhang)
        {
            string query = "usp_fillMaHang @tenHang";
            List<SanPham> listFill = new List<SanPham>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { tenhang });

            foreach(DataRow row in data.Rows)
            {
                SanPham items = new SanPham(row);
                listFill.Add(items);
            }
            return listFill;
        }

        public List<Hang> LoadingMaHang()
        {
            string query = "usp_loadingMaHang";
            List<Hang> listHang = new List<Hang>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Hang items = new Hang(row);
                listHang.Add(items);
            }
            return listHang;
        }

        public bool UpdateSanPham (SanPham sp)
        {
            string query = "usp_UpdateSanPham @masp , @tensp , @soluong , @dongia";
           if (sp.TenSP == "" && sp.SoLuong == 0 && sp.DonGia ==0 ) return false;
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { sp.MaSP, sp.TenSP, sp.SoLuong, sp.DonGia });
            return data;
        }

        public bool DeleteSanPham (string ma)
        {
            string query = "usp_DeleteSanPham @masp";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { ma });
            return data;
        }
        public List<SanPham> TimKiemSP(string tensp)
        {
            List<SanPham> listSp = new List<SanPham>();
            string query = "TimKiemSanPham @Tensp";
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { tensp });
            foreach( DataRow row in data.Rows)
            {
                SanPham sp = new SanPham(row);
                listSp.Add(sp);
            }
            return listSp;
        }
       
        public int DemSLTrongTTSP(string masp)
        {
            int sl;
            string query = "DemSoLuongTTSP @masp";
            sl = DataProvide.Instance.ExcuteScalar(query, new object[] { masp });
            return sl;
        }

        public bool ThemSP_GioHang(GioHang sp)
        {
            if (sp.MaSP == "" || sp.TenSP == "" || sp.Size == "" || sp.Color == "" || sp.SoLuong == "" || sp.DonGia == null) return false;
            string query = "usp_insert_GioHang @masp , @tensp , @size , @color , @soluong , @gia";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] {sp.MaSP ,sp.TenSP , sp.Size,sp.Color,sp.SoLuong,sp.DonGia });
          
            return data;
        }
        public List<GioHang> Loading_GioHang()
        {
            List<GioHang> listGio_SP = new List<GioHang>();
            string query = "Select * from GioHang";
            DataTable data = DataProvide.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                GioHang sp = new GioHang(row);
                listGio_SP.Add(sp);
            }
            return listGio_SP;
        }

        public int DemHoaDon()
        {
            string query = "DemHoaDon";
            int data = DataProvide.Instance.ExcuteScalar(query);

            return data;
        }
        public int CheckHD()
        {
            string query = "CountHD";
            int data = DataProvide.Instance.ExcuteScalar(query);
            return data;
        }
        public bool ThemHoaDon(HoaDonDTO hd)
        {
            string query = "usp_Them_HoaDon @maHD , @tenKH , @tenNV , @ntn , @tongGia";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { hd.MaHD, hd.TenKH, hd.TenNV, hd.NgayBan ,hd.TongGia });
            return data;
        }
        public int TinhTongtien()
        {
            string query = "usp_TinhTongGia_Giohang";
            int data = DataProvide.Instance.ExcuteScalar(query);
            return data;
        }
        public bool DeleteGioHang(string masp ,string size ,string color ,string soluong)
        {
            string query = "usp_DeleteGioHang @masp , @size , @color , @soluong";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { masp ,size , color , soluong });
            return data;
        }
        public string DemGioHang()
        {
            string query = "TimMaxSPShell";
            string data = DataProvide.Instance.ExcuteScalarString(query);
            return data;
        }
        public bool DeleteAll()
        {
            string query = "usp_deleteAllGioHang";
            bool data = DataProvide.Instance.ExcuteNonQuery(query);
            return data;
        }
    }
}
