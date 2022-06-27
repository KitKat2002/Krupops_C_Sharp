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
            string stringNumber = Console.ReadLine();
            if (string.IsNullOrEmpty(stringNumber))
            {
                stringNumber = "4";
                int numeroDos = Convert.ToInt32(stringNumber);

                int answer = problemFunction.problem(numeroUno, numeroDos);
                Console.WriteLine(numeroUno + numeroDos);
                Console.WriteLine(answer);
            } else
            {
                numeroUno = Convert.ToInt32(stringNumber);
                int numeroDos = Convert.ToInt32(stringNumber);
                int answer = problemFunction.problem(numeroUno, numeroDos);
                Console.WriteLine(numeroUno + numeroDos);
                Console.WriteLine(answer);

                
            }
        }
    }
}
