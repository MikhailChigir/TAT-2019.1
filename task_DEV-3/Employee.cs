using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Employee
    {
        public int salary;
        public int performance;

        public Employee()
        {
            salary = 0;
            performance = 0;
        }

        public int GetSalary()
        {
            return salary;
        }

        public int GetPerformance()
        {
            return performance;
        }
    }

}

     
