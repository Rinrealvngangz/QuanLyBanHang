using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DTO
{
    public class SanPham
    {
        public SanPham (string masp, string tensp,int dongia,int soluong, string mahang, string Img)
        {
            maSP = masp;
            tenSP = tensp;
            donGia = dongia;
            SoLuong = soluong;
           maHang = mahang;
            img = Img;
        }
        public SanPham(string masp, string tensp, int dongia, int soluong, string mahang)
        {
            maSP = masp;
            tenSP = tensp;
            donGia = dongia;
            SoLuong = soluong;
            maHang = mahang;
           
        }
        public SanPham(string masp, string tensp, int dongia, int soluong)
        {
            maSP = masp;
            tenSP = tensp;
            donGia = dongia;
            SoLuong = soluong;
          
        }
        public SanPham (DataRow row)
        {
            img = row["Image"].ToString();
            maSP = row["MaSP"].ToString();
             tenSP = row["TenSP"].ToString();
             donGia = int.Parse(row["DonGia"].ToString());
             SoLuong = int.Parse(row["SoLuong"].ToString());
           //  maHang = row["MaHang"].ToString();
            
        }
        private string maSP;

        private string tenSP;

        private int donGia;

        private int soLuong;

        private string maHang;

        private string img;

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaHang { get => maHang; set => maHang = value; }
        public string Img { get => img; set => img = value; }
    }
}
