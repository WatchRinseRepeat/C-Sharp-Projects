using System;


namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the app. Please enter a letter:");
            string entry = "";         
            //while loop
            while (entry == "")
            {
                Console.WriteLine("Please enter something:");
                entry = Console.ReadLine();
            }
            Console.WriteLine("Very good.");
            //do while loop
            do
            {
                Console.WriteLine("Now enter the right number if you want to leave the program:");
                entry = Console.ReadLine();
            }
            while (entry != "8");
            Console.WriteLine("You finally entered 8, I guess you can leave now.");
            Console.ReadLine();
        }
    }
}
