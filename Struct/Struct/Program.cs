using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(); //Instantiate number
            number.Value = 5m; // Assigne value to Value in number

            Console.WriteLine(number.Value); //Write to console
            Console.ReadLine();
        }
    }
}
