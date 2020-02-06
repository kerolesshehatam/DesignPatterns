namespace StatePattern.MeatStatus
{
    public class Ruined : Doneness
    {
        public Ruined(Doneness state) : this(state.CurrentTemp, state.Steak)
        {
        }

        public Ruined(double currentTemp, Steak steak)
        {
            this.currentTemp = currentTemp;
            this.steak = steak;
            canEat = true;
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 170;
            upperTemp = 230;
        }

        public override void IncreaseTemp(double amount)
        {
            currentTemp += amount;
            DonenessCheck();
        }

        public override void DecreaseTemp(double amount)
        {
            currentTemp -= amount;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemp < 0)
            {
                steak.State = new UncookedStatus(this);
            }
            else if (currentTemp < lowerTemp)
            {
                steak.State = new Medium(this);
            }
        }
    }
}