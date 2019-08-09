using System;

namespace DigitalWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmw = "";
            // test sur la class Car :
            var vehicle = new Vehicle(bmw, 2);

            object currentMotor = vehicle.GetMotor();
            vehicle.SetMotor(null);

            // vehicle.Color

            Console.Read();

            // test sur la class MyClass :
            var fulgor = new Dog();
            fulgor.Age = 20;

            Console.WriteLine($"le fulgor à {fulgor.Age} ans");
        }
    }
}
