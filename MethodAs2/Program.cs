using System;

namespace MethodAs2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math problemFunction = new Math();

            Console.WriteLine("Please enter a number");
            int numeroUno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second optional number");
            string secondNumber = Console.ReadLine();

            if (string.IsNullOrEmpty(secondNumber))
            {
                secondNumber = "0";
                int numeroDos = Convert.ToInt32(secondNumber);
                int answer = problemFunction.problem(numeroUno + numeroDos);

                Console.WriteLine("Displayed if user did not enter the second number (2 - first number entered");
                Console.WriteLine(answer);
           
            } else
            {           
                int numeroDos = Convert.ToInt32(secondNumber);
                int answer = problemFunction.problem(numeroUno + numeroDos);

                Console.WriteLine("Displayed if user did enter a second number (2 - first number entered + second number entered)");
                Console.WriteLine(answer);
            }
        }
    }
}
