using System;


namespace EmployeeWageProblem
{
    public class Switchcase
    {
        public void Monthlywage()
        {

            int Emp_Rate_Per_Hour = 20;
            int Emphrs = 0;
            int Empwage = 0;
            Random random = new Random();
            int employeecheck = random.Next(3);

            switch (employeecheck)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    Emphrs = 0;
                    break;
                case 1:
                    Console.WriteLine("Employee is Present");
                    Emphrs = 8;
                    break;
                case 2:
                    Console.WriteLine("Employee is working partime");
                    Emphrs = 4;
                    break;



            }
            Empwage = Emphrs * Emp_Rate_Per_Hour;

            Console.WriteLine("Employee Wage :" + Empwage);
        }


    }









}
