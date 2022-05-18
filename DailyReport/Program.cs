using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Daily Report");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What Course Are You On?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What Page Number Are You On?");
            string yourPage = Console.ReadLine();
            int pageNum = Convert.ToInt32(yourPage);

            Console.WriteLine("Do you need help with anything?  Please answer using True or False");
            string helpOrNot = Console.ReadLine();
            bool answerBool = Convert.ToBoolean(helpOrNot);

            Console.WriteLine("Were there any positive experiences you'd like to share?  Please give specifics");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide?  Please give specifics");
            string extraFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int numHoursStudied = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your answers!  An instructor will respond to this shortly.  Have a great day!");
        }
    }
}
