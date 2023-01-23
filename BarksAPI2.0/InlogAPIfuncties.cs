using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BarksAPI2._0
{
    public class InlogAPIfuncties
    {
        public string EmailAdres { get; set; }
        public int HashWW { get; set;  }

        public AccountData ActiveAccount = new AccountData();

        MySqlConnection Conn;

        private void OpenConn()
        {
            string ConnString = ConfigurationManager.AppSettings["Connectie"];

            Conn = new MySqlConnection(ConnString);
            Conn.ConnectionString = ConnString;

            Conn.Open();
        }

        public void GetAccount()
        {
            OpenConn();

            var cmd = new MySqlCommand("SELECT idAccounts, AccountNickname, Emailadress, AccountRealname, AccountWW, AccountsBio, AccountAge, Adres, Postcode FROM accounts WHERE Emailadress LIKE '" + EmailAdres + "'", Conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ActiveAccount.idAccounts = reader.GetInt32("idAccounts");
                ActiveAccount.AccountNickname = reader.GetString("AccountNickname");
                ActiveAccount.Emailadress = reader.GetString("Emailadress");
                ActiveAccount.AccountRealname = reader.GetString("AccountRealname");
                ActiveAccount.Password = reader.GetInt32("AccountWW");
                ActiveAccount.AccountsBio = reader.GetString("AccountsBio");
                ActiveAccount.AccountAge = reader.GetInt32("AccountAge");
                ActiveAccount.Adres = reader.GetString("Adres");
                ActiveAccount.Postcode = reader.GetString("Postcode");
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
