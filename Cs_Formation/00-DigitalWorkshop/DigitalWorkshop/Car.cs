using System;

namespace DigitalWorkshop
{
    public class Vehicle
    {
        public Vehicle(string brand, int numberOfWheels)
        {
            this.Brand = brand;
            this.NumberOfWheels = numberOfWheels;
            Console.WriteLine($"félicitation vous avez construit votre véhicule {brand}");
        }

        public int NumberOfWheels;

        public int Color;

        public int NumberOfDoors;

        public int NumberOfSeats;

        public string Brand;

        private object Motor;

        public object GetMotor()
        {
            return this.Motor;
        }

        public void SetMotor(object newMotor)
        {
            // Do some things
            this.Motor = newMotor;
        }
    }
}
