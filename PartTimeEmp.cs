using System;


namespace EmployeeWageProblem
{
    public class PartTimeEmp
    {
        public void Calculateparttimewage()
        {
            int full_time = 1;
            int Part_time_Rate_Per_hour = 20;
            int Emphrs = 0;
            int Empwage = 0;
            Random random = new Random();
            int employeecheck = random.Next(2);

            if (employeecheck == full_time)
            {
                Console.WriteLine("Part time Employee is Present");
                Emphrs = 4;
            }
            else
            {
                Console.WriteLine("Part time Employee is Absent");
                Emphrs = 0;
            }
            Empwage = Emphrs * Part_time_Rate_Per_hour;

            Console.WriteLine("Part Time Wage :" + Empwage);
        }
    }

}
