﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { FirstName = "Sample", LastName = "Student" }; //Instantiate employee

            employee.SayName(); //call the method

            Console.ReadLine();
        }
    }
}
