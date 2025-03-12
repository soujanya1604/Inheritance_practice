using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practice
{
    internal class Animal
    {
        string _type;
        string _name;
        public Animal() 
        {
            _type = "Aquatic";
            _name = "Fish";
        }
        public Animal(string type,string name)
        {
            _type = type;
            _name = name;
        }

        public void DisplayAnimalType()
        {
            Console.WriteLine($"Type of Animal: {_type}");
        }
    }
    public class InheritanceExample
    {
        public static void RunExample()
        {
            Animal animal = new Animal("Wild","Tiger");
            animal.DisplayAnimalType();

            Animal animal1 = new Animal("Domestic","Dog");
            animal1.DisplayAnimalType();

            Animal animal2 = new Animal();
            animal2.DisplayAnimalType();

        }
    }
}
