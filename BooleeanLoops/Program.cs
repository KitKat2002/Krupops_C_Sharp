using System;

namespace BooleeanLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool name = false;
            {
                Console.WriteLine("Please enter your name");
                string nameInput = Console.ReadLine();

                while (string.IsNullOrEmpty(nameInput))
                {
                    name = false;

                    if (!string.IsNullOrEmpty(nameInput))
                    {
                       
                        name = true;
                        Console.WriteLine("Accepted");
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        name = false;
                        Console.WriteLine("Oops, please do not enter a blank name");
                        Console.WriteLine("Please enter your name");
                        Console.ReadLine();
                    }
                } //closing bracket for while loop
            }
        } //closing bracket for static void Main
    }
}
