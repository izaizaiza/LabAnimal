using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalLab
{
    internal class ImplementedDog : Animal, IAnimal
    {
        //constructor
        public ImplementedDog(string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }




        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public string Cry()
        {
            return "Woof!";
        }
    }
}
