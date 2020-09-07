using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class Account
    {
        private string _userName;
        private string _passWord;
        private string _role;
        private string _MaUser;

        public string UserName { get => _userName; set => _userName = value; }
        public string PassWord { get => _passWord; set => _passWord = value; }
        public string Role { get => _role; set => _role = value; }
        public string MaUser { get => _MaUser; set => _MaUser = value; }

        public Account(string user , string pass ,string role ,string manv)
        {
            _userName = user;
            _passWord = pass;
            _role = role;
            _MaUser = manv;
        }
        public Account(string user, string pass)
        {
            _userName = user;
            _passWord = pass;
          
        }
        public Account(DataRow row)
        {
            _userName = row["UserName"].ToString();
            _passWord = row["PassWord"].ToString();
            _role = row["Role"].ToString();
            _MaUser = row["MaUser"].ToString();
        }
    }
}
