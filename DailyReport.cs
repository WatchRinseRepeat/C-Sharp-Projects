using System;


namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title 
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.\n");

            //Questions
            //  name
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine(); //stored as String
            //  course
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine(); //stored as String
            //  page number
            Console.WriteLine("What page number are you on?");
            string pageResponse = Console.ReadLine(); //stored as ushort because it could be larger than 255
            ushort pageNumber = Convert.ToUInt16(pageResponse);
            //  Help? (bool)
            Console.WriteLine("Do you need help with anything? Please answer \"true\" of \"false\".");
            string helpResponse = Console.ReadLine(); //stored as Bool
            bool needHelp = Convert.ToBoolean(helpResponse);
            //  Positive Experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiance = Console.ReadLine(); //stored as String
            //  Feedback
            Console.WriteLine("Is there any feedback you'd like to provide?");
            string feedback = Console.ReadLine(); //stored as String
            //  Hours
            Console.WriteLine("How many hours did you study today?");
            string hoursResponse = Console.ReadLine(); //stored as byte
            byte hoursStudied = Convert.ToByte(hoursResponse);
            //Outro
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
