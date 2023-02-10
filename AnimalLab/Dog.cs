using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLab
{
    internal class Dog:Animal
    {
        public Dog()
        {

        }
        public Dog(string name, string colour, int age) : base(name, colour, age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
    }
}
