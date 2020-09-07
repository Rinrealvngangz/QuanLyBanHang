using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public class Hang
    {
        private string _maHang;
        private string _tenHang;

        public Hang(DataRow row)
        {
            _maHang = row["MaHang"].ToString();
            _tenHang = row["TenHang"].ToString();
        }

        public string MaHang { get => _maHang; set => _maHang = value; }
        public string TenHang { get => _tenHang; set => _tenHang = value; }
    }
}
