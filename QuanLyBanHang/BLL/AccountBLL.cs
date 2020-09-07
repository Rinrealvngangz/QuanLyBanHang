using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;
namespace BLL
{
    public class AccountBLL
    {
      
        public bool LoadingAcount(string username, string password)
        {
            return AccountDAL.Instance.Login(username, password);
        }
        public List<Account> LoadingAccCount()
        {
            return AccountDAL.Instance.LoadingAcc();
        }
        public bool UpAcount(string username, string password,string maNV)
        {
            return AccountDAL.Instance.UpdateUser(username, password, maNV);
        }
        public bool DelAcount(string maNV)
        {
            return AccountDAL.Instance.DeleteUser( maNV);
        }
        public bool AddUser(DTO.Account acc)
        {
            return AccountDAL.Instance.AddUser(acc);
        }
        public List<Account> LoadingAccCountUser(string maNV)
        {
            return AccountDAL.Instance.LoadingAccUser(maNV);
        }
        public List<Account> TimKiemAccCountUser(string user)
        {
            return AccountDAL.Instance.TimKiemAccUser(user);
        }
        public List<Account> CheckAccCountUser(string user,string pass)
        {
            return AccountDAL.Instance.CheckAcc(user, pass);
        }
    }
}
