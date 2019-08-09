using System;

namespace DigitalWorkshop
{
    public class Vehicle
    {
        public int NumberOfWheels;
        public int Color;
        public int NumberOfDoors;
        public int NumberOfSeats;
        public string Brand;
        

        private object Motor;

        protected object Driver;

        // Contructor
        public Vehicle(int numberOfWheels, int numberOfSeats)
        {
            Console.WriteLine("Construct Vehicle");
            this.NumberOfWheels = numberOfWheels;
            this.NumberOfSeats = numberOfSeats;
        }

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

    // Heritage
    public class Car : Vehicle
    {
        public int NumberOfBackGlasses;

        public Car()
            : base(3, 5)
        {
            Console.WriteLine("Construct Car");
        }

        public object GetDriver()
        {
            return this.Driver;
        }
    }

    public class BMW : Car
    {
        public void Drive()
        {
            
        }
    }
}
