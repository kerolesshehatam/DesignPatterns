using System;

namespace StatePattern.MeatStatus
{
    public class Steak
    {
        private Doneness _state;

        private string _beefCut;

        public Steak(string beefCut)
        {
            _beefCut = beefCut;
            _state = new Rare(0.0, this);
        }

        public double CurrentTemp
        {
            get { return _state.CurrentTemp; }
        }

        public Doneness State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void IncreaseTemp(double amount)
        {
            _state.IncreaseTemp(amount);
            Console.WriteLine("Increased temperature by {0} degrees.", amount);
            Console.WriteLine(" Current temp is {0}", CurrentTemp);
            Console.WriteLine(" Status is {0}", State.GetType().Name);
            Console.WriteLine("");
        }

        public void DecreaseTemp(double amount)
        {
            _state.DecreaseTemp(amount);
            Console.WriteLine("Decreased temperature by {0} degrees.", amount);
            Console.WriteLine(" Current temp is {0}", CurrentTemp);
            Console.WriteLine(" Status is {0}", State.GetType().Name);
            Console.WriteLine("");
        }
    }
}