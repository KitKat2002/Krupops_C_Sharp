using System;

namespace InsuranceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?  Please answer in true or false.");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets haave you received?");
            int speedTickets = Convert.ToInt32(Console.ReadLine());

            bool applicable = (age >= 15 && DUI == false && (speedTickets <= 3));
            Console.WriteLine("Find your results below");
            Console.WriteLine(applicable);
        }
    }
}
