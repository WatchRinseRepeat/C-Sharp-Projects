using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptional
{
    class MathOp
    {
        public int Addition(int numOne, int numTwo = 0) 
        {
            return numOne + numTwo;
        }
    }
}
