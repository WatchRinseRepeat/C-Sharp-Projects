using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator== (Employee one, Employee two) //Overload "is equal" to check if two employees are the same based on the ID property
        {
            if (one.ID == two.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator!= (Employee one, Employee two)//Overload "is not equal" to check if two employees are the same based on the ID property
        {
            if (one.ID == two.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
