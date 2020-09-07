using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public class NhanVienDTO
    {
        private string _maNV;
        private string _tenNV;
        private string _gioiTinh;
        private string _diaChi;
        private string _sdt;
        private DateTime _ngaySinh;
        private string _hinhAnh;

        public string MaNV { get => _maNV; set => _maNV = value; }
        public string TenNV { get => _tenNV; set => _tenNV = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string HinhAnh { get => _hinhAnh; set => _hinhAnh = value; }

        public NhanVienDTO(string maNV, string tenNV, string gioitinh, string diachi, string sdt, DateTime ngaysinh, string hinhanh)
        {
            _maNV = maNV;
            _tenNV = tenNV;
            _gioiTinh = gioitinh;
            _diaChi = diachi;
            _sdt = sdt;
            _ngaySinh = ngaysinh;
            _hinhAnh = hinhanh;
        }
        public NhanVienDTO(string maNV, string tenNV, string gioitinh, string diachi, string sdt, DateTime ngaysinh)
        {
            _maNV = maNV;
            _tenNV = tenNV;
            _gioiTinh = gioitinh;
            _diaChi = diachi;
            _sdt = sdt;
            _ngaySinh = ngaysinh;
       
        }
        public NhanVienDTO(DataRow row)
        {
            _maNV = row["MaNV"].ToString();
            _tenNV = row["TenNV"].ToString();
            _gioiTinh = row["GioiTinh"].ToString();
            _diaChi = row["DiaChi"].ToString();
            _ngaySinh = DateTime.Parse(row["NgaySinh"].ToString());
            _hinhAnh = row["HinhAnh"].ToString();
            _sdt = row["Sdt"].ToString(); 
           
        }
    }
}
