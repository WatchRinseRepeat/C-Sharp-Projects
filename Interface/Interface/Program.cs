using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuitablle employee = new Employee { FirstName = "Sample", LastName = "Student" }; //Instantiate employee using polymorphism

            employee.Quit(); //call the method

            Console.ReadLine();
        }
    }
}
