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
  public  class DataProvide
    {
        private static DataProvide instance;

        public static DataProvide Instance {
            get { if (instance == null) return instance =  new DataProvide(); return  DataProvide.instance; } 
           private set => DataProvide.instance = value;
        }

        private DataProvide() { }

        string strcon = @"SERVER=DESKTOP-4ICDD5V\SQLEXPRESS;Database=QLBH;User Id=test;pwd=0949238337";
     

        public DataTable ExcuteQuery(string query,object[] para =null)
        {

            DataTable data = new DataTable();
            
            using( SqlConnection connection = new SqlConnection(strcon))
            {
               
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
      
                SqlCommand command = new SqlCommand(query, connection);
                if(para !=null)
                {
                    string[] Listpara = query.Split(' ');
                    int i = 0;
                    foreach (string items in Listpara)
                    {
                        
                        if(items.Contains('@'))
                        {
                            command.Parameters.AddWithValue(items, para[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public bool ExcuteNonQuery(string query, object[] para = null)
        {

            int data = 0;
            using (SqlConnection connection = new SqlConnection(strcon))
            {

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand(query, connection);
                if (para != null)
                {
                    string[] Listpara = query.Split(' ');
                    int i = 0;
                    foreach (string items in Listpara)
                    {

                        if (items.Contains('@'))
                        {
                            command.Parameters.AddWithValue(items, para[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data >0;
        }
        public int ExcuteScalar(string query, object[] para = null)
        {
            int dem ;

            using (SqlConnection connection = new SqlConnection(strcon))
            {
               
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand(query, connection);
                if (para != null)
                {
                    string[] Listpara = query.Split(' ');
                    int i = 0;
                    foreach (string items in Listpara)
                    {

                        if (items.Contains('@'))
                        {
                            command.Parameters.AddWithValue(items, para[i]);
                            i++;
                        }
                    }
                }
             
                    dem = (int)command.ExecuteScalar();
                
               
                connection.Close();
            }
            return dem;
        }
      
        public string ExcuteScalarString(string query, object[] para = null)
        {
            string dem;

            using (SqlConnection connection = new SqlConnection(strcon))
            {

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand(query, connection);
                if (para != null)
                {
                    string[] Listpara = query.Split(' ');
                    int i = 0;
                    foreach (string items in Listpara)
                    {

                        if (items.Contains('@'))
                        {
                            command.Parameters.AddWithValue(items, para[i]);
                            i++;
                        }
                    }
                }
                dem = command.ExecuteScalar().ToString();
                connection.Close();
            }
            return dem;
        }

    }
}
