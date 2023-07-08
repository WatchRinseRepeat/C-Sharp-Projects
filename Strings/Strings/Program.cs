using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get 3 strings
            Console.WriteLine("Write soemthing:");
            string first = Console.ReadLine() + " ";
            Console.WriteLine("Write soemthing:");
            string second = Console.ReadLine() + " ";
            Console.WriteLine("Write soemthing:");
            string third = Console.ReadLine() + " ";
            //Concatenate the strings
            Console.WriteLine("You wrote: " + first + second + third);

            //Use stringbuilder to add to a paragraph.

            StringBuilder sb = new StringBuilder(); //make a stringbuild instance;
            Console.WriteLine("Now write a sentance.");
            sb.Append(Console.ReadLine() + " ");
            Console.WriteLine("Now write a sentance.");
            sb.Append(Console.ReadLine() + " ");
            Console.WriteLine("Now write a sentance.");
            sb.Append(Console.ReadLine() + " ");

            //Output the paragraph
            Console.WriteLine("You wrote the following:");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
