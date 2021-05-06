using System;

namespace EmployeeWage
{
    class EmployeeDetails
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;


        public static int calculateEmployee(string company, int empRatePerHour, int numOfWorkingDays, int maxhoursPerMonth)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Program using C#");
            int totalEmpWage = 0;
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxhoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day= " + totalWorkingDays + "Emp Hrs= " + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("The total  Employee Wage for :" + company + "IS =" + totalEmpWage);
            return totalEmpWage;
        }
    }
}

