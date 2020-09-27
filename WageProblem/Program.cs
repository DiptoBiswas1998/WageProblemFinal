using System;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome msg
            Console.WriteLine("Welcome to the Employee Wage Problem!");
            //Solution
            int IsFullTime = 1;
            int IsPartTime = 0;
            int EmpRatePerHour = 20;

            int empWage = 0;
            int empHr = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IsPartTime)
            {
                Console.WriteLine("Part time Employee is Present.");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Part time Employee is Absent!");
                empHr = 0;
            }
            empWage = empHr * EmpRatePerHour;
            Console.WriteLine("Part time Employee Wage = " + empWage);
        }
    }
}