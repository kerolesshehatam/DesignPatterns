using System;

namespace NullObjectPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mobileRepository = new MobileRepository();
            IMobile mobile = mobileRepository.GetMobileByName("sony");
            mobile.TurnOn();
            mobile.TurnOff();

            IMobile nullObject = mobileRepository.GetMobileByName("Not Found");
            nullObject.TurnOn();
            nullObject.TurnOff();

            Console.ReadLine();

        }
    }
}
