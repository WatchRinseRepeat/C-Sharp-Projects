using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadClass
{
    class Overload
    {
        public void Divide(int num1)
        {
            Console.WriteLine(num1 / 2); //Divide the input by 2 and send to teh Console.
        }

        public void Divide(string num1)  //Overload a method
        {
            Console.WriteLine(Convert.ToInt32(num1)/ 2); 
        }

        public static string Explain() //Create a method with output parameters AND Declare a class to be static
        {
            return ("This method took no parameters.");
        }
    }
}
