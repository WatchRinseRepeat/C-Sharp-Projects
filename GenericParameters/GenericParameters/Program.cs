using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employee1 = new Employee<string>(); //Create employee, passing the data type String
            employee1.Things = new List<string> { "A", "B", "C", "Easy As" }; //create list of strings for Things

            Employee<int> employee2 = new Employee<int>(); //Create employee, passing the data type int
            employee2.Things = new List<int> { 1, 2, 3 }; //create list of ints for Things

            foreach (string thing in employee1.Things)  //write all the employee1 strings
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employee2.Things) //write all the employee2 ints
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
