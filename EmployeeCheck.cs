using System;


namespace EmployeeWageProblem
{
    public class EmployeeCheck
    {
       
        public void CheckEmployeeAttendance()
        {
            int full_time = 1;
            Random random = new Random();
            int employeecheck = random.Next(2);

            if (employeecheck == full_time)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Emplyee is Absent");
            }
        }
    }
}


