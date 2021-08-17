using System;

namespace EmployeeWageSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            int full_day = 1;

            Random random = new Random();
            int day = random.Next(0, 2);
            if (day == full_day)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }

    }   }

