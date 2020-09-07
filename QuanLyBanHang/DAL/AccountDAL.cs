using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
   public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance {
            get { 
                if (instance == null)  instance = new AccountDAL(); return instance; }
           private set => instance = value; 
        }

        private AccountDAL() {}

        public bool Login(string username,string password)
        {
            string query = "usp_AccountUser @username , @password";
            DataTable rs = DataProvide.Instance.ExcuteQuery(query, new object[] { username, password });

            return rs.Rows.Count > 0;
        }
        public bool UpdateUser(string username, string password,string maNV)
        {
            string query = "UpdateUser @MaNV , @user , @pass";
            bool rs = DataProvide.Instance.ExcuteNonQuery(query, new object[] { maNV, username, password });

            return rs;
        }

        public bool DeleteUser(string maNV)
        {
            string query = "DelUser @MaNV";
            bool rs = DataProvide.Instance.ExcuteNonQuery(query, new object[] { maNV });

            return rs;

        }
        public bool AddUser(DTO.Account acc)
        {
            string query = "ThemUser @maNV , @user , @pass , @role";
            bool rs = DataProvide.Instance.ExcuteNonQuery(query, new object[] {acc.MaUser ,acc.UserName, acc.PassWord ,acc.Role });

            return rs;
        }

        public List<Account> LoadingAcc()
        {
            string query = "select * from AccountUser";
            List<Account> acc = new List<Account>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Account items = new Account(row);
                acc.Add(items);
            }
            return acc;
        }
        public List<Account> CheckAcc(string user ,string pass)
        {
            string query = "checkAccount @user , @pass";
            List<Account> acc = new List<Account>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query,new object[] { user,pass});
            foreach (DataRow row in data.Rows)
            {
                Account items = new Account(row);
                acc.Add(items);
            }
            return acc;
        }
        public List<Account> LoadingAccUser(string maNV)
        {
            string query = "FillPassNv @maNv";
            List<Account> acc = new List<Account>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { maNV});
            foreach (DataRow row in data.Rows)
            {
                Account items = new Account(row);
                acc.Add(items);
            }
            return acc;
        }
        public List<Account> TimKiemAccUser(string user)
        {
            string query = "usp_timKiemAcc @user";
            List<Account> acc = new List<Account>();
            DataTable data = DataProvide.Instance.ExcuteQuery(query, new object[] { user });
            foreach (DataRow row in data.Rows)
            {
                Account items = new Account(row);
                acc.Add(items);
            }
            return acc;
        }
    }
}
