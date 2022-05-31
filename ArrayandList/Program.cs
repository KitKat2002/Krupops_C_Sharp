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

            int[] numArray = new int[6];
            numArray[0] = 1;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;
            numArray[5] = 5500;

            Console.WriteLine("Please choose a number from the array below");
            Console.WriteLine(String.Join("\n", numArray));
            string numAnswer = Console.ReadLine();
           

                if (numAnswer == "1")
                {
                    Console.WriteLine("You chose" + " " + String.Join("\n", numArray[0]));
                }
                else if (numAnswer == "2")
                {
                    Console.WriteLine("You chose" + " " + String.Join("\n", numArray[1]));
                }
                else if (numAnswer == "10")
                {
                    Console.WriteLine("You chose" + " " + String.Join("\n", numArray[2]));
                }
                else if (numAnswer == "200")
                {
                    Console.WriteLine("You chose" + " " + String.Join("\n", numArray[3]));
                }
                else if (numAnswer == "5000")
                {
                    Console.WriteLine("You chose" + " " + String.Join("\n", numArray[4]));
                }
                else if (numAnswer == "5500")
                {
                    Console.WriteLine("You chose" + " " + String.Join("\n", numArray[5]));                
                }
                else
                {
                    Console.WriteLine("This number is unavailable.  Please choose a number from the array provided.");
                }
            //END OF INTEGER ARRAY AND ANSWER CHECKING
            

            //START OF STRING ARRAY AND ANSWER CHECKING

            string[] nameArray = new string[5];
            nameArray[0] = "Adia";
            nameArray[1] = "Josiah";
            nameArray[2] = "Grace";
            nameArray[3] = "Timothy";
            nameArray[4] = "Carmen";

            Console.WriteLine("Please choose a name from the array below.  This is case sensitive, so please make sure to properly capitalize names.");
            Console.WriteLine(String.Join("\n", nameArray));
            string answer = Console.ReadLine();

                if (answer == "Adia")
                {
                    Console.WriteLine("You chose" + " " + String.Join("\n", nameArray[0]));
                }
                else if (answer == "Josiah")
                {
                    Console.WriteLine("You chose" + " " + String.Join("\n", nameArray[1]));
                }
                else if (answer == "Grace")
                {
                    Console.WriteLine("You chose" + " " + String.Join("\n", nameArray[2]));
                }
                else if (answer == "Timothy")
                {
                    Console.WriteLine("You chose" + " " + String.Join("\n", nameArray[3]));
                }
                else if (answer == "Carmen")
                {
                    Console.WriteLine("You chose" + " " + String.Join("\n", nameArray[4]));
                }
                else
                {
                    Console.WriteLine("Invalid name.  Please choose from names provided");
                }


            //END OF STRING ARRAY AND ANSWER CHECKING


            //START OF LIST AND ANSWER CHECKING

            List<string> fruitList = new List<string> { "Apple", "Banana", "Pear", "Plum", "Peach", "Papaya", "Mango" };
            Console.WriteLine("Please choose a fruit from the list below.  Program is case sensitive, so please make sure to properly capitalize all answers");
            Console.WriteLine(String.Join("\n", fruitList));
            string listAnswer = Console.ReadLine();
               
        
            if (listAnswer == "Apple")
            {
                Console.WriteLine("You picked an" + " " + fruitList[0]);
            }
            else if (listAnswer == "Banana")
            {
                Console.WriteLine("You picked a" + " " + fruitList[1]);
            }
            else if (listAnswer == "Pear")
            {
                Console.WriteLine("You picked a" + " " + fruitList[2]);
            }
            else if (listAnswer == "Plum")
            {
                Console.WriteLine("You picked a" + " " + fruitList[3]);
            }
            else if (listAnswer == "Peach")
            {
                Console.WriteLine("You picked a" + " " + fruitList[4]);
            }
            else if (listAnswer == "Papaya")
            {
                Console.WriteLine("You picked a" + " " + fruitList[5]);
            }
            else if (listAnswer == "Mango")
            {
                Console.WriteLine("You picked a" + " " + fruitList[6]);
            }
            else
            {
                Console.WriteLine("Sorry, but you need to pick a fruit from the list provided.");
            }

            //END OF LIST AND ANSWER CHECKING
            }
        }
    }
