using System;

namespace EmployeeWage
{
    public class EmployeeDetails
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxhoursPerMonth;
        private int totalEmpWage;

        public EmployeeDetails(string company, int empRatePerHour, int numOfWorkingDays, int maxhoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxhoursPerMonth = maxhoursPerMonth;
        }
        public int calculateEmployee()
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Program using C#");
           
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxhoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
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

            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            return totalEmpWage;
        }
        public string toString()
        {
            return $"Total Employee Wage For :  {this.company} is {this.totalEmpWage}";
        }
    }

}