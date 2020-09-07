using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
  public  class ThongKeDTO
    {
       
        private string _tensp;
        private int _price;
        private int _valueYear;
        private int _valueMonth;
        private string _date;

      
        public int Price { get => _price; set => _price = value; }
        public int ValueYear { get => _valueYear; set => _valueYear = value; }
        public int ValueMonth { get => _valueMonth; set => _valueMonth = value; }
        public string Date { get => _date; set => _date = value; }
       
        public string Tensp { get => _tensp; set => _tensp = value; }

        public ThongKeDTO(int price , int ValueYear, string ntn, int valueMonth ,string tensp)
        {
            
            _price = price;
            _valueYear = ValueYear;
            _date = ntn;
            _valueMonth = valueMonth;
            _tensp = tensp;
        }
        public ThongKeDTO(DataRow row)
        {
            
            _price = int.Parse(row["Price"].ToString());
            _valueYear = int.Parse(row["ValMonth"].ToString());
            _date = row["Date"].ToString();
            _valueMonth = int.Parse(row["ValYear"].ToString());
            _tensp = row["TenSP"].ToString();

        }
    }
}
