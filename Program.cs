using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constant
            int present = 1;
            int Emp_Rate_Per_Hour = 20;


            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0,2);
            if (empCheck == present)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;

            Console.WriteLine("Employee Daily Wage " +  empWage);
        }
    }
}
