using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;

            Console.WriteLine(currentDate); //print current date/time
            Console.WriteLine("Please enter a number:"); //ask for a number
            double input = Convert.ToDouble(Console.ReadLine()); //convert input to double 

            string later = DateTime.Now.AddHours(input).ToString();//Get the date/time input hours from now

            Console.WriteLine("In {0} hours it will be {1}", input, later); //write to console

            Console.ReadLine();
        }
    }
}
