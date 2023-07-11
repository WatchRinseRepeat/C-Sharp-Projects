using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to do math operations on:"); // ask for integer
            int input = Convert.ToInt32(Console.ReadLine());

            Operations operations = new Operations(); //create new instance of the Operations class

            Console.WriteLine(operations.Addition(input)); // call the Addition method
            Console.WriteLine(operations.Subtraction(input)); //call the Subtraction method
            Console.WriteLine(operations.Multiplication(input)); // call the Multiplication method



            Console.ReadLine();
        }
    }
}
