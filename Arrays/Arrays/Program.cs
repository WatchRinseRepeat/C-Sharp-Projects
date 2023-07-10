using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //create one-dimensional array of strings
            string[] strings = { "Larry", "Curly", "Moe" };
            //ask user to select an index
            Console.WriteLine("Choose a number from 0-2 to display a string:");
            string input = Console.ReadLine();
            int inNumb = Convert.ToInt32(input);
            //check if number is within the length of the arrary.
            if (inNumb < strings.Length && inNumb >= 0)
            {
                Console.WriteLine("The string at that index is: " + strings[inNumb]);
            }
            else //if so show the number.
            {
                Console.WriteLine("That is not within the index of the array.");
            }


            //create one-dimensional array of ints

            int[] ints = { 5, 3, 2, 5 };
            //ask user to select an index
            Console.WriteLine("Choose a number from 0-3 to display an int:");
            input = Console.ReadLine();
            inNumb = Convert.ToInt32(input);
            //check if number is within the length of the arrary.
            if (inNumb < ints.Length && inNumb >= 0)
            {
                Console.WriteLine("The int at that index is: " + ints[inNumb]);
            }
            else //if so show the number
            {
                Console.WriteLine("That is not within the index of the array.");
            }


            //create a list of strings
            List<string> stringList = new List<string> { "Jason", "Kim", "Tommy", "Zack", "Trini", "Billy" };

            //ask user to select an index
            Console.WriteLine("Choose a number from 0-5 to display a string:");
            input = Console.ReadLine();
            inNumb = Convert.ToInt32(input);
            //check if number is within the length of the arrary.
            if (inNumb < stringList.Count && inNumb >= 0)
            {
                Console.WriteLine("The int at that index is: " + stringList[inNumb]);
            }
            else //if so show the number
            {
                Console.WriteLine("That is not within the index of the List.");
            }



            Console.ReadLine();
        }
    }
}
