using MongoDB.Driver.Core.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1V1
{
    internal class CommonDao
    {

        public static MySqlDataReader GetResult(string query)
        {
            try
            {
                string connectionString = "server=localhost; uid=us2; pwd=abcd1234; database=harvest";
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();

                MySqlCommand cmmd = new MySqlCommand();
                cmmd.CommandText = query;
                cmmd.Connection = conn;

                MySqlDataReader reader = cmmd.ExecuteReader();
        
                return reader;

            }
            catch(Exception ex) { Console.WriteLine("Can't Connect as : " + ex.Message); }

            return null;

        }
    }
}
