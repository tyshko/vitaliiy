using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Cat : Animal
    {
       public override void Eat()
        {
            Console.WriteLine("Cat can eat");
        }

        public void Meaw()
        {
            Console.WriteLine("Cat can meaw");
        }

        public override string ToString()
        {
            return $"Cat with name: {Name}, Age:{Age}, Weight:{Weight}";
        }
    }
}
