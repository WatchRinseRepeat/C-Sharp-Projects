using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Example
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Example() : this(10) //constructor with no parameters
        {
            
        }
        public Example(int id) : this(id, "John Doe") //constructor with one parameter 
        {
            
        }
        public Example(int id, string name) //constructor with all parameters
        {
            Id = id;
            Name = name;
        }
    }
}
