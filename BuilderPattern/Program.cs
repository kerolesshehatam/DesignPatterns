using BuilderPattern.Builder;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder;
            VehicleFactory factory = new VehicleFactory();

            builder = new MotorCycleBuilder();
            factory.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            factory.Construct(builder);
            builder.Vehicle.Show();

        }
    }
}
