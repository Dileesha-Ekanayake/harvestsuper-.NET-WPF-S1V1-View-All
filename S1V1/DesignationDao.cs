using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1V1
{
    internal class DesignationDao
    {
        public static Designation GetDesignationById(int designationId)
        {
            try{
                MySqlDataReader reader = CommonDao.GetResult("SELECT * FROM designation WHERE id = " + designationId);
                reader.Read();
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");
            
                Designation designation = new Designation();

                designation.Id = id;
                designation.Name = name;
                return designation; 
            }catch(Exception ex) { Console.WriteLine("Can't Connect as : " + ex.Message); }

            return null;
        }
    }
}
