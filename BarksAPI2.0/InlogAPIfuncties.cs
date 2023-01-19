using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarksAPI2._0
{
    public class InlogAPIfuncties
    {
        public string EmailAdres { get; set; }

        private void MakeConn()
        {
            MySqlConnection Conn;

            string ConnString = ConfigurationManager.AppSettings["LocalConn"];

            Conn = new MySqlConnection(ConnString);
            Conn.ConnectionString = ConnString;

            Conn.Open();
        }

        public void Login()
        {
            MakeConn();

            var cmd = new MySqlCommand("SELECT Emailadress, AccountWW FROM accounts WHERE Emailadress LIKE '" + EmailAdres + "'");
            var reader = cmd.ExecuteReader();


        }
    }
}
