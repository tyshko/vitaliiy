using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Animal : IAnimal
    {
        protected internal string Name { get; set; }
        protected internal int Age { get; set; }
        protected internal int Weight { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("I can eat");
        }

        public abstract string ToString();
    }
}
