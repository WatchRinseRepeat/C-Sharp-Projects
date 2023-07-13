using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 10 employees, 2 of which are named Joe
            Employee employee1 = new Employee { FirstName = "Joe", LastName = "A" , ID = 1 };
            Employee employee2 = new Employee { FirstName = "Joe", LastName = "B", ID = 2 };
            Employee employee3 = new Employee { FirstName = "Tom", LastName = "Smith", ID = 3 };
            Employee employee4 = new Employee { FirstName = "Bill", LastName = "Jones", ID = 4 };
            Employee employee5 = new Employee { FirstName = "Schmidty", LastName = "Larson", ID = 5 };
            Employee employee6 = new Employee { FirstName = "Jake", LastName = "Johnson", ID = 6 };
            Employee employee7 = new Employee { FirstName = "Al", LastName = "Franklen", ID = 7 };
            Employee employee8 = new Employee { FirstName = "Barry", LastName = "Manilow", ID = 8 };
            Employee employee9 = new Employee { FirstName = "Ariel", LastName = "Merre", ID = 9 };
            Employee employee0 = new Employee { FirstName = "Mark", LastName = "Arket", ID = 10 };

            List<Employee> employees = new List<Employee> //create list of 10 employees
            {
                employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee0
            };

            List<Employee> Joes = new List<Employee>(); //Create list for Joes

            foreach (Employee employee in employees) //using for loop go through list of employees
            {
                if (employee.FirstName == "Joe") // Find where the FirstName is "Joe"
                {
                    Joes.Add(employee); //Add the Joe to the list
                }
            }

            List<Employee> lambdaJoes = employees.Where(x => x.FirstName == "Joe").ToList(); //Add all Joes from employees to lambdaJoes

            List<Employee> lambdaFives = employees.Where(x => x.ID > 5).ToList(); //Add all IDs that are greater than 5 to lambdaFives

            Console.ReadLine();
        }
    }
}
