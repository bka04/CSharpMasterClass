using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterClass
{
    abstract class Shape //cant create object off shape directly, but will use its properties/methods
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name}");
        }

        public abstract double Volume(); // when a class inherits, it will need to implement this

    }
}
