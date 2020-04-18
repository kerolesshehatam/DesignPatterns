using System;

namespace NullObjectPattern
{
    //mobile type implementing IMobile interface  
    public class AppleIPhone : IMobile
    {
        public void TurnOff()
        {
            Console.WriteLine("\n AppleIPhone Turned OFF!");
        }

        public void TurnOn()
        {
            Console.WriteLine("\n AppleIPhone Turned ON!");
        }
    }
}
