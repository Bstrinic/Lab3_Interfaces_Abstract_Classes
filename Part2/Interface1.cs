using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_Abstract_Classes.Part2
{
    //Define an interface for animals 
    public interface IAnimal 
    {
        //Adding the properties
        string Name { get; set; }
        string Colour { get; set; }
        double Height { get; set; }
        int Age { get; set; }

        //Adding the methods
        void Eat();
        string Cry();
    }

}
