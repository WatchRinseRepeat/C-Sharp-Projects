using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Employee : Person, IQuitablle
    {

        public override void SayName() //Overide the base method
        {
            Console.Write("Employee ");
            base.SayName();
        }

        public void Quit() //implement the Quit method
        {

            Console.WriteLine(FirstName + " " + LastName + " quits!");
            Console.ReadLine();
        }
    }
}
