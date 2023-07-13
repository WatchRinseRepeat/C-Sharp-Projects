using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for the current day of the week.
            Console.WriteLine("Please enter the day of the week:");
            string input = Console.ReadLine();

            try 
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);  //This doesn't work
                Console.WriteLine(day + " is a day of the week.");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week."); //This works

                
            }
            //Assign the value to a variable of that enum datatype
            Console.WriteLine("Thank you, have a nice day.");

            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
