using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int present = 1;

            Random random = new Random();
            int empCheck = random.Next(0,2);
            if (empCheck == present)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
