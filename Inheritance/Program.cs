using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            cat.AnimalColor = "Yellow";
            cat.animalType = AnimalType.Pet;
            cat.AnimalName = "Persian cat";


            Rabbit rabbit = new();
            rabbit.Eat();
            cat.Eat();


            Animal animalN1 = new Cat();
            Animal animalN2 = new Goat();

            animalN1.Eat();
            animalN2.Eat();

            Console.WriteLine("===========================================");

            AnimalMove();

        }

        private static void AnimalMove()
        {
            Cat cat = new();
            cat.Move();

            Goat goat = new();
            goat.Move();


        }

    }
}
