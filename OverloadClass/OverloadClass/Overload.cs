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
            Console.WriteLine(Convert.ToInt32(num1) / 2);
        }

        public void Explain(out string explination)  //Create a method with and Out parameter
        {
            explination = "This method took no parameters.";
        }
    }

    static class This
        {
            //This is a static class
        }
}
