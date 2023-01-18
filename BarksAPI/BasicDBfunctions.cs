using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarksAPI
{
    public class BasicDBfunctions
    {
        private void MakeConnection()
        {
            MySqlConnection conn;
            string Connectionstring = ConfigurationManager.AppSettings["LocalConn"];
        }
    }
}
