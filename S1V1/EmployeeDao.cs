using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1V1
{
    internal class EmployeeDao
    {
        public static List<Employee> GetAll()
        {
            List<Employee> emplist = new List<Employee>();

            try
            {
                MySqlDataReader reader = CommonDao.GetResult("Select * from employee");

                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    string nic = reader.GetString("nic");
                    int genderId = reader.GetInt32("gender_id");
                    int designationId = reader.GetInt32("designation_id");
                    int statusId = reader.GetInt32("statusemployee_id");

                    Gender gender = GenderDao.GetGenderById(genderId);
                    Designation designation = DesignationDao.GetDesignationById(designationId);
                    Employeestatus employeestatus = EmployeestatusDao.GetEmployeestatusById(statusId);

                    Employee emp = new Employee();
                    emp.Id = id;
                    emp.Name = name;
                    emp.Nic = nic;
                    emp.Gender = gender;
                    emp.Designation = designation;
                    emp.Employeestatus = employeestatus;

                    emplist.Add(emp);
                }
                return emplist;
            }catch (Exception ex) { Console.WriteLine("Can't Connect as : " + ex.Message); }

            return null;
        }
    }
}
