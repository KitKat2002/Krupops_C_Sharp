using System;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int DivNum_A = 14;
            Math divisionFunction = new Math();
            Console.WriteLine("Division");
            int answer = divisionFunction.problem(DivNum_A);
            Console.WriteLine(answer);

            decimal RemNum_A = 2.62m;
            Math remainderFunction = new Math();
            Console.WriteLine("Remainder of decimal");
            decimal answer2 = remainderFunction.problem(RemNum_A);
            Console.WriteLine(answer2);

            Math stringFunction = new Math();
            Console.WriteLine("Enter a number");
            string Conversion = Console.ReadLine();
            Console.WriteLine("Conversion of string to int and had had four subtracted from");
            int answer3 = stringFunction.problem(Conversion);
            Console.WriteLine(answer3);
            

        }
    }
}
