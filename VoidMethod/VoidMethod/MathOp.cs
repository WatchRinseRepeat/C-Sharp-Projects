using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class MathOp
    {
        public void ShowResult(int numOne, int numTwo)
        {
            numOne = numOne + numTwo; //Perform a math operation on parameter 1
            Console.WriteLine(numTwo); //Display the second integer
        }
    }
}
