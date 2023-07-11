using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Overload overload = new Overload();  //Create instance of the object
            
            Console.WriteLine("Please enter an integer: "); //Ask user for an integer

            overload.Divide(Console.ReadLine()); //Call method

            Console.ReadLine(); 

        }
    }
}
