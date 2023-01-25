using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarksAPI2._0
{
    public class BarksAPIfuncties
    {
        public AccountData ActiveAccount = new AccountData();
        public BarkData NewBark = new BarkData();

        private MySqlConnection Conn;

        private void OpenConn()
        {
            string ConnString = ConfigurationManager.AppSettings["Connectie"];

            Conn = new MySqlConnection(ConnString);
            Conn.ConnectionString = ConnString;

            Conn.Open();
        }

        public void PostBark()
        {
            OpenConn();

            var cmd = new MySqlCommand("INSERT INTO barks(idAccount, BarkDate, BarkTitel, BarkText, BarkMedia)" +
                " VALUES ('[value-1]','[value-2]','[value-3]','[value-4]','[value-5]')");   
            var reader = cmd.ExecuteReader();

            reader.Close();
            Conn.Close();
        }
    }
}
