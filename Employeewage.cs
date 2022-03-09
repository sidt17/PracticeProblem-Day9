using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employeewage
    {
        public void CalculateEmpWage()
        {
            int full_time = 1;
            int Emp_Rate_Per_Hour = 20;
            int Emphrs = 0;
            int Empwage = 0;
            Random random = new Random();
            int employeecheck = random.Next(2);

            if (employeecheck == full_time)
            {
                Console.WriteLine("Employee is Present");
                Emphrs = 8;
            }
            else
            {
                Console.WriteLine("Emplyee is Absent");
                Emphrs = 0;
            }
            Empwage = Emphrs * Emp_Rate_Per_Hour;

            Console.WriteLine("Employee Wage :" + Empwage);
        }
    }
}