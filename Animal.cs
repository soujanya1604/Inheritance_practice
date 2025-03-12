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
        public Animal() 
        {
            _type = "Aquatic";
        }
        public Animal(string type)
        {
            _type = type;
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
            Console.WriteLine("Type of Animal");

            Animal animal = new Animal("Wild");
            animal.DisplayAnimalType();

            Animal animal1 = new Animal("Domestic");
            animal1.DisplayAnimalType();

            Animal animal2 = new Animal();
            animal2.DisplayAnimalType();

        }
    }
}
