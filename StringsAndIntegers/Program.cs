using System;
using System.Collections.Generic;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> randomNumbers = new List<int>() { 60, 22, 71, 44, 56, 21, 34};
                string display;
                int RNumber;

                Console.WriteLine("Display of list of numbers");
                randomNumbers.ForEach(Console.WriteLine);
                Console.WriteLine("Please choose a number to divide the items in the list above by");
                int div = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The list will be divided by:" + div);

                for (int n = 0; n < randomNumbers.Count; n++)
                {
                    RNumber = randomNumbers[n];
                    display = Convert.ToString(RNumber / div);
                    Console.WriteLine(randomNumbers[n] + " / " + div + " = " + display);
                    }
            }
            catch (DivideByZeroException sample)
            {
                Console.WriteLine("I'm sorry but zero is not a possible number choice to divide by");
            }
            catch (FormatException sample)
            {
                Console.WriteLine("Please only answer in numbers");
            }
            catch (Exception sample)
            {
                Console.WriteLine(sample.Message);
            }
            finally
            {
                Console.WriteLine("Finished try/catch");
            }
        }
    }
}
