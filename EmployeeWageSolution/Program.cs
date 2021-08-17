using System;

namespace EmployeeWageSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            int full_Time = 1;
            int part_Time = 2;
            int emp_Rate_Per_Hour = 20;

            int empWage, empHrs;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == full_Time)
            {
                empHrs = 8;
            }
            else if (empCheck == part_Time)
            {
                empHrs = 4;
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

