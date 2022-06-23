using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to have it added to, subracted from, and the remainder found by three different pre-programmed numbers.");
            int MathNum_A = Convert.ToInt32(Console.ReadLine());
            int MathNum_B = 7;
            int result;
            MathClass newFunction = new MathClass();

            Console.WriteLine("Addition");
            result = newFunction.Add(MathNum_A, MathNum_B);
            Console.WriteLine(result);

            Console.WriteLine("Subtraction");
            result = newFunction.Sub(MathNum_A, MathNum_B);
            Console.WriteLine(result);

            Console.WriteLine("Remainder");
            result = newFunction.Rem(MathNum_A, MathNum_B);
            Console.WriteLine(result);

        }
    }
}
