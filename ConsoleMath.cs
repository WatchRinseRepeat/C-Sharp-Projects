using System;


namespace ConsoleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            string userInput = Console.ReadLine();
            float userNumber = Convert.ToSingle(userInput);  // convert string to a float in case of decimal numbers
            float timesFifty = userNumber * 50;
            Console.WriteLine(userInput + " times 50 equals: " + timesFifty);  //print result to console

            Console.WriteLine("Input a number:"); //take input from user
            userInput = Console.ReadLine();
            userNumber = Convert.ToSingle(userInput);  // convert string to a float in case of decimal numbers
            float plusTwentyFive = userNumber + 25; //add 25
            Console.WriteLine(userInput + " plus 25 equals: " + plusTwentyFive);  //print result to console

            Console.WriteLine("Input a number:"); //take input from user
            userInput = Console.ReadLine();
            userNumber = Convert.ToSingle(userInput);  // convert string to a float in case of decimal numbers
            float twelve = Convert.ToSingle(12.5);
            float divided = userNumber / twelve; //divide by 12.5
            Console.WriteLine(userInput + " divided by 12.5 equals: " + divided);  //print result to console

            Console.WriteLine("Input a number:"); //take input from user
            userInput = Console.ReadLine();
            userNumber = Convert.ToSingle(userInput);  // convert string to a float in case of decimal numbers
            bool isGreater = userNumber > 50; //Check if greater than 50
            Console.WriteLine(userInput + " is greater than 50?: " + isGreater);  //print result to console

            Console.WriteLine("Input a number:"); //take input from user
            userInput = Console.ReadLine();
            userNumber = Convert.ToSingle(userInput);  // convert string to a float in case of decimal numbers
            byte remainder = Convert.ToByte(userNumber % 7); //divide by 7 and get remainder
            Console.WriteLine(userInput + " divided by 7 leaves a remainder of: " + remainder);  //print result to console//print to console



            Console.ReadLine();
        }

    }

}