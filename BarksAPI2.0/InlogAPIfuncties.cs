using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BarksAPI2._0
{
    public class InlogAPIfuncties
    {
        public string EmailAdres { get; set; }
        public int HashWW { get; set;  }
        public int AccountPassword { get; set; }

        MySqlConnection Conn;

        private void OpenConn()
        {
            string ConnString = ConfigurationManager.AppSettings["Connectie"];

            Conn = new MySqlConnection(ConnString);
            Conn.ConnectionString = ConnString;

            Conn.Open();
        }

        public void Login()
        {
            OpenConn();

            var cmd = new MySqlCommand("SELECT Emailadress, AccountWW FROM accounts WHERE Emailadress LIKE '" + EmailAdres + "'", Conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                AccountPassword = reader.GetInt32("AccountWW");
            }

            reader.Close();

            Conn.Close();
        }

        public void Hash(string Password) 
        {
            HashWW = Password.GetHashCode();
        }
    }
}
