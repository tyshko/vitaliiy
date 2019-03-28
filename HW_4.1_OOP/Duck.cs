using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Duck : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Duck can eat");
        }

        public void Fly()
        {
            Console.WriteLine("Duck can fly");
        }
        
        public override string ToString()
        {
            return $"Duck with name: {Name}, Age:{Age}, Weight:{Weight}";
        }
    }
}

