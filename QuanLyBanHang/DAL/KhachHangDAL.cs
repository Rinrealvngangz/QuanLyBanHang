using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
   public class KhachHangDAL
    {
        private static KhachHangDAL instance;

        public static KhachHangDAL Instance
        {
            get
            {
                if (instance == null) return instance = new KhachHangDAL();
                return instance;

            }
            private set => instance = value;

        }
        private KhachHangDAL() { }

        public List<KhachHangDTO> LoadingKhachHang()
        {
            List<KhachHangDTO> ListKH = new List<KhachHangDTO>();
            string query = "select * from KhachHang";
            DataTable data = DataProvide.Instance.ExcuteQuery(query);
            foreach (DataRow items in data.Rows)
            {
                KhachHangDTO Kh = new KhachHangDTO(items);
                ListKH.Add(Kh);
            }
            return ListKH;
        }
        public List<KhachHangDTO> TimKiemKhachHang(string tenKH)
        {
            List<KhachHangDTO> ListKH = new List<KhachHangDTO>();
            string query = "TimKiemKH @tenKH";
            DataTable data = DataProvide.Instance.ExcuteQuery(query,new object[]{tenKH});
            foreach (DataRow items in data.Rows)
            {
                KhachHangDTO Kh = new KhachHangDTO(items);
                ListKH.Add(Kh);
            }
            return ListKH;
        }
        public List<KhachHangDTO> Fill_NgayMua(int ngay ,int thang ,int nam)
        {
            List<KhachHangDTO> ListKH = new List<KhachHangDTO>();
            string query = "usp_fillDateKhachHang @ngay , @thang , @nam";
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { ngay,thang,nam });
            foreach (DataRow items in data.Rows)
            {
                KhachHangDTO Kh = new KhachHangDTO(items);
                ListKH.Add(Kh);
            }
            return ListKH;
        }

        public List<KhachHangDTO> Fill_TenKH()
        {
            List<KhachHangDTO> ListKH = new List<KhachHangDTO>();
            string query = "FillTenKH";
            DataTable data = DataProvide.Instance.ExcuteQuery(query);
            foreach (DataRow items in data.Rows)
            {
                KhachHangDTO Kh = new KhachHangDTO(items);
                ListKH.Add(Kh);
            }
            return ListKH;
        }

        public bool UpdateKH( KhachHangDTO KH)
        {
            string query = "UpdateKhachHang @maKH , @tenKH , @diaChi , @sdt";
            bool data = DataProvide.Instance.ExcuteNonQuery(query,new object[] { KH.MaKH,KH.TenKH,KH.DiaChi,KH.Sdt});
            return data ;
        }
        public bool DeleteKH(string MaKH)
        {
            string query = "DeleteKhachHang @maKH";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { MaKH });
            return data;
        }

        public bool InsertKH(KhachHangDTO KH)
        {
            string query = "InsertKhachHang @maKH , @tenKH , @diaChi , @sdt , @ngaymua";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] { KH.MaKH, KH.TenKH, KH.DiaChi, KH.Sdt, KH.NgayMua });
            return data;
        }
        public string TimMaxKhachHang()
        {
            string query = "TimMaxKhachHang_Ma";
            string data =  DataProvide.Instance.ExcuteScalarString(query);
            return data;
        }
        public int DemKhachHang()
        {
            string query = "DemKhachHang_Ma";
            int data = DataProvide.Instance.ExcuteScalar(query);
            return data;
        }
    }
}
