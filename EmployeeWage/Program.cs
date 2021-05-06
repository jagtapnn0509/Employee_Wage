using System;

namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeDetails google = new EmployeeDetails("Google", 20, 2, 10);
            EmployeeDetails vipro = new EmployeeDetails("Vipro", 10, 4, 20);
            google.calculateEmployee();
            vipro.calculateEmployee();
            Console.WriteLine(google.toString());
            Console.WriteLine(vipro.toString());
        }
    }
}