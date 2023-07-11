using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Person
    {
        public string FirstName { get; set; } //string for first name
        public string LastName { get; set; }  //string for last name

        public virtual void SayName() //method to say the full name in the console
        {
            
            
        }
    }

}
