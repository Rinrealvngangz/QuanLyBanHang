using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public class ThongTinSPDTO
    {
        private string _maSP;

        private string _color;

        private string _size;

        public ThongTinSPDTO(string masp,string color, string size)
        {
            _maSP = masp;
            _color = color;
            _size = size;
        }

        public ThongTinSPDTO(DataRow row)
        {
            _maSP = row["MaSP"].ToString();
            _size = row["Size"].ToString();
           _color = row["Color"].ToString();
        }
       
        public ThongTinSPDTO() { }

        public string MaSP { get => _maSP; set => _maSP = value; }
        public string Color { get => _color; set => _color = value; }
        public string Size { get => _size; set => _size = value; }
    }
}
