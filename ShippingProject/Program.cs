using System;

namespace ShippingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below");

            Console.WriteLine("Package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                System.Environment.Exit(1);
            }

            Console.WriteLine("Package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            int totalDimensions = length + width + height;

            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too large to be shipped via Package Express. Have a good day.");
                System.Environment.Exit(1);
            }

            int sizeMultiple = length * width * height;

            int shippingCost = sizeMultiple * weight / 100;

            Console.WriteLine("The shipping cost is: $" + shippingCost);

        }
    }
}
