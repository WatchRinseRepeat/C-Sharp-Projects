using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { FirstName = "Al", LastName = "Smith", ID = 1 }; //instantiate employee 1
            Employee emp2 = new Employee { FirstName = "Bob", LastName = "Smith", ID = 2 }; //instantiate employee 2

            Console.WriteLine("Is Employee 1 equal to Employee 2?"); //write to consle
            Console.WriteLine(emp1 == emp2); //report if emp1 is equal to emp2

            Console.WriteLine("Is Employee 1 not equal to Employee 2?"); //write to console
            Console.WriteLine(emp1 != emp2); //report if emp1 not equal to emp2

            Console.ReadLine();
        }
    }
}
