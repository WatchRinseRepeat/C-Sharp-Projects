using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class MathOp
    {
        public int Addition(int number)
        {
            return number + 5; //Add 5 to the int
        }

        public int Addition(double number)
        {
            return Convert.ToInt32(number + 5); //Add 5 to the double and then convert to Int
        }

        public int Addition(String number)
        {
            return Convert.ToInt32(number) + 5; //Convert string to int and then add 5
        }
    }
}
