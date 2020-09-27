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
            int empHr = 8;
            empWage = empHr * EmpRatePerHour;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case 0:
                    Console.WriteLine("Part time Employee is present");
                    Console.WriteLine("Part time Employee Wage = " + empWage);
                    break;

                case 1:
                    Console.WriteLine("Full time Employee is present");
                    Console.WriteLine("Full time Employee Wage = " + empWage);
                    break;

                default:
                    Console.WriteLine("Neither Full Time nor Part time Employee is present!");
                    break;
            }
        }
    }
}