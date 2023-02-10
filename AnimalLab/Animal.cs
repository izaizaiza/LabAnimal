using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLab
{
    internal abstract class Animal
    {
        /// <summary>
        /// abstract class that is the parent class 
        /// </summary>
        
        
        private string name;
        private string colour;
        private int age;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //constructor
        public Animal()
        {

        }
        public Animal(string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }

        //abstract method to be overrriden
        public abstract void Eat();
        

    }//end of animal class
}//end of namespace
