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
            int totalPTTime = 0;
            int totalFTTime = 0;
            int i = 1;

            for (i = 1; i <= 20; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                if (empCheck == IsPartTime)
                {
                    totalPTTime = totalPTTime + empHr;
                    if (totalPTTime > 100)
                    {
                        totalPTTime = 100;
                        empPTWageMonth = 2000;
                    }
                    empPTWageMonth = empPTWageMonth + empWage;
                }
                else if (empCheck == IsFullTime)
                {
                    totalFTTime = totalFTTime + empHr;
                    if (totalFTTime > 100)
                    {
                        totalFTTime = 100;
                        empFTWageMonth = 2000;
                    }
                    empFTWageMonth = empFTWageMonth + empWage;
                }
            }
            Console.WriteLine("Part time Employee Monthly Wage = " + empPTWageMonth + ", Hours worked = " + totalPTTime);
            if (totalPTTime < 100)
            {
                Console.WriteLine("Days worked = " + (i - 1));
            }
            Console.WriteLine("Full time Employee Monthly Wage = " + empFTWageMonth + ", Hours worked = " + totalFTTime);
            if (totalFTTime < 100)
            {
                Console.WriteLine("Days worked = " + (i - 1));
            }
        }
    }
}