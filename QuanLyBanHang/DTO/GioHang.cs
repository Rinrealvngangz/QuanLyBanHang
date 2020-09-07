using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class GioHang
    {
        private string _maSP;

        private string _tenSP;

        private string _color;

        private string _size;


        private int _donGia;

        private string _soLuong;

        public string Size { get => _size; set => _size = value; }
        public string MaSP { get => _maSP; set => _maSP = value; }
        public string TenSP { get => _tenSP; set => _tenSP = value; }
        public string Color { get => _color; set => _color = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public string SoLuong { get => _soLuong; set => _soLuong = value; }


        public GioHang(string masp, string tensp, int dongia, string soluong, string color, string size)
        {
            _maSP = masp;
            _tenSP = tensp;
            _donGia = dongia;
            _soLuong = soluong;
            _color = color;
            _size = size;

        }

        public GioHang(DataRow row)
        {

            _maSP = row["MaSP"].ToString();
            _tenSP = row["TenSP"].ToString();
            _size = row["Size"].ToString();
            _color = row["Color"].ToString();
            _soLuong = row["SoLuong"].ToString();
            _donGia = int.Parse(row["Gia"].ToString());

        }
    }
}
