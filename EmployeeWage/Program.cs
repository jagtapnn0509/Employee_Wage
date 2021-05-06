using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Program");
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("The Daily Employee Wage is :" + empWage);
        }
    }
}
