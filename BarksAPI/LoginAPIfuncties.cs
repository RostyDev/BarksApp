using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace BarksAPI
{
    public class LoginAPIfuncties
    {
        private void MakeConn()
        {
            MySqlConnection Conn;

            string ConnString = ConfigurationManager.AppSettings["LocalConn"];

            Conn = new MySqlConnection(ConnString);
            Conn.ConnectionString= ConnString;

            Conn.Open();
        }

        public void Login()
        {

        }
    }
}
