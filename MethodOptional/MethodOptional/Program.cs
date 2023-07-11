using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptional
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOp mathOp = new MathOp();

            //Ask user for an integer
            Console.WriteLine("Enter an Integer:");
            int numOne = Convert.ToInt32(Console.ReadLine());

            //Ask user for a second Integer
            Console.WriteLine("Enter a second Integer (optional):");
            string input = Console.ReadLine();

            //if input = "" call without parameter
            if (input == "")
            {
                Console.WriteLine("The entries added together are: " + mathOp.Addition(numOne));
            }
            else //else call with parameter
            {
                int numTwo = Convert.ToInt32(input);
                Console.WriteLine("The entries added together are: " + mathOp.Addition(numOne, numTwo));
            }
            
            Console.ReadLine();
        }
    }
}
