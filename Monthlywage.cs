using System;


namespace EmployeeWageProblem
{
    public class Monthlywage
    {
        public void Calculatingmonthlywage()
        {
            int Emphrs = 0;
            int Emp_Rate_per_hour = 20;
            int dailyWage;
            int totalWage = 0;

            int day = 0;
            for (day = 0; day < 20; day++)
            {
                Random random = new Random();
                int number = random.Next(3);
                switch (number)
                {
                    case 0:
                        Console.WriteLine(" Employee is absent");
                        Emphrs = 0;
                        break;
                    case 1:
                        Console.WriteLine("Employee is present");
                        Emphrs = 8;
                        break;
                    case 2:
                        Console.WriteLine("Employee is working partime");
                        Emphrs = 4;
                        break;
                }
                dailyWage = Emphrs * Emp_Rate_per_hour;
                totalWage = totalWage + dailyWage;


            }
            Console.WriteLine("Employee monthly wage is " + totalWage);
        }

    }

}