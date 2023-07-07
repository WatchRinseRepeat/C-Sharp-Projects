using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask age
            Console.WriteLine("What is your age?");
            string userInput = Console.ReadLine();
            byte userAge = Convert.ToByte(userInput); //make small number

            //Ask DUI?
            Console.WriteLine("Have you ever had a DUI? (yes or no, all lowercase)");
            userInput = Console.ReadLine();
            bool userDUI = userInput == "yes";

            //Ask speeding tickets
            Console.WriteLine("Ho many speeding tickets do you have?");
            userInput = Console.ReadLine();
            byte userTickets = Convert.ToByte(userInput);

            //Determine canDrive
            Console.WriteLine("User Qualified?");
            bool userQualified = userAge > 15 && userDUI != true && userTickets <= 3;
            Console.WriteLine(userQualified);
            Console.ReadLine();


        }
    }
}
