using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TWO = 2; //Create a constant.

            var stringList = new List<String>(); //implicitly create variable

            Example example = new Example();

            Console.WriteLine(example.Name);

            Console.ReadLine();
        }
    }



}
