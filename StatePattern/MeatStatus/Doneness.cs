using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.MeatStatus
{
   public abstract class Doneness
    {
        protected Steak steak;
        protected double currentTemp;
        protected double lowerTemp;
        protected double upperTemp;
        protected bool canEat;

        public Steak Steak
        {
            get { return steak; }
            set { steak = value; }
        }

        public double CurrentTemp
        {
            get { return currentTemp; }
            set { currentTemp = value; }
        }

        public abstract void IncreaseTemp(double temp);
        public abstract void DecreaseTemp(double temp);
        public abstract void DonenessCheck();
    }
}
