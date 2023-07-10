using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment Part 1:

            //Create a one-dimensional array of strings.
            string[] stringArray = {
                "If you're happy and you know it ",
                "If you're happy and you know it ",
                "If you're happy and you know it then your face will surely show it\nIf you're happy and you know it "
            };
            // Ask the user to input text.
            Console.WriteLine("Enter an action:");
            string input = Console.ReadLine();
            
            //Itterate through the array and add the input to each string.
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + input;
            }

            //Create second loop to print out the combined strings
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            // Assignment Part 2:

            //Create an Infinate Loop:
            bool fixMe = true;
            while (fixMe) {
                //This will continue forever because fixMe never changes.
                Console.WriteLine("This goes one forever.");
                //fixed the infinate loop by making fixMe = False
                fixMe = false;
            }

            //Assignment Part 3:

            //Create a loop where the comparison is a <
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(Convert.ToString(i));
            }
            //Create another loop where the comparison is a <=
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(Convert.ToString(i));
            }

            //Assignment Part 4:

            //A List of strings where each item is unique.
            List<String> words = new List<String> {"Tom", "Dick", "Harry"};
            //Ask user to input text to seach for.
            Console.WriteLine("Enter text to search for:");
            input = Console.ReadLine();
            bool found = false;
            //loop that itereates through the list and displays the index of the item containing the matching text
            int count = 0;
            foreach (string word in words)
            {
               if (word.Contains(input)){
                    Console.WriteLine(input + " was found at index " + count);
                    found = true;
                    break; //stop the loop once a match has been found.
                }
                count++;
            }
            // check if the user put text that isn't on the list and if they did tell the user.
            if (!found)
            {
                Console.WriteLine("That wasn't in the list.");
            }

            //Assignment Part 5:

            //Create new list with one pair of identical strings
            List<String> newWords = new List<string> {"Terry", "Andy", "Melissa", "Terry"}; 
            List<int> places = new List<int> { }; // list to track where the entry 
            count = 0;

            //Ask user to input text to seach for.
            Console.WriteLine("Enter text to search for:");
            input = Console.ReadLine();

            foreach (string word in newWords) //check each string in the list.
            {
                if (word.Contains(input)) //if the term is found
                {
                    places.Add(count); //add the count to the list of places
                }
                count++; //increment count 
            }

            if (places.Count == 0) //if places.count = 0 then none were found
            {
                Console.WriteLine("That wasn't found."); //Tell user none were found.
            }
            else //Tell the user where the term was found.
            {
                Console.WriteLine("The term was found at indices:"); 
                foreach (int place in places)
                {
                    Console.WriteLine(place);
                }
            }

            //Assignment Part 6:

            List<String> comparables = new List<string> {"John", "Jacob", "Jinglehiemer", "Shmidt", "John" }; //New list of Strings with one duplicate.
            List<String> entries = new List<string> { }; //List for tracking what has been checked for in the list:

            foreach (string comparable in comparables) // for each item in the List:
            { 
                //Check if item has been seen
                if (entries.Contains(comparable)) //if so say so and add to List.
                {
                    Console.WriteLine(comparable + " - this item is a duplicate.");
                    entries.Add(comparable);
                }
                else //If not, say so and add to list
                {
                    Console.WriteLine(comparable + " - this item is unique.");
                    entries.Add(comparable);
                }
            }



            Console.ReadLine();
        }
    }
}
