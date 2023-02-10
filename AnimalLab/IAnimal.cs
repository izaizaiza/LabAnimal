using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLab
{
    public interface IAnimal
    {
        // property signatures:
        string Name { get; set; }   
        string Colour { get; set; }
        int Age { get; set; }


        //eat method -  void
        //note: to be implemented on the implementation class
        void Eat();

        //cry method - string
        //note: to be implemented on the implementation class
        string Cry();




    }
}
