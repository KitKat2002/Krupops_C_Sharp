
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayandList
{
    class Program
    {
        static void Main(string[] args)
        {
            //START OF INTEGER ARRAY AND ANSWER CHECKING

            int[] numArray = new int[] { 1, 2, 10, 500, 5000, 5500 };

            Console.WriteLine("Please choose an index of the number array below.  Answer in (0-5)");
            Console.WriteLine(String.Join("\n", numArray));
            int numAnswer = Convert.ToInt32(Console.ReadLine());

            if (numAnswer < numArray.Length)
            {
                Console.WriteLine(numArray[numAnswer]);
            }
            else
            {
                Console.WriteLine("This number is unavailable.  Please choose another index from the array provided.");
            }
            //END OF INTEGER ARRAY AND ANSWER CHECKING


            //START OF STRING ARRAY AND ANSWER CHECKING

            string[] nameArray = new string[] { "Adia", "Josiah", "Grace", "Timothy", "Carmen" };

            Console.WriteLine("Please choose a name from the array below.  Answer in (0-4)");
            Console.WriteLine(String.Join("\n", nameArray));
            int answer;
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer < nameArray.Length)
            {
                Console.WriteLine(nameArray[Convert.ToInt32(answer)]);
            }
            else
            {

                Console.WriteLine("Number could not be found in string array index");
            }

            //END OF STRING ARRAY AND ANSWER CHECKING


            //START OF LIST AND ANSWER CHECKING

            List<string> fruitList = new List<string> { "Apple", "Banana", "Pear", "Plum", "Peach", "Papaya", "Mango" };
            Console.WriteLine("Please choose an index from the list below.  Answer in numbers (0-6)");
            Console.WriteLine(String.Join("\n", fruitList));
            int listAnswer;
            listAnswer = Convert.ToInt32(Console.ReadLine());

            if (listAnswer < fruitList.Count)
            {
                Console.WriteLine(fruitList[Convert.ToInt32(listAnswer)]);
            }
            else
            {
                Console.WriteLine("Index selected is greater than number of indexes available in list");
            }

            //END OF LIST AND ANSWER CHECKING
        }
    }
}