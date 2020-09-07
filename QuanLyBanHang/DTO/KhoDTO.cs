using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public class KhoDTO
    {
        private string _tensp;

        private string _masp;

        private string _maNCC;

        private int _soLuong;

        private int _gia;

        private DateTime _ngaynhap;

        public string Tensp { get => _tensp; set => _tensp = value; }
        public string Masp { get => _masp; set => _masp = value; }
        public string MaNCC { get => _maNCC; set => _maNCC = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public int DonGia { get => _gia; set => _gia = value; }
        public DateTime Ngaynhap { get => _ngaynhap; set => _ngaynhap = value; }

        public KhoDTO (string masp, string tensp, string maNcc , int soluong , int gia)
        {
            _tensp = tensp;
            _masp = masp;
            _maNCC = maNcc;
            _gia = gia;
            _soLuong = soluong;


        }
        public KhoDTO(string masp, string tensp, string maNcc, int soluong, int gia, DateTime ntn)
        {
            _tensp = tensp;
            _masp = masp;
            _maNCC = maNcc;
            _gia = gia;
            _soLuong = soluong;
            _ngaynhap = ntn;

        }
        public KhoDTO(DataRow row)
        {
            _tensp = row["TenSP"].ToString();
            _masp = row["MaSP"].ToString();
            _maNCC = row["MaNCC"].ToString();
            _soLuong = int.Parse(row["Soluong"].ToString());
            _gia = int.Parse(row["DonGia"].ToString());         
            _ngaynhap = DateTime.Parse(row["NgayNhap"].ToString());
        }
    }
}
