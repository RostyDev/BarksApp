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
        public List<BarkData> PersoonlijkeBarks = new List<BarkData>();
        public List<BarkData> AllBarks = new List<BarkData>();

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

            var cmd = new MySqlCommand("INSERT INTO barks(idAccount, BarkDate, BarkTitel, BarkText)" +
                " VALUES ('"+ NewBark.Accountid +"','"+ NewBark.BarkDate +"','"+ NewBark.BarkTitel +"','"+ NewBark.BarkText +"')", Conn);   
            var reader = cmd.ExecuteReader();

            reader.Close();
            Conn.Close();
        }

        public void GetPersonalBarks()
        {
            PersoonlijkeBarks.Clear();

            OpenConn();

            var cmd = new MySqlCommand("SELECT id, idAccount, accounts.AccountNickname, BarkDate, BarkTitel, BarkText, BarkIsActive" +
                " FROM barks " +
                "INNER JOIN accounts ON barks.idAccount = accounts.idAccounts" +
                " WHERE accounts.idAccounts LIKE "+ ActiveAccount.idAccounts +";", Conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                BarkData TijdelijkeBark = new BarkData();

                TijdelijkeBark.id = reader.GetInt32("id");
                TijdelijkeBark.Accountid = reader.GetInt32("idAccount");
                TijdelijkeBark.AccountNickname = reader.GetString("AccountNickname");
                TijdelijkeBark.BarkDate = DateTime.Parse(reader.GetString("BarkDate"));
                TijdelijkeBark.BarkTitel = reader.GetString("BarkTitel");
                TijdelijkeBark.BarkText = reader.GetString("barkText");
                TijdelijkeBark.BarkActive = reader.GetUInt16("BarkIsActive");

                PersoonlijkeBarks.Add(TijdelijkeBark);
            }

            reader.Close();
            Conn.Close();
        }

        public void GetAllBarks()
        {
            OpenConn();

            var cmd = new MySqlCommand("SELECT id, idAccount, accounts.AccountNickname, BarkDate, BarkTitel, BarkText, BarkIsActive " +
                "FROM barks INNER JOIN accounts ON barks.idAccount = accounts.idAccounts;", Conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                BarkData TijdelijkeBark = new BarkData();

                TijdelijkeBark.id = reader.GetInt32("id");
                TijdelijkeBark.Accountid = reader.GetInt32("idAccount");
                TijdelijkeBark.AccountNickname = reader.GetString("AccountNickname");
                TijdelijkeBark.BarkDate = DateTime.Parse(reader.GetString("BarkDate"));
                TijdelijkeBark.BarkTitel = reader.GetString("BarkTitel");
                TijdelijkeBark.BarkText = reader.GetString("barkText");
                TijdelijkeBark.BarkActive = reader.GetUInt16("BarkIsActive");

                AllBarks.Add(TijdelijkeBark);
            }

            reader.Close();
            Conn.Close();
        }

        public void RemoveBark()
        {

        }
    }
}
