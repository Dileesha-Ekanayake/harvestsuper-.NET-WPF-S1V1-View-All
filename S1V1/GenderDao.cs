using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1V1
{
    internal class GenderDao
    {
        public static Gender GetGenderById(int genderId)
        {

            try
            {
                MySqlDataReader reader = CommonDao.GetResult("SELECT * FROM gender WHERE id = " + genderId);
                reader.Read();
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");

                Gender gender = new Gender();

                gender.Id = id;
                gender.Name = name;
                return gender;
            }catch (Exception ex) { Console.WriteLine("Can't Connect as : " + ex.Message); }

            return null;
        }
    }
}
