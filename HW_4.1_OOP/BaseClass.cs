using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BaseClass
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog { Name = "Baddy", Weight = 5, Age = 2 });
            animals.Add(new Cat { Name = "Catty", Weight = 4, Age = 5 });
            animals.Add(new Duck { Name = "Daggy ", Weight = 10, Age = 10 });
            animals.Add(new Strauss { Name = "Strausik", Weight = 12, Age = 15 });

            foreach (Animal animal in animals)
            {
                animal.Eat();
            }

            var a = animals.Where(animal => animal.GetType() == typeof(Cat))
                .Select(animal => (Cat)animal)
                .ToList();

            foreach (var b in a)
            {
                b.Meaw();
            }

            PrintAllAnimal(animals);
            Console.ReadKey();
        }

        private static void PrintAllAnimal(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}


