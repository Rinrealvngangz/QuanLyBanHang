using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
  public  class ThongKeDAL
    {
        private static ThongKeDAL instance;

        public static ThongKeDAL Instance
        {
            get
            {
                if (instance == null) return instance = new ThongKeDAL();
                return instance;

            }
            private set => instance = value;

        }
        private ThongKeDAL() { }

        public bool insertThongKe(ThongKeDTO TK)
        {
            string query = "themThongKe @date , @price , @tensp , @valMonth , @valYear";
            bool data = DataProvide.Instance.ExcuteNonQuery(query, new object[] {  TK.Date, TK.Price ,TK.Tensp ,TK.ValueMonth ,TK.ValueYear });
            return data;
        }

        public List<ThongKeDTO> LoadingThongKe ()
        {
           
            string query = "select * from ThongKe";
            List<ThongKeDTO> TK = new List<ThongKeDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query);
            
            foreach (DataRow row in data.Rows)
            {
                ThongKeDTO items = new ThongKeDTO(row);
                TK.Add(items);
            }
            return TK;
                   
        }
        public List<ThongKeDTO> FillDate(int ngay, int thang, int nam)
        {

            string query = "usp_fillDateThongke @ngay , @thang , @nam";
            List<ThongKeDTO> TK = new List<ThongKeDTO>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { ngay, thang, nam });

            foreach (DataRow row in data.Rows)
            {
                ThongKeDTO items = new ThongKeDTO(row);
                TK.Add(items);
            }
            return TK;


        }

        public int FillPriceMonth(int thang, int nam)
        {

            string query = "usp_ThongKePrice @thang , @nam";
            int data = DataProvide.Instance.ExcuteScalar(query, new object[] { thang, nam });
            return data;

        }
        public int FillValueMonth(int thang ,int nam)
        {

            string query = "usp_valueThang @thang , @nam";
            int data = DataProvide.Instance.ExcuteScalar(query, new object[] {thang , nam });
            return data;

        }
        public int FillPriceYear(int nam)
        {

            string query = "usp_ThongKePriceYear @nam";
            int data = DataProvide.Instance.ExcuteScalar(query, new object[] { nam });
            return data;

        }
        
        public int FillValueYear(int nam)
        {

            string query = "usp_valueYear @nam";
            int data = DataProvide.Instance.ExcuteScalar(query, new object[] { nam });
            return data;

        }
        
     



    }
}
