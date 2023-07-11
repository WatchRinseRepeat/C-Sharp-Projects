using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { FirstName = "Sample", LastName = "Student" };  //Instantiate instance of subclass

            employee.SayName(); //Call the superclass method SayName()

            Console.ReadLine();
        }
    }
}
