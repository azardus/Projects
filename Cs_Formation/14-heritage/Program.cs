using System;

namespace _14_heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heritage de base :");
            //Visu en Animal // avec new  j'ai une création vu en animal
            Animal unAnimal1 = new Animal();
            unAnimal1.GetName();
            unAnimal1.SetAge(42);

            //Polymorphisme d'heritage
            Animal unAnimal3 = new Dog();
            unAnimal3.GetAge();
            unAnimal3.SetAge(89);
            //visu en Dog
            Dog unDog = new Dog();
            // unDog.GetName();
            // visu en Animal
            Animal unAnimal2 = unDog;

            unDog.ChooseDogName("Rex2");

            Console.WriteLine($" [ l'animal 2 ] s'appelle {unAnimal1.GetName()}");

            Console.WriteLine($"Mon animal_1 a {unAnimal1.GetAge()}");

            Console.WriteLine($"Mon animal_3 a {unAnimal3.GetAge()}");



        }
    }
}
