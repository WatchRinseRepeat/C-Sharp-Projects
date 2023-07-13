using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for their age.
            Console.WriteLine("Please enter your age:");
            string input = Console.ReadLine();
            DateTime today = DateTime.Now;
            int age = 0;
            //try catch for user input:
            try
            {
                age = Convert.ToInt32(input);
                if (age < 0) throw new MinusException(); //if input is negative throw exception
                else if (age == 0) throw new ZeroException(); //if input is zero throw exception
                else age *= -1; //invert the value of input
                
            }
            catch (MinusException) //exception if age is negative
            {
                Console.WriteLine("You can't be a negative age.");
                Console.ReadLine();
                return;
            }
            catch (ZeroException) //exception if age = 0
            {
                Console.WriteLine("You can't be 0 and be using this program.");
                Console.ReadLine();
                return;
            }
            catch (Exception)  //general exception
            {
                Console.WriteLine("An exception was thrown. Did you enter an integer?"); 
                Console.ReadLine();
                return;
            }

            DateTime yearBorn = today.AddYears(age);
            //Display year born
            Console.WriteLine("You were born in {0}.",yearBorn.Year);
            Console.ReadLine();
        }
    }
}
