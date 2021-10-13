using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }

        public abstract void Eat();
        public virtual void Move()
        {
            Console.WriteLine("It cans move !");
        }



    }


    public class Rabbit : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Rabbits eat karrot...");
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Robbit cans move ...");
        }
    }

    public class Goat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Goats eat grass...");
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("Goat cans move ...");
        }
    }



}
