using System;

namespace MathOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Work Rate");
            int per1HRate = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int per1WRate =  Convert.ToInt32(Console.ReadLine());

            int YtotalOne = per1HRate * per1WRate * 52;
            Console.WriteLine("Annual Salary of Person 1" + " " + YtotalOne);

            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Work Rate");
            int per2HRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int per2WRate = Convert.ToInt32(Console.ReadLine());

            int YtotalTwo = per2HRate * per2WRate * 52;
            Console.WriteLine("Annual salary of Person 2" + " " + YtotalTwo);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            if (YtotalOne > YtotalTwo)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
