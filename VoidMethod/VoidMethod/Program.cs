using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOp mathOp = new MathOp();

            mathOp.ShowResult(5, 10); //call the method passing in two numbers.

            mathOp.ShowResult(numOne: 5, numTwo: 10); //call the method and name the parameters the arguments are being passed to

            Console.ReadLine();
        }
    }
}
