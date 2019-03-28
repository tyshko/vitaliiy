using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog can eat");
        }

        public void Bark()
        {
            Console.WriteLine("Собака гавкає");
        }
        
        public override string ToString()
        {
            return $"Dog with name: {Name}, Age:{Age}, Weight:{Weight}";
        }
    }
}
