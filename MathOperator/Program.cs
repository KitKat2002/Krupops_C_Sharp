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
            decimal per1HRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            decimal per1WRate =  Convert.ToDecimal(Console.ReadLine());

            decimal YtotalOne = per1HRate * per1WRate * 52;
            Console.WriteLine("Annual Salary of Person 1" + " " + YtotalOne);

            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Work Rate");
            decimal per2HRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            decimal per2WRate = Convert.ToDecimal(Console.ReadLine());

            decimal YtotalTwo = per2HRate * per2WRate * 52;
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
