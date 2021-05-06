using System;

namespace EmployeeWage
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 50;
        public const int NUM_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Program using C#");

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            Random random = new Random();

            for (int temp = 1; temp < NUM_OF_WORKING_DAYS; temp++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
            }
            Console.WriteLine("The Employee Wage is :" + empWage);
            Console.WriteLine("The tatal Employee Wage is :" + totalEmpWage);
        }
    }
}