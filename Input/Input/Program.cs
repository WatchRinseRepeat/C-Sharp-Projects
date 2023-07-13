using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:"); //Ask for a number
            string input = Console.ReadLine(); //save the number as variable
            using (StreamWriter writer = new StreamWriter(@"C:\users\saeyr\logs\numbers.txt", true)) //create a temp streamwriter object
            {
                writer.WriteLine(input); //write the input to file
            }

            string reader = File.ReadAllText(@"C:\users\saeyr\logs\numbers.txt");
            Console.WriteLine("The file says this:\n{0}", reader); //report on the input
            Console.ReadLine(); 
        }
    }
}
