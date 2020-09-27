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
            int empFTWageMonth = 0;
            int empPTWageMonth = 0;

            for (int i = 1; i <= 20; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                if (empCheck == IsPartTime)
                {
                    empPTWageMonth = empPTWageMonth + empWage;
                }
                else if (empCheck == IsFullTime)
                {
                    empFTWageMonth = empFTWageMonth + empWage;
                }
            }
            Console.WriteLine("Part time Employee Monthly Wage = " + empPTWageMonth);
            Console.WriteLine("Full time Employee Monthly Wage = " + empFTWageMonth);
        }
    }
}