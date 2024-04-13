using System;

namespace S1V1
{
    internal class EmployeeController
    {
        public static List<Employee> Get()
        {
            return EmployeeDao.GetAll();
        }
    }
}

