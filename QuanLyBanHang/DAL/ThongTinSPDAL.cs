using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
   public  class ThongTinSPDAL
    {
        private static ThongTinSPDAL instance;

        public static ThongTinSPDAL Instance {
            get { if (instance == null) instance = new ThongTinSPDAL(); return instance; }
           private set => instance = value;
        
        }
        private ThongTinSPDAL() { }

        public bool ThemSize_Color(ThongTinSPDTO items)
        {
            bool kq;
            string query = "usp_ThemSize_Color_SanPham @masp , @color , @size";
            kq = DataProvide.Instance.ExcuteNonQuery(query, new object[] {items.MaSP,items.Color,items.Size});
            return kq ;
        }
        public List<ThongTinSPDTO> LoadingColor(string masp ,string size)
        {
            string query = "usp_LayThongTinSPTheoMa @masp , @size";
            List<ThongTinSPDTO> ListTTSP = new List<ThongTinSPDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] {masp,size});
            foreach( DataRow row in data.Rows)
            {
                ThongTinSPDTO itemsRow = new ThongTinSPDTO();
                itemsRow.Color = row["Color"].ToString();
                ListTTSP.Add(itemsRow);
            }
            return ListTTSP;
        }

        public List<ThongTinSPDTO> LoadingSize( string masp)
        {
            string query = "usp_loadindSize @masp";
            List<ThongTinSPDTO> ListTTSP = new List<ThongTinSPDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { masp });
            foreach (DataRow row in data.Rows)
            {
                ThongTinSPDTO itemsRow = new ThongTinSPDTO();
                itemsRow.Size = row["Size"].ToString();
                ListTTSP.Add(itemsRow);
            }
            return ListTTSP;
        }
    }
}
