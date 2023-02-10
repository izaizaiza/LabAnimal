using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLab
{
    internal class ImplementedCat : Animal, IAnimal
    {
        

        //constructor
        public ImplementedCat(string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }




        public override void Eat()
        {
            Console.WriteLine("Cat eat mice.");
        }

        public string Cry()
        {
            return "Meow!";
        }
    }
}
