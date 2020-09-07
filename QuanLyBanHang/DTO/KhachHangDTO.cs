using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public class KhachHangDTO
    {
        private string _tenKH;

        private string _maKH;

        private string _diaChi;

        private int _sdt;

        private string _ngayMua;

        public string TenKH { get => _tenKH; set => _tenKH = value; }
        public string MaKH { get => _maKH; set => _maKH = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public int Sdt { get => _sdt; set => _sdt = value; }
        public string NgayMua { get => _ngayMua; set => _ngayMua = value; }

        public KhachHangDTO(string maKH, string tenKh, string diachi, int sdt, string ngaymua)
        {
            _tenKH = tenKh;
            _maKH = maKH;

            _diaChi = diachi;

            _sdt = sdt;

            _ngayMua = ngaymua;

        }
        public KhachHangDTO(string maKH, string tenKh, string diachi, int sdt)
        {
            _tenKH = tenKh;
            _maKH = maKH;

            _diaChi = diachi;

            _sdt = sdt;

          
        }

        public KhachHangDTO(DataRow row)
        {
           
            _maKH = row["MaKH"].ToString();
            _tenKH = row["TenKH"].ToString();
            _diaChi = row["DiaChi"].ToString();
            _sdt = int.Parse(row["SDT"].ToString());
            _ngayMua = row["NgayMua"].ToString();
          
        }
    }
}
