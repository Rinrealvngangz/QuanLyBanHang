using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
   public class ThongKeBLL
    {
        public List<ThongKeDTO> LoadingThongKe()
          {
            return ThongKeDAL.Instance.LoadingThongKe();
        }
        public List<ThongKeDTO> FillDate(int day, int month ,int year)
        {
            return ThongKeDAL.Instance.FillDate(day, month, year);
        }
        public int FillMonth(int month, int year)
        {
            return ThongKeDAL.Instance.FillPriceMonth(month, year);
        }
        public int FillPriceYear( int year)
        {
            return ThongKeDAL.Instance.FillPriceYear(year);
        }
        public int FillValueYear(int year)
        {
            return ThongKeDAL.Instance.FillValueYear(year);
        }

    
        public int FillValueMonth(int month ,int year)
        {
            return ThongKeDAL.Instance.FillValueMonth(month ,year);
        }

        public bool ThemThongKe(ThongKeDTO TK)
        {
            return ThongKeDAL.Instance.insertThongKe(TK);

        }
      


    }
}
