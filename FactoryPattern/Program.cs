using FactoryMethodPattern;
using FactoryMethodPattern.Models;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new VehicleFactory();

            IVehicle scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IVehicle bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            Console.ReadKey();

        }
    }
}
