using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BarksAPI2._0
{
    public class Accountpagina
    {
        public List<string> Accountsnickname = new List<string>();
        public List<string> AccountsBio = new List<string>();

        public string titel;
        public string text;

        //connectie string, zit in de App.config
        MySqlConnection conn;
        string connectionString = ConfigurationManager.AppSettings["Connectie"];

        public void Profile()
        {
            conn = new MySqlConnection(connectionString);
            conn.Open();

            var cmd = new MySqlCommand("SELECT AccountNickname, AccountsBio, ProfielFoto FROM accounts;", conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Accountsnickname.Add(reader.GetString("AccountNickname"));
                AccountsBio.Add(reader.GetString("AccountsBio"));
            }

            reader.Close();
            conn.Close();
        }

        public void sendBark()
        {
            conn = new MySqlConnection(connectionString);
            conn.Open();

            var cmd = new MySqlCommand("INSERT INTO `barks`(`id`, `idAccount`, `BarkDate`, `BarkTitel`, `BarkText`, `BarkIsActive`) VALUES ('[value-1]','1','23-1-23','"+titel+"','"+text+"','1');", conn);
            var reader = cmd.ExecuteReader();


            reader.Close();
            conn.Close();
        }

        public void loadBark()
        {

        }
    }
}
