using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public class NhaCungCapDTO
    {
        private string _maNCC;
        private string _tenNCC;
        private string _diaChi;
        private string _sdt;
        private string _hang;
        private string _hinhAnh;

        public string MaNCC { get => _maNCC; set => _maNCC = value; }
        public string TenNCC { get => _tenNCC; set => _tenNCC = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string Hang { get => _hang; set => _hang = value; }
        public string HinhAnh { get => _hinhAnh; set => _hinhAnh = value; }

        public NhaCungCapDTO(string maNCC, string tenNCC,string diachi, string sdt , string hang, string hinhanh)
        {
            _maNCC = maNCC;
            _tenNCC = tenNCC;
            _diaChi = diachi;
            _sdt = sdt;
            _hang = hang;
            _hinhAnh = hinhanh;
        }
        public NhaCungCapDTO(string maNCC, string tenNCC, string diachi, string sdt, string hang)
        {
            _maNCC = maNCC;
            _tenNCC = tenNCC;
            _diaChi = diachi;
            _sdt = sdt;
            _hang = hang;
        }
        public NhaCungCapDTO(DataRow row)
        {
            _maNCC = row["MaNCC"].ToString();
            _tenNCC = row["TenNCC"].ToString();
            _diaChi = row["DiaChi"].ToString(); ;
            _sdt = row["SDT"].ToString(); ;
            _hang = row["Hang"].ToString(); ;
            _hinhAnh = row["HinhAnh"].ToString(); ;
        }
    }
}
