using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Strauss : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Strauss can eat");
        }
        
        public override string ToString()
        {
            return $"Strauss with name: {Name}, Age:{Age}, Weight:{Weight}";
        }
    }
}
