using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
  public  class ChiTietHoaDonDTO
    {
        private string _maHD;
        private string _maSP;
        private string _tenSP;
        private string _size;
        private string _color;
        private string _soluong;
        private int _gia;
        private string _tenNV;
        private string _tenKH;

        public string MaHD { get => _maHD; set => _maHD = value; }
        public string MaSP { get => _maSP; set => _maSP = value; }
        public string TenSP { get => _tenSP; set => _tenSP = value; }
        public string Size { get => _size; set => _size = value; }
        public string Color { get => _color; set => _color = value; }
        public string Soluong { get => _soluong; set => _soluong = value; }
        public int Gia { get => _gia; set => _gia = value; }
        public string TenNV { get => _tenNV; set => _tenNV = value; }
        public string TenKH { get => _tenKH; set => _tenKH = value; }


        public ChiTietHoaDonDTO(string mahd, string masp,string tensp, string size, string color, string soluong , int gia, string tennv,string tenkh)
        {
            _maHD = mahd;
            _maSP = masp;
            _tenSP = tensp;
            _size = size;
            _color = color;
            _soluong = soluong;
            _gia = gia;
            _tenNV = tennv;
            _tenKH = tenkh;
        }
        public ChiTietHoaDonDTO(DataRow row)
        {

     
            _maSP = row["MaSP"].ToString();
            _tenSP = row["TenSP"].ToString();
            _size = row["Size"].ToString();
            _color = row["Color"].ToString();
            _soluong = row["SoLuong"].ToString();
            _gia = int.Parse(row["Gia"].ToString());
            _tenNV = row["TenNV"].ToString();
            _tenKH = row["TenKH"].ToString();
        }

    }
}
