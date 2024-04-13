using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1V1
{
    internal class EmployeestatusDao
    {
        public static Employeestatus GetEmployeestatusById(int statusId)
        {

            try
            {

                MySqlDataReader reader = CommonDao.GetResult("SELECT * FROM statusemployee WHERE id = " + statusId);
                reader.Read();
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");

                Employeestatus employeestatus = new Employeestatus();
                employeestatus.Id = id;
                employeestatus.Name = name;

                return employeestatus;
            }catch (Exception ex) { Console.WriteLine("Can't Connect as : " + ex.Message); }

            return null;
        }
    }
}
