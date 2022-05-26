using System;

namespace BooleeanLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool name = false;
            bool C_Sharp = true;

            do
            {
                Console.WriteLine("The following program was written in C#");
                break;
            } while (C_Sharp == true);

                while (name == false)
                {
                    Console.WriteLine("Please enter your name");
                    string nameInput = Console.ReadLine();

                    if (string.IsNullOrEmpty(nameInput) == false)
                    { 
                        Console.WriteLine("Accepted");
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("Oops, please do not enter a blank name");
                    }
                } //closing bracket for while loop
            }

            bool C_sharp = true;

       
        
} //closing bracket for static void Main
}

