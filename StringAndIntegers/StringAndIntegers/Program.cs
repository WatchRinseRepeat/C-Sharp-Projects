using System;
using System.Collections.Generic;


namespace StringAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Create a list of integers.
                List<int> numbers = new List<int> { 70, 50, 30, 53, 45, 113 };
                //Ask user for a number to divide each number by
                Console.WriteLine("Enter an integer:");
                int input = Convert.ToInt32(Console.ReadLine());
                //Loop that does the division for each and outputs it to the console.
                foreach (int number in numbers)
                {
                    int result = number / input;
                    Console.WriteLine(number + "/" + input + " = " + result); //Display the result
                }
            }
            catch (DivideByZeroException ex) //exception for if the user enters 0
            {
                Console.WriteLine("You can't divide by zero.");
            }
            catch (FormatException ex) //Exceception for if the user enters a string or float
            {
                Console.WriteLine("That is not an Integer.");
            }
            catch (Exception ex) // Genearl exception
            {
                Console.WriteLine(ex);
            }
            finally //No matter what the result, wait for input
            {
                Console.ReadLine();
            }


            
        }
    }
}
