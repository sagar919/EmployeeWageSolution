using System;

namespace EmployeeWageSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            int full_Time = 1;
            int emp_Rate_Per_Hour = 8;

            int empWage, empHrs;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage is" + empWage);
        }

    }   
}

