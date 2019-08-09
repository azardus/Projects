using System;

namespace DigitalWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicle = new Vehicle(4, 5);

            object currentMotor = vehicle.GetMotor();
            vehicle.SetMotor(null);

            Vehicle myCar = new Car();
            myCar.GetMotor();

            Car myBmw = new BMW();
            Vehicle myBmwAsVehicle = myBmw;

            BMW bmw = new BMW();

            Console.Read();
        }
    }
}
