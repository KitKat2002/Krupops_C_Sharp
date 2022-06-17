using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] books = new string[5];
            Console.WriteLine("Please type any word to add it to the following books");
            string editBooks = Convert.ToString(Console.ReadLine());

            books[0] = "Old Yeller";
            books[1] = "The Chronicals of Narnia: The Lion, The Witch, And The Wardrobe";
            books[2] = "It";
            books[3] = "How to Train Your Dragon";
            books[4] = "11 Seconds";

            foreach (string book in books)
            {
                Console.WriteLine(book + ", " + editBooks);
            }
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            //COUNTS FROM 0-9 USING < OPERATOR------------------------------------------------------------------
            Console.WriteLine("\n The following loop counts from 0 to 9 using the less than operator");

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 10);


            // COUNTS FROM 0-15 USING <= OPERATOR----------------------------------------------------------------

            Console.WriteLine("\n Counts from 0 to 15 using the less than or equal to operator");

            int z = 0;
            do
            {
                Console.WriteLine(z);
                z++;
            } while (z <= 15);

            //INFINITE LOOP --------------------------------------------------------------------------------------

            //string hello = "hello world";
            //for (int i = 0; i < hello.Length; i--)
            //   {
            //       Console.WriteLine("Current times looped - {0}",i);
            //   }

            //CORRECTION OF INFINITE LOOP --------------------------------------------------------------------------

            Console.WriteLine("\n Correction of infinite loop displayed (press enter to continue)");
            string hello = "hello world";
            Console.ReadLine();

            for (int i = 0; i <= hello.Length; i++)
            {
                Console.WriteLine("Current times looped - {0} ", i);
            }

            // LIST ONE -----------------------------------------------------------------------------------------------

            Console.WriteLine("\n Select a flower to print the index of");

            bool flowerList;
            bool accurate = false;
            string userFlowerChoice;
            List<string> flowers = new List<string>() { "Poppy", "Sunflower", "Black-Eyed Susan", "Rose", "Chrysanthemum", "Daffodil", "Lotus"};
            foreach (string f in flowers)
            {
                Console.WriteLine(f);
            }
            while (!accurate)
            {
                userFlowerChoice = Console.ReadLine().ToLower();
                flowerList = flowers.Exists(z => z.ToLower() == userFlowerChoice);
                if (flowerList)
                {
                    accurate = true;
                    for (int n = 0; n < flowers.Count; n++)
                    {
                        if (userFlowerChoice == flowers[n].ToLower())
                        {
                            Console.WriteLine("The index of the flower chosen is " + n);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Oops, please choose a flower from the list above");
                }
            }

            //LIST TWO ---------------------------------------------------------------------------------

            Console.WriteLine("\n Select a vegetable to print the index of");

            bool itemList;
            bool stable = false;
            string userChoice;
            List<string> vegetables = new List<string>() { "\nZucchini", "Broccoli", "Corn", "Corn", "Cauliflower", "Kale", "Spinach", "Kale", "Lettuce" };
            foreach (string c in vegetables)
            {
                Console.WriteLine(c);
            }
            while(!stable)
            {
                userChoice = Console.ReadLine().ToLower();
                itemList = vegetables.Exists(z => z.ToLower() == userChoice);
                if(itemList)
                {
                    stable = true;
                    for (int b = 0; b < vegetables.Count; b++)
                    {
                        if (userChoice == vegetables[b].ToLower())
                        {
                            Console.WriteLine("The index of the vegetable chosen is " + b);
                        }           
                    }
                }
                else
                {
                    Console.WriteLine("Oops, please choose a vegetable from the list above");
                }
            }

            //LIST THREE --------------------------------------------------------------------------------------
            
            List<string> animals = new List<string>() { "bat", "cat", "bat", "rat", "horse", "horse", "dog", "parrot", "chinchilla" };
            List<string> animalslistTwo = new List<string>();
            List<string> listDuplicates = new List<string>();
           

            foreach (string animal in animals)
            {
                if (!animalslistTwo.Contains(animal))
                {
                    animalslistTwo.Add(animal);
                }
                else
                {
                    listDuplicates.Add(animal);
                }
            }
            Console.WriteLine("\nDisplay of animals list items: " + string.Join(", ", animalslistTwo));
            Console.WriteLine("Display of duplicate items: " + string.Join(", ", listDuplicates));
            Console.WriteLine("Display of modified list: " + string.Join(", ", animals));
            Console.ReadLine();
        }
          
    }
}
