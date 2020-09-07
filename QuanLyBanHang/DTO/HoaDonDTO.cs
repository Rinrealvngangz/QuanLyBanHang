using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public class HoaDonDTO
    {
        private int _maHD;
        private string _tenKH;
        private string _tenNV;
        private string _ngayBan;
        private int _tonggia;
        public int MaHD { get => _maHD; set => _maHD = value; }
        public string TenKH { get => _tenKH; set => _tenKH = value; }
        public string TenNV { get => _tenNV; set => _tenNV = value; }
        public string NgayBan { get => _ngayBan; set => _ngayBan = value; }
        public int TongGia { get => _tonggia; set => _tonggia = value; }

        public HoaDonDTO(int maHD ,string tenNV ,string tenKh ,string ntn,int tongia)
        {
            _maHD = maHD;
            _tenNV = tenNV;
            _tenKH = tenKh;
            _ngayBan = ntn;
            _tonggia = tongia;
        }

        public HoaDonDTO(DataRow row)
        {

            _maHD = int.Parse(row["MaHD"].ToString());
            _tenKH = row["TenKH"].ToString();
            _tenNV = row["TenNV"].ToString();
            _ngayBan = row["NgayBan"].ToString();
            _tonggia = int.Parse(row["TongGia"].ToString());
       
        }
    }
}
