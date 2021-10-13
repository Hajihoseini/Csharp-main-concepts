using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{


    public enum AnimalType
    {
        Pet,
        Wild
    }


    class Cat :Animal
    {
        public string AnimalColor { get; set; }
        public AnimalType animalType { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Cats eat hens ...");
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Cat cans move ...");
        }
    }


}
