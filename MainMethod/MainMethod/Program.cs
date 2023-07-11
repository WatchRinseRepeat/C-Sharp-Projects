using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOp mathOp = new MathOp();
            Console.WriteLine(mathOp.Addition(5));  //call the int version 
            Console.WriteLine(mathOp.Addition(5.5)); //call the double version
            Console.WriteLine(mathOp.Addition("5")); //call the string version

            Console.ReadLine();
        }
    }
}
