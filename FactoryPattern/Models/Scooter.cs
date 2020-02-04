using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Models
{
    public class Scooter : IVehicle
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }
}
